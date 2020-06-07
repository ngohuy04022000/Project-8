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
//ngân cute

namespace KidleTeam8
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
    }
}
