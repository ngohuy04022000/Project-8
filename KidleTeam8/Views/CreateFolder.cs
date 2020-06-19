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
        }
        //Hiển thị folder lên từ database cho ListBox lstFolder(Hùng)
        private void displayFolder()
        {
            List<ClassFolder> lstfolders = listfolder;
            foreach (ClassFolder folder in lstfolders)
            {
                this.lstFolder.Items.Add(folder.namefolder);
            }
        }
        private void displayFile(ClassFolder folder)
        {
            lstFileName.Items.Clear();
            foreach (ClassFile file in folder.listfile)
            {
                ListViewItem item = new ListViewItem(file.namefile);
                item.SubItems.Add(file.path);
                item.SubItems.Add(file.size);
                lstFileName.Items.Add(item);
            }
        }
        // Thêm tên Folder
        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            if (txtNameFolder.Text != "" && listfolder.Where(x=> x.namefolder == txtNameFolder.Text).Count()<1)
            {                
                ClassFolder folder = new ClassFolder();
                folder.namefolder = txtNameFolder.Text;
                FolderController.AddFolder(folder);
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
                    folder = listfolder.Where(x => x.namefolder == txtNameFolder.Text).Single();
                    if (folder.listfile != null)
                    {
                        if (folder.listfile.ToList<ClassFile>().Where(x => x.namefile == filename).Count() < 1)
                        {
                            AddFileItem(folder, ChooseFile.FileName);
                            displayFile(folder);

                        }
                        else
                        {
                            MessageBox.Show("Đã có File này trong danh sách", "Thông Báo");
                        }
                    }
                    else
                    {
                        AddFileItem(folder, ChooseFile.FileName);
                        displayFile(folder);
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
            file.namefile = iffile.Name;
            file.path = iffile.DirectoryName;
            file.size = Math.Ceiling(iffile.Length / 1024f).ToString("0 KB");
            FileController.AddFile(file);
            folder.listfile.Add(file);
            FolderController.UpdateFolder(folder);
            //FolderController.AddFolder();
            //Hiển thị lên listview
        }
        //Mở File
        private void lstFileName_DoubleClick(object sender, EventArgs e)
        {
            ClassFile files = new ClassFile();
            files = FileController.getFile(lstFileName.SelectedItems[0].SubItems[0].Text);
            ReadPDF = new ReadPDF(files, listfolder[0]);
            ReadPDF.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lstFolder.SelectedItems.Count <= 0)
            {
                return;
            }
            ClassFolder f = new ClassFolder();
            f = listfolder.Where(x => x.namefolder == txtNameFolder.Text).Single();
            FolderController.DeleteFolder(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // cập nhật lại folder đang chọn vào database

            //!! VẤN ĐỀ: định đổi tên folder mà lại tạo ra folder mới
            ClassFolder f = new ClassFolder();
            f.namefolder = txtNameFolder.Text.Trim();
            FolderController.UpdateFolder(f);
            //lstFolder.Items[lstFolder.SelectedIndex] = txtNameFolder.Text.Trim();
            //hiển thị lại FolderController.getListFolder()
        }

        private void lstFolder_Click(object sender, EventArgs e)
        {
            if (lstFolder.SelectedItem != null)
            {
                txtNameFolder.Text = lstFolder.SelectedItem.ToString();
                ClassFolder folder = new ClassFolder();
                folder.listfile = FolderController.getListFile(txtNameFolder.Text);
                displayFile(folder);
                return;
            }
        }
    }
}