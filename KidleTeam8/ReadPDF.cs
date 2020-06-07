using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ngân cute

namespace KidleTeam8
{
    public partial class ReadPDF : Form
    {
        public ReadPDF(string Link)
        {
            InitializeComponent();
            AdobeReadPDF.src = Link;
        }

        private void OpenPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog FilePDF = new OpenFileDialog();
            FilePDF.Filter = "PDF|*.pdf";
            if(FilePDF.ShowDialog()==DialogResult.OK)
            {
                AdobeReadPDF.src = FilePDF.FileName;
            }
            AdobeReadPDF.Visible = true;
        }
    }
}
