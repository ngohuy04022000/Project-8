﻿using KindleTeam8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KindleTeam8.Models;
using KindleTeam8.Controllers;

namespace KindleTeam8.Views
{
    public partial class frmMDI : Form
    {
        private LibraryFile libraryFile;
        private CreateFolder createFolder;
        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
            {
                return;
            }
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            if (this.ActiveMdiChild.Tag ==null)
            {
                TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                tp.Tag = this.ActiveMdiChild;
                tp.Parent = this.tabMain;
                this.tabMain.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab!=null && tabMain.SelectedTab.Tag != null)
            {
                (this.tabMain.SelectedTab.Tag as Form).Select();
            }
        }
        //Lập trình cho phần ToolStripMenu
        private void mFind_Click(object sender, EventArgs e)
        {
            if (this.libraryFile is null || libraryFile.IsDisposed)
            {
                libraryFile = new LibraryFile();
                libraryFile.MdiParent = this;
                libraryFile.Show();
            }
            else
            {
                libraryFile.Select();
            }
        }

        private void mCreateFolder_Click(object sender, EventArgs e)
        {
            if (this.createFolder is null || createFolder.IsDisposed)
            {
                createFolder = new CreateFolder();
                createFolder.MdiParent = this;
                createFolder.Show();
            }
            else
            {
                createFolder.Select();
            }
        }
        //Hiện hướng dẫn sử dụng
        private void mViews_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "3 chức năng" + Environment.NewLine
                + "Tìm kiếm trong máy" + Environment.NewLine
                + "Tạo các folder để phân nhóm PDF:" + Environment.NewLine
                        + "- Thêm folder" + Environment.NewLine
                        + "- Xóa Folder" + Environment.NewLine
                        + "- Thêm File cho Folder" + Environment.NewLine
                + "Đọc File PDF");
        }
        //Tạo database
        private void mCreateDB_Click(object sender, EventArgs e)
        {
            try
            {
                DBTestController.initializeDB();
            }
            catch
            {
                return;
            }
        }
    }
}
