﻿using KindleTeam8;
using KindleTeam8.Models;
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
//ngân cute vl

namespace KindleTeam8.Views
{
    public partial class ReadPDF : Form
    {
        //private string s;
        private Files Files;
        public ReadPDF(Files files)
        {
            InitializeComponent();
            this.Files = files;
            AdobeReadPDF.src = Files.namefile;
        }
        private void DetailsPDF_Click(object sender, EventArgs e)
        {
            FileInfo info = new FileInfo(this.Files.namefile);
            MessageBox.Show("Tên tệp: " + info.Name + Environment.NewLine + "Thời gian tạo: " + info.CreationTime.ToLongTimeString() + Environment.NewLine +
                "Truy cập lần cuối: " + info.LastWriteTime.ToLongDateString() + Environment.NewLine + "Chỉnh sửa lần cuối: " + info.LastAccessTime.ToLongDateString() +
                Environment.NewLine + "Kích thước: " + (Convert.ToInt32(info.Length / 1024f)).ToString() + " KB", "Details", MessageBoxButtons.OK);
        }
        private void ExitPDF_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OpenPDF_Click(object sender, EventArgs e)
        {
            //AdobeReadPDF.src = Files.namefile;
        }
        private void mSaveNote_Click(object sender, EventArgs e)
        {
            Files.note = txtNote.Text;
            txtNote.Enabled = false;
        }
        private void mFixNote_Click(object sender, EventArgs e)
        {
            txtNote.Enabled = true;
        }
        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            mSaveNote.Enabled = true;
        }
        private void mFileLinked_Click(object sender, EventArgs e)
        {
            if(Files.path == null)
            {
                DialogResult xacnhan = MessageBox.Show(
                    "Chưa có File liên Kết, bạn có muốn tạo không?", "Thông Báo",
                    MessageBoxButtons.OKCancel);
                if(xacnhan == DialogResult.OK)
                {
                    OpenFileDialog ChooseFile = new OpenFileDialog();
                    ChooseFile.Filter = "PDF|*.pdf";
                    if (ChooseFile.ShowDialog() == DialogResult.OK)
                    {
                        Files.path = ChooseFile.FileName;
                    }    
                }    
            }
            else
            {
                DialogResult xacnhan = MessageBox.Show(
                      "File liên Kết: "+Files.path+", bạn có muốn mở không?", "Thông Báo",
                      MessageBoxButtons.OKCancel);
                if(xacnhan == DialogResult.OK)
                {
                    AdobeReadPDF.src = Files.path;
                }    
            }    
        }
    }
}