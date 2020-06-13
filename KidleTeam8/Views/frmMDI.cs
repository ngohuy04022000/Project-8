using KindleTeam8;
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

namespace KindleTeam8.Views
{
    public partial class frmMDI : Form
    {
        LibraryFile libraryFile;
        CreateFolder createFolder;
        Folder Library;
        public frmMDI()
        {
            InitializeComponent();
            Library = new Folder();
            Library.namefolder = "LibraryFile";
            Library.filename = new List<Files>();
        }
        private void mFind_Click(object sender, EventArgs e)
        {
            if (this.libraryFile is null || libraryFile.IsDisposed)
            {
                libraryFile = new LibraryFile(Library);
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

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab!=null && tabMain.SelectedTab.Tag != null)
            {
                (this.tabMain.SelectedTab.Tag as Form).Select();
            }
        }
    }
}
