//Nhóm 8
//Nguyễn Quang Hùng - 18133016
//Ngô Trí Huy - 18133015
//Võ Thị Thanh Ngân - 18133033
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

namespace KidleTeam8
{
    public partial class LibraryFile : Form
    {
        private BackgroundWorker backgroundWorker;
        ReadPDF ReadPDF;
        public LibraryFile()
        {
            InitializeComponent();
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;

            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
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
            string[] dirs = Directory.GetDirectories(txtSearch.Text);
            float length = dirs.Length;
            pbrSearch.Invoke((Action)(() => pbrSearch.Maximum = dirs.Length));
            ScanDirectory(txtSearch.Text, txtName.Text);
            for(int i =0; i< dirs.Length;i++)
            {
                backgroundWorker.ReportProgress((int)(i / length * 100));
                ScanDirectory(dirs[i], txtName.Text);
            }
            backgroundWorker.ReportProgress(100);
        }

        public void AddToListView(string file)
        {
            FileInfo fileif = new FileInfo(file);
            lvwSearch.Invoke((Action)(() =>
            {
                string key = Path.GetExtension(file);
                if(key == ".pdf")
                {
                    ListViewItem item = new ListViewItem(fileif.Name, key);
                    item.SubItems.Add(fileif.DirectoryName);
                    item.SubItems.Add(Math.Ceiling(fileif.Length / 1024f).ToString("0 KB"));
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

            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if(backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
            else
            {
                pbrSearch.Value = pbrSearch.Minimum;
                btnFind.Text = "Dừng tìm";
                lvwSearch.Items.Clear();
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (fbdSearchFile.ShowDialog() == DialogResult.OK)
            {
                txtSearch.Text = fbdSearchFile.SelectedPath;
            }
        }
        #endregion

        private void lvwSearch_DoubleClick(object sender, EventArgs e)
        {
            ReadPDF = new ReadPDF(lvwSearch.SelectedItems[0].SubItems[1].Text + "/"
            + lvwSearch.SelectedItems[0].SubItems[0].Text);
            ReadPDF.Show();

        }
    }
}
