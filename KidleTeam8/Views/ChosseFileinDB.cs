using KindleTeam8.Controllers;
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
        public ChosseFileinDB(ClassFile file, ClassFolder folder)
        {
            InitializeComponent();
            File = new ClassFile();
            File = file;
            Folder = folder;
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
                //item.SubItems.Add(file.path);
                lstFile.Items.Add(item);
            }
        }
        //Chọn file
        private void lstFile_DoubleClick(object sender, EventArgs e)
        {
            File = allfile.Where(x => x.namefile == lstFile.SelectedItems[0].SubItems[0].Text).Single();
            Folder.listfile.Add(File);
            FolderController.UpdateFolder(Folder);
            this.Close();
        }
    }
}
