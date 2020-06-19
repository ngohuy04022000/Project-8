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
        //private List<string> listfilename;
        ReadPDF ReadPDF;
        public CreateFolder()
        {
            InitializeComponent();
            displayFolder();
            BindingSource source = new BindingSource();
            source.DataSource = FolderController.getListFolder();
            this.lstFolder.DataSource = source;   
        }
        //Hiển thị folder lên từ database cho ListBox lstFolder(Hùng)
        private void displayFolder()
        {
            List<ClassFolder> lstfolders = FolderController.getListFolder();
            foreach (ClassFolder folder in lstfolders)
            {
                this.lstFolder.Items.Add(folder);
            }
        }
        private void displayFile(ClassFolder folder)
        {
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
            if (txtNameFolder.Text != "" && FolderController.getListFolder().Where(x=> x.namefolder == txtNameFolder.Text).Count()<1)
            {                
                ClassFolder folder = new ClassFolder();
                folder.namefolder = txtNameFolder.Text;
                FolderController.AddFolder(folder);
                BindingSource source = new BindingSource();
                source.DataSource = FolderController.getListFolder();
                this.lstFolder.DataSource = source;
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
                    ClassFolder folder = FolderController.getFolder(txtNameFolder.Text);
                    if (folder.listfile != null)
                    {
                        if (folder.listfile.ToList<ClassFile>().Where(x => x.namefile == filename).Count() < 1)
                        {
                            AddFileItem(folder, ChooseFile.FileName);
                        }
                        else
                        {
                            MessageBox.Show("Đã có File này trong danh sách", "Thông Báo");
                        }
                    }
                    else
                    {
                        AddFileItem(folder, ChooseFile.FileName);
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
            FolderController.AddFile(folder, file);
            //FolderController.AddFolder();
            //Hiển thị lên listview
        }
        //Mở File
        private void lstFileName_DoubleClick(object sender, EventArgs e)
        {
            int indexfolder = FolderController.getListFolder().FindIndex(x => x.namefolder == txtNameFolder.Text);
            List<ClassFile> files = new List<ClassFile>();
            files = FolderController.getListFolder()[indexfolder].listfile.ToList<ClassFile>();
            int index = files.FindIndex(x => x.namefile == lstFileName.SelectedItems[0].SubItems[1].Text + "\\"
            + lstFileName.SelectedItems[0].SubItems[0].Text);
            ReadPDF = new ReadPDF(files[index], FolderController.getListFolder()[indexfolder]);
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
            //hiển thị lại FolderController.getListFolder()
            BindingSource source = new BindingSource();
            source.DataSource = FolderController.getListFolder();
            this.lstFolder.DataSource = source;
        }

        private void lstFolder_Click(object sender, EventArgs e)
        {
            if (lstFolder.SelectedItem != null)
            {
                txtNameFolder.Text = lstFolder.SelectedItem.ToString();
                ClassFolder folder = FolderController.getFolder(txtNameFolder.Text);
                if (folder.listfile != null)
                {
                    lstFileName.Items.Clear();
                    foreach (ClassFile name in folder.listfile)
                    {
                        AddFileItem(folder, name.namefile);
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