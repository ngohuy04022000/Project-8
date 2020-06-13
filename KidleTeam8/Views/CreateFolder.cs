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
        private List<Folder> listfolder;
        //private List<string> listfilename;
        //private 
        ReadPDF ReadPDF;
        public CreateFolder()
        {
            InitializeComponent();
            listfolder = new List<Folder>();
            //List<string> listfilename = new List<string>();
            string link = "";
            ReadPDF = new ReadPDF(link);
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            if (txtNameFolder.Text != "" && this.listfolder.Where(x=> x.namefolder == txtNameFolder.Text).Count()<1)
            {
                lstFolder.Items.Add(txtNameFolder.Text);
                Folder folder = new Folder();
                folder.namefolder = txtNameFolder.Text;
                folder.filename = new List<Files>();
                listfolder.Add(folder);
            }
            else
            {
                MessageBox.Show("Nhập tên thư mục không hợp lệ","Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            txtNameFolder.Clear();
        }

        private void lstFolder_DoubleClick(object sender, EventArgs e)
        {
            txtNameFolder.Text = lstFolder.SelectedItem.ToString();
            int index = this.listfolder.FindIndex(x => x.namefolder == txtNameFolder.Text);
            if (listfolder[index].filename != null)
            {
                lstFileName.Items.Clear();
                foreach (Files name in listfolder[index].filename)
                {
                    AddFileItem(name.namefile);
                }
            }
            else
            {
                return;
            }
        }
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            if (txtNameFolder.Text == "")
            {
                return;
            }
            else
            {
                string filename = "";
                OpenFileDialog ChooseFile = new OpenFileDialog();
                ChooseFile.Filter = "PDF|*.pdf";
                if (ChooseFile.ShowDialog() == DialogResult.OK)
                //if (fbdChooseFile.ShowDialog() == DialogResult.OK)
                {
                    filename = ChooseFile.FileName;
                    AddFileItem(ChooseFile.FileName);
                }
                int index = this.listfolder.FindIndex(x => x.namefolder == txtNameFolder.Text);
                Files file = new Files();
                file.namefile = filename;
                listfolder[index].filename.Add(file);
            }
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
        private void lstFileName_DoubleClick(object sender, EventArgs e)
        {
            ReadPDF = new ReadPDF(lstFileName.SelectedItems[0].SubItems[1].Text + "/"
                        + lstFileName.SelectedItems[0].SubItems[0].Text);
            ReadPDF.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBTestController.initializeDB();
        }
    }
}