﻿using KindleTeam8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidleTeam8
{
    public partial class MainForm : Form
    {
        private List<FolderFile> listfolder;
        private List<string> listfilename;
        public MainForm()
        {
            InitializeComponent();
            listfolder = new List<FolderFile>();
            listfilename = new List<string>();
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            if(txtNameFolder.Text != "")
            {
                lstFolder.Items.Add(txtNameFolder.Text);
            }
            else
            {
                MessageBox.Show("Nhập tên thư mục");
                return;
            }
            txtNameFolder.Clear();
        }

        private void lstFolder_DoubleClick(object sender, EventArgs e)
        {
            txtNameFolder.Text = lstFolder.SelectedItem.ToString();
            try
            {
                int index = this.listfolder.FindIndex(x => x.namefolder == txtNameFolder.Text);
                foreach (string name in listfolder[index].filename)
                {
                    AddFileItem(name);
                }
            }
            catch
            {
                return;
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog ChooseFile = new OpenFileDialog();
            ChooseFile.Filter = "PDF|*.pdf";
            if(ChooseFile.ShowDialog()==DialogResult.OK)
            //if (fbdChooseFile.ShowDialog() == DialogResult.OK)
            {
                filename = ChooseFile.FileName;
                AddFileItem(ChooseFile.FileName);
            }
            listfilename.Add(filename);
        }
        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            // Tạo folder
            FolderFile folderFile = new FolderFile();
            folderFile.namefolder = txtNameFolder.Text;
            folderFile.filename = listfilename;
            listfolder.Add(folderFile);
            lstFileName.Items.Clear();
            //listfilename.Clear();

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
    }
}
