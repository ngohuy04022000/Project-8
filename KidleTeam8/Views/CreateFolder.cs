﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KindleTeam8.Models;
using KindleTeam8.Controllers;

namespace KindleTeam8.Views
{
    public partial class CreateFolder : Form
    {
        private List<Folder> listfolder;
        //private List<string> listfilename;
        ReadPDF ReadPDF;
        public CreateFolder(List<Folder> folder)
        {
            InitializeComponent();
            listfolder = new List<Folder>();
            //List<string> listfilename = new List<string>();
            Files file = new Files();
            Folder fol = new Folder();
            ReadPDF = new ReadPDF(file, fol);
            listfolder = folder;
            foreach(Folder f in listfolder)
            {
                lstFolder.Items.Add(f.namefolder);
            }
            if(txtNameFolder.Text == "")
            {
                txtNameFolder.Text = listfolder[0].namefolder;
            }    
        }
        // Thêm tên Folder
        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            if (txtNameFolder.Text != "" && this.listfolder.Where(x=> x.namefolder == txtNameFolder.Text).Count()<1)
            {
                lstFolder.Items.Add(txtNameFolder.Text);
                Folder folder = new Folder();
                folder.namefolder = txtNameFolder.Text;
                folder.filename = new List<Files>();
                listfolder.Add(folder);
            }
            else
            {
                MessageBox.Show("Nhập tên thư mục không hợp lệ","Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            // thêm folder vào database
            Folder f = new Folder();
            f.namefolder = this.txtNameFolder.Text.Trim();
            if (FolderController.AddFolder(f) == false)
            {
                MessageBox.Show("folder error");
            }
            txtNameFolder.Clear();
        }
        //Thêm File
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            if (txtNameFolder.Text == "")
            {
                return;
            }
            else
            {
                string filename = "";
                OpenFileDialog ChooseFile = new OpenFileDialog();
                ChooseFile.Filter = "PDF|*.pdf";
                if (ChooseFile.ShowDialog() == DialogResult.OK)
                {
                    filename = ChooseFile.FileName;
                }
                int index = this.listfolder.FindIndex(x => x.namefolder == txtNameFolder.Text);
                if (listfolder[index].filename.ToList<Files>().Where(
                    x => x.namefile == filename).Count() < 1)
                {
                    AddFileItem(ChooseFile.FileName);
                    Files file = new Files();
                    file.namefile = filename;
                    listfolder[index].filename.Add(file);
                }
                else
                {
                    MessageBox.Show("Đã có File này trong danh sách", "Thông Báo");
                }    
            }
        }
        public void AddFileItem(string filename)
        {
            FileInfo iffile = new FileInfo(filename);
            lstFileName.Invoke((Action)(() =>
            {
                string key = Path.GetExtension(filename);
                if (key == ".pdf")
                {
                    ListViewItem item = new ListViewItem(iffile.Name, key);
                    item.SubItems.Add(iffile.DirectoryName);
                    item.SubItems.Add(Math.Ceiling(iffile.Length / 1024f).ToString("0 KB"));
                    lstFileName.BeginUpdate();
                    lstFileName.Items.Add(item);
                    lstFileName.EndUpdate();
                }
            }));
        }
        //Mở File
        private void lstFileName_DoubleClick(object sender, EventArgs e)
        {
            int indexfolder = this.listfolder.FindIndex(x => x.namefolder == txtNameFolder.Text);
            List<Files> files = new List<Files>();
            files = listfolder[indexfolder].filename.ToList<Files>();
            int index = files.FindIndex(x => x.namefile == lstFileName.SelectedItems[0].SubItems[1].Text + "\\"
            + lstFileName.SelectedItems[0].SubItems[0].Text);
            ReadPDF = new ReadPDF(files[index], listfolder[indexfolder]);
            ReadPDF.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lstFolder.SelectedItems.Count <= 0)
            {
                return;
            }

            Folder f = FolderController.getFolder(lstFolder.Items[lstFolder.SelectedIndex].ToString());
            FolderController.DeleteFolder(f);
            BindingSource source = new BindingSource();
            source.DataSource = FolderController.getListFolder();
            this.lstFolder.DataSource = source;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // cập nhật lại folder đang chọn vào database

            //!! VẤN ĐỀ: định đổi tên folder mà lại tạo ra folder mới
            Folder f = new Folder();
            f.namefolder = txtNameFolder.Text.Trim();
            FolderController.UpdateFolder(f);
            //lstFolder.Items[lstFolder.SelectedIndex] = txtNameFolder.Text.Trim();
            //hiển thị lại listfolder
            BindingSource source = new BindingSource();
            source.DataSource = FolderController.getListFolder();
            this.lstFolder.DataSource = source;
        }

        private void lstFolder_Click(object sender, EventArgs e)
        {
            if (lstFolder.SelectedItem != null)
            {
                txtNameFolder.Text = lstFolder.SelectedItem.ToString();
                int index = this.listfolder.FindIndex(x => x.namefolder == txtNameFolder.Text);
                if (listfolder[index].filename != null)
                {
                    lstFileName.Items.Clear();
                    foreach (Files name in listfolder[index].filename)
                    {
                        AddFileItem(name.namefile);
                    }
                }
                else
                {
                    return;
                }
                return;
            }
        }
    }
}