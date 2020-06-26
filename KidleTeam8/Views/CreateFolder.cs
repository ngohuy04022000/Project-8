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
    public partial class CreateFolder : Form
    {
        private List<ClassFolder> listfolder;
        //private List<string> listfilename;
        ReadPDF ReadPDF;
        ChosseFileinDB ChosseFileinDB;
        public CreateFolder()
        {
            InitializeComponent();
            //BindingSource source = new BindingSource();
            //source.DataSource = FolderController.getListFolder();
            //this.lstFolder.DataSource = source;
            listfolder = new List<ClassFolder>();
            listfolder = FolderController.GetAllFolder();
            displayFolder();
            displayFile(listfolder[0]);
            txtNameFolder.Text = listfolder[0].namefolder;
        }
        //Hiển thị folder lên từ database cho ListBox lstFolder(Hùng)
        private void displayFolder()
        {
            lstFolder.Items.Clear();
            listfolder = FolderController.GetAllFolder();
            foreach (ClassFolder folder in listfolder)
            {
                this.lstFolder.Items.Add(folder.namefolder);
            }
        }
        //Hiển thị file của folder lên listview (Huy)
        private void displayFile(ClassFolder folder)
        {
            lstFileName.Items.Clear();
            foreach (ClassFile file in folder.listfile)
            {
                ListViewItem item = new ListViewItem(file.namefile);
                item.SubItems.Add(file.path);
                item.SubItems.Add(file.size);
                item.SubItems.Add(file.ID.ToString());
                lstFileName.Items.Add(item);
            }
        }
        // Thêm Folder vào database(Huy)
        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            if (txtNameFolder.Text != "" && listfolder.Where(x => x.namefolder == txtNameFolder.Text).Count() < 1)
            {
                ClassFolder folder = new ClassFolder();
                folder.namefolder = txtNameFolder.Text;
                FolderController.AddFolder(folder);
                displayFolder();
            }
            else
            {
                MessageBox.Show("Nhập tên thư mục không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        //Thêm File
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            if (txtNameFolder.Text == "")
            {
                MessageBox.Show("Chưa chọn folder", "Thông Báo");
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
                if (lstFolder.SelectedItem != null)
                {

                    txtNameFolder.Text = lstFolder.SelectedItem.ToString();
                    ClassFolder folder = new ClassFolder();
                    FileInfo iffile = new FileInfo(filename);
                    folder = FolderController.getFolder(txtNameFolder.Text);
                    if (folder.listfile == null || folder.listfile.ToList<ClassFile>().Count(x => x.namefile == iffile.Name) < 1)
                    {
                        AddFileItem(folder, ChooseFile.FileName);
                        folder = FolderController.getFolder(txtNameFolder.Text);
                        displayFile(folder);
                    }
                    else
                    {
                        MessageBox.Show("Đã có File này trong danh sách", "Thông Báo");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn folder", "Thông Báo");
                }
            }
        }
        public void AddFileItem(ClassFolder folder, string filename)
        {
            FileInfo iffile = new FileInfo(filename);
            ClassFile file = new ClassFile();
            file.ID = FileController.getIDfromDB();
            file.namefile = iffile.Name;
            file.path = iffile.DirectoryName;
            file.size = Math.Ceiling(iffile.Length / 1024f).ToString("0 KB");
            if (FileController.getContain(file))
            {
                file = FileController.getFile(file.namefile);
            }
            else
            {
                //file.folder.Add(folder);
                FileController.AddFile(file);
            }
                folder.listfile.Add(file);
                FolderController.UpdateFolder(folder);
 
        }
        //Mở File
        private void lstFileName_DoubleClick(object sender, EventArgs e)
        {
            ClassFile files = new ClassFile();
            files = FileController.getFile(int.Parse(lstFileName.SelectedItems[0].SubItems[3].Text));
            ClassFolder folder = new ClassFolder();
            folder = FolderController.getFolder(txtNameFolder.Text);
            ReadPDF = new ReadPDF(files, folder);
            ReadPDF.Show();
        }
        private void lstFileName_Click(object sender, EventArgs e)
        {
            btnAddFile.Visible = true;
            btnDeleteFile.Visible = true;
        }
        //Xóa folder trên database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lstFolder.SelectedItems.Count <= 0)
            {
                return;
            }
            ClassFolder f = new ClassFolder();

            f = listfolder.Where(x => x.namefolder == txtNameFolder.Text).Single();
            for (int i = 0; i < lstFileName.Items.Count; i++)
            {
                FolderController.DeleteFile(txtNameFolder.Text, int.Parse(lstFileName.Items[i].SubItems[3].Text));
                if (!(FolderController.Containfif(FileController.getFile(int.Parse(lstFileName.Items[i].SubItems[3].Text)))))
                {
                    FileController.DeleteFile(int.Parse(lstFileName.Items[i].SubItems[3].Text));
                }
            }
                FolderController.DeleteFolder(f);
                displayFolder();
        }
        //Chọn danh sách hiển thị trên listview
        private void lstFolder_Click(object sender, EventArgs e)
        {
            if (lstFolder.SelectedItem != null)
            {
                btnAddFile.Visible = true;
                btnAddFileDB.Visible = true;
                txtNameFolder.Text = lstFolder.SelectedItem.ToString();
                ClassFolder folder = new ClassFolder();
                folder.listfile = FolderController.getListFile(txtNameFolder.Text);
                displayFile(folder);
                return;
            }
        }
        //Tìm file trên Folder
        private void txtSearchFile_TextChanged(object sender, EventArgs e)
        {
            ClassFolder folder = new ClassFolder();
            folder = FolderController.getFolder(txtNameFolder.Text);
            List<ClassFile> files = folder.listfile.ToList<ClassFile>().Where(x => x.namefile.Contains(txtSearchFile.Text)).ToList();
            lstFileName.Items.Clear();
            foreach (ClassFile file in files)
            {
                ListViewItem item = new ListViewItem(file.namefile);
                item.SubItems.Add(file.path);
                item.SubItems.Add(file.size);
                item.SubItems.Add(file.ID.ToString());
                lstFileName.Items.Add(item);
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            {
                DialogResult xacnhan = MessageBox.Show("Bạn có muốn xóa File đã chọn không?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (xacnhan == DialogResult.Yes)
                {
                    FolderController.DeleteFile(txtNameFolder.Text, int.Parse(lstFileName.SelectedItems[0].SubItems[3].Text));
                    if (!(FolderController.Containfif(FileController.getFile(int.Parse(lstFileName.SelectedItems[0].SubItems[3].Text)))))
                    {
                        FileController.DeleteFile(int.Parse(lstFileName.SelectedItems[0].SubItems[3].Text));
                    }
                    ClassFolder folder = new ClassFolder();
                    folder = FolderController.getFolder(txtNameFolder.Text);
                    displayFile(folder);
                    btnAddFile.Visible = false;
                    btnDeleteFile.Visible = false;
                }
                else
                {
                    return;
                }
            }
        }
        //Mở cửa sổ thêm file
        private void btnAddFileDB_Click(object sender, EventArgs e)
        {
            if (txtNameFolder.Text == "")
            {
                MessageBox.Show("Chưa chọn folder", "Thông Báo");
                return;
            }
            else
            {
                if (lstFolder.SelectedItem != null)
                {
                    ClassFile file = new ClassFile();
                    txtNameFolder.Text = lstFolder.SelectedItem.ToString();
                    ClassFolder folder = new ClassFolder();
                    folder = FolderController.getFolder(txtNameFolder.Text);
                    ChosseFileinDB = new ChosseFileinDB(file, folder, 0);
                    ChosseFileinDB.Show();
                }
                else
                {
                    MessageBox.Show("Chưa chọn folder", "Thông Báo");
                }
            }
        }
    }
}