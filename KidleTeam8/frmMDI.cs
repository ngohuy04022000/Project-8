﻿using KidleTeam8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KindleTeam8
{
    public partial class frmMDI : Form
    {
        LibraryFile libraryFile;
        public frmMDI()
        {
            InitializeComponent();
        }

 
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
    }
}