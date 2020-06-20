﻿//Nhóm 8
//Nguyễn Quang Hùng - 18133016
//Ngô Trí Huy - 18133015
//Võ Thị Thanh Ngân - 18133033
using KindleTeam8;
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
using KindleTeam8.Models;
using KindleTeam8.Controllers;

namespace KindleTeam8.Views
{
    public partial class LibraryFile : Form
    {
        private BackgroundWorker backgroundWorker;
        private ReadPDF ReadPDF;
        private ClassFolder folders;
        public LibraryFile()
        {
            InitializeComponent();
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;

            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            //ClassFile files = new ClassFile();
            folders = new ClassFolder();
            folders.namefolder = "Library";
            folders.listfile = new List<ClassFile>();
            folders.listfile = FolderController.getListFile("Library");
            //folders = folder;
            //ReadPDF = new ReadPDF(files, folders);
            //foreach (Folder f in folders)
            //{
            //    cmbFolderName.Items.Add(f.namefolder);
            //}
            //if (cmbFolderName.Items != null)
            //{
            //    cmbFolderName.Text = cmbFolderName.Items[0].ToString();
            //}
            //else
            //{
            //    cmbFolderName.Text = "Library";
            //    cmbFolderName.Items.Add("Library");
            //}    
        }
        #region Xử lý phần tìm file với đuôi .pdf
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = string.Format("Tìm thấy {0} tập tin", lvwSearch.Items.Count);
            if (pbrSearch.Value < pbrSearch.Maximum)
            {
                lblStatus.Text = "Dừng tìm kiếm";
            }
            btnFind.Text = "Tìm kiếm";
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(!backgroundWorker.CancellationPending)
            {
                lblPercent.Text = e.ProgressPercentage + " %";
                pbrSearch.PerformStep();
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(txtSearch.Text);
                float length = dirs.Length;
                pbrSearch.Invoke((Action)(() => pbrSearch.Maximum = dirs.Length));
                ScanDirectory(txtSearch.Text, txtName.Text);
                for (int i = 0; i < dirs.Length; i++)
                {
                    backgroundWorker.ReportProgress((int)(i / length * 100));
                    ScanDirectory(dirs[i], txtName.Text);
                }
                backgroundWorker.ReportProgress(100);
            }
            catch
            {
                return;
            }
        }
        public void AddToListView(string file)
        {
            ClassFile filename = new ClassFile();
            filename.namefile = file;
            //int index = folders.FindIndex(x => x.namefolder == cmbFolderName.Text);
            //folders.listfile.Add(filename);
            FileInfo fileif = new FileInfo(file);
            lvwSearch.Invoke((Action)(() =>
            {
                string key = Path.GetExtension(file);
                if(key == ".pdf")
                {
                    filename.ID = FileController.getIDfromDB();
                    filename.namefile = fileif.Name;
                    filename.path = fileif.DirectoryName;
                    filename.size = Math.Ceiling(fileif.Length / 1024f).ToString("0 KB");
                    FileController.AddFile(filename);
                    ListViewItem item = new ListViewItem(fileif.Name, key);
                    item.SubItems.Add(fileif.DirectoryName);
                    item.SubItems.Add(Math.Ceiling(fileif.Length / 1024f).ToString("0 KB"));
                    item.SubItems.Add(filename.ID.ToString());
                    folders.listfile.Add(filename);
                    FolderController.UpdateFolder(folders);
                    lvwSearch.BeginUpdate();
                    lvwSearch.Items.Add(item);
                    lvwSearch.EndUpdate();
                }               
            }));
        }

        public void ScanDirectory(string directory, string searchpatten)
        {
            try
            {
                foreach(var file in Directory.GetFiles(directory))
                {
                    if(backgroundWorker.CancellationPending)
                    {
                        return;
                    }
                    lblStatus.Invoke((Action)(() =>lblStatus.Text = file));
                    if(file.Contains(searchpatten))
                    {
                        AddToListView(file);
                    }
                }
                foreach(var dir in Directory.GetDirectories(directory))
                {
                    ScanDirectory(dir, searchpatten);
                }
            }
            catch
            {
                return;
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            //if(folders.Where(x=>x.namefolder == cmbFolderName.Text).Count()<1)
            //{
            //    Folder f = new Folder();
            //    f.namefolder = cmbFolderName.Text;
            //    f.filename = new List<Files>();
            //    folders.Add(f);
            //}    
            if(backgroundWorker.IsBusy || txtSearch.Text == null)
            {
                backgroundWorker.CancelAsync();
            }
            else
            {
                if (fbdSearchFile.ShowDialog() == DialogResult.OK)
                {
                    txtSearch.Text = fbdSearchFile.SelectedPath;
                }
                pbrSearch.Value = pbrSearch.Minimum;
                btnFind.Text = "Dừng tìm";
                lvwSearch.Items.Clear();
                backgroundWorker.RunWorkerAsync();
            }
        }
        #endregion

        private void lvwSearch_DoubleClick(object sender, EventArgs e)
        {
            ClassFile files = new ClassFile();
            files = FileController.getFile(int.Parse(lvwSearch.SelectedItems[0].SubItems[3].Text));
            ReadPDF = new ReadPDF(files, folders);
            ReadPDF.Show();
        }
    }
}