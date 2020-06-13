using KindleTeam8;
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
        private string s;

        public ReadPDF(string Link)
        {
            InitializeComponent();
            AdobeReadPDF.src = Link;
            s = Link;
        }

        private void OpenPDF_Click(object sender, EventArgs e)
        {
            //OpenFileDialog FilePDF = new OpenFileDialog();
            //FilePDF.Filter = "PDF|*.pdf";
            //if(FilePDF.ShowDialog()==DialogResult.OK)
            //{
            //    AdobeReadPDF.src = FilePDF.FileName;
            //}
            AdobeReadPDF.Visible = true;
            string path = s;
            FileInfo ThongTinTruyXuat = new FileInfo(path); // FileInfo thuộc thư viện System.IO
            if (!ThongTinTruyXuat.Exists)
            {
                throw new FileNotFoundException("Không tìm thấy tập tin cần thiết: " + path);
            }
        }

        private void DetailsPDF_Click(object sender, EventArgs e)
        {
            FileInfo info = new FileInfo(s);
            MessageBox.Show("Tên tệp: " + info.Name + Environment.NewLine + "Thời gian tạo: " + info.CreationTime.ToLongTimeString() + Environment.NewLine +
                "Truy cập lần cuối: " + info.LastWriteTime.ToLongDateString() + Environment.NewLine + "Chỉnh sửa lần cuối: " + info.LastAccessTime.ToLongDateString() +
                Environment.NewLine + "Kích thước: " + (Convert.ToInt32(info.Length / 1024f)).ToString() + " KB", "Details", MessageBoxButtons.OK);
        }

        private void ExitPDF_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
