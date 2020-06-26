﻿using KindleTeam8.Controllers;
using KindleTeam8.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KindleTeam8.Views
{
    public partial class ChosseFileinDB : Form
    {
        private List<ClassFile> allfile;
        private ClassFile File;
        private ClassFolder Folder;
        private int Result;
        public ChosseFileinDB(ClassFile file, ClassFolder folder, int result)
        {
            InitializeComponent();
            File = new ClassFile();
            File = file;
            Folder = folder;
            Result = result;
            allfile = new List<ClassFile>();
            allfile = FileController.getListFiles();
            displayFile();
        }
        //Hiển thị tất cả các file trên database(Huy)
        private void displayFile()
        {
            allfile = FileController.getListFiles();
            foreach (ClassFile file in allfile)
            {
                ListViewItem item = new ListViewItem(file.namefile);
                List<ClassFolder> lstfolders = FolderController.GetAllFolder();
                string s = "";
                foreach (ClassFolder folder in lstfolders)
                {
                    if (folder.listfile.Where(x => x.ID == file.ID).Count() > 0)
                    {
                        s = s + " " + folder.namefolder;
                    }
                }
                item.SubItems.Add(s);
                if (file.linkedfileout > 0)
                {
                    item.SubItems.Add(FileController.getFile(file.linkedfileout).namefile);
                }
                else
                {
                    item.SubItems.Add("Chưa có tập sau");
                }
                if(file.linkedfilein > 0)
                {
                    item.SubItems.Add(FileController.getFile(file.linkedfilein).namefile);
                }
                else
                {
                    item.SubItems.Add("Chưa có tập trước");
                }
                lstFile.Items.Add(item);
            }
        }
        //Chọn file
        private void lstFile_DoubleClick(object sender, EventArgs e)
        {
            if(Result == 0)
            {
                File = allfile.Where(x => x.namefile == lstFile.SelectedItems[0].SubItems[0].Text).Single();
                Folder.listfile.Add(File);
                FolderController.UpdateFolder(Folder);
            }
            else if(Result == 1)
            {
                ClassFile file = new ClassFile();
                file = allfile.Where(x => x.namefile == lstFile.SelectedItems[0].SubItems[0].Text).Single();
                File.linkedfilein = file.ID;
                file.linkedfileout = File.ID;
                FileController.UpdateFile(File);
                FileController.UpdateFile(file);
            }
            else
            {
                ClassFile file = new ClassFile();
                file = allfile.Where(x => x.namefile == lstFile.SelectedItems[0].SubItems[0].Text).Single();
                File.linkedfileout = file.ID;
                file.linkedfilein = File.ID;
                FileController.UpdateFile(File);
                FileController.UpdateFile(file);
            }
            this.Close();
        }
    }
}
