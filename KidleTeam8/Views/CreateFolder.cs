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
        private List<ClassFolder> listfolder;
        //private List<string> listfilename;
        ReadPDF ReadPDF;
        public CreateFolder(List<ClassFolder> folder)
        {
            InitializeComponent();
            listfolder = new List<ClassFolder>();
            //List<string> listfilename = new List<string>();
            ClassFile file = new ClassFile();
            ClassFolder fol = new ClassFolder();
            ReadPDF = new ReadPDF(file, fol);
            listfolder = folder;
            foreach(ClassFolder f in listfolder)
            {
                lstFolder.Items.Add(f.namefolder);
            }
            if(txtNameFolder.Text == "")
            {
                txtNameFolder.Text = listfolder[0].namefolder;
            }    
        }
        //Hiển thị folder lên từ database cho ListBox lstFolder(Hùng)
        private void display()
        {
            List<ClassFolder> lstfolders = FolderController.getListFolder();
            foreach(ClassFolder folder in lstfolders)
            {
                foreach(ClassFile file in folder.listfile)
                {
                    ListViewItem row = new ListViewItem(file.namefile);
                    row.SubItems.Add(file.path);
                    row.SubItems.Add(file.size);
                    
                }
                this.lstFolder.Items.Add(folder);
            }
        }
        // Thêm tên Folder
        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            if (txtNameFolder.Text != "" && this.listfolder.Where(x=> x.namefolder == txtNameFolder.Text).Count()<1)
            {
                lstFolder.Items.Add(txtNameFolder.Text);
                ClassFolder folder = new ClassFolder();
                folder.namefolder = txtNameFolder.Text;
                folder.listfile = new List<ClassFile>();
                listfolder.Add(folder);
            }
            else
            {
                MessageBox.Show("Nhập tên thư mục không hợp lệ","Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            // thêm folder vào database
            ClassFolder f = new ClassFolder();
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
                if (listfolder[index].listfile.ToList<ClassFile>().Where(
                    x => x.namefile == filename).Count() < 1)
                {
                    AddFileItem(ChooseFile.FileName);
                    ClassFile file = new ClassFile();
                    file.namefile = filename;
                    listfolder[index].listfile.Add(file);
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
            List<ClassFile> files = new List<ClassFile>();
            files = listfolder[indexfolder].listfile.ToList<ClassFile>();
            int index = files.FindIndex(x => x.namefile == lstFileName.SelectedItems[0].SubItems[1].Text + "\\"
            + lstFileName.SelectedItems[0].SubItems[0].Text);
            ReadPDF = new ReadPDF(files[index], listfolder[indexfolder]);
            ReadPDF.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lstFolder.SelectedItems.Count <= 0)
            {
                return;
            }

            ClassFolder f = FolderController.getFolder(lstFolder.Items[lstFolder.SelectedIndex].ToString());
            FolderController.DeleteFolder(f);
            BindingSource source = new BindingSource();
            source.DataSource = FolderController.getListFolder();
            this.lstFolder.DataSource = source;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // cập nhật lại folder đang chọn vào database

            //!! VẤN ĐỀ: định đổi tên folder mà lại tạo ra folder mới
            ClassFolder f = new ClassFolder();
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
                if (listfolder[index].listfile != null)
                {
                    lstFileName.Items.Clear();
                    foreach (ClassFile name in listfolder[index].listfile)
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