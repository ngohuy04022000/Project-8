using KindleTeam8;
using KindleTeam8.Controllers;
using KindleTeam8.Models;
using System;
using System.CodeDom.Compiler;
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
        private ClassFile Files;
        private ClassFolder folder;
        private ChosseFileinDB FileinDB;
        public ReadPDF(ClassFile files, ClassFolder folders)
        {
            InitializeComponent();
            folder = new ClassFolder();
            folder = folders;
            this.Files = files;
            Display();
        }
        //Hiển thị 
        private void Display()
        {
            AdobeReadPDF.src = Files.path + "\\" + Files.namefile;
            this.Text = this.Files.namefile;
            if (Files.note != null)
            {
                txtNote.Text = "Note:" + Files.note;
            }
        }
        //Hiển thị thông tin cơ bản
        private void DetailsPDF_Click(object sender, EventArgs e)
        {
            FileInfo info = new FileInfo(this.Files.path + "\\" + Files.namefile);
            MessageBox.Show("Tên tệp: " + info.Name + Environment.NewLine + "Thời gian tạo: " + info.CreationTime.ToLongTimeString() + Environment.NewLine +
                "Truy cập lần cuối: " + info.LastWriteTime.ToLongDateString() + Environment.NewLine + "Chỉnh sửa lần cuối: " + info.LastAccessTime.ToLongDateString() +
                Environment.NewLine + "Kích thước: " + (Convert.ToInt32(info.Length / 1024f)).ToString() + " KB", "Details", MessageBoxButtons.OK);
        }
        //Đóng form ReadPDF
        private void ExitPDF_Click(object sender, EventArgs e)
        {
            //FileController.UpdateFile(Files);
            this.Close();
        }
        //Cập nhật ghi chú vào database 
        private void mSaveNote_Click(object sender, EventArgs e)
        {
            Files.note = txtNote.Text;
            txtNote.Text = "Note:" + Files.note;
            FileController.UpdateFile(Files);
            txtNote.Enabled = false;
        }
        //Cho phép gõ và thay đổi ghi chú
        private void mFixNote_Click(object sender, EventArgs e)
        {
            txtNote.Enabled = true;
            txtNote.Focus();
        }
        //Khi ghi chú thay đổi, cho phép nhấn lưu note
        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            mSaveNote.Enabled = true;
        }
        //Đưa ra lựa chọn mở file pdf
        private void ReadPDF_Load(object sender, EventArgs e)
        {
            DialogResult xacnhan = MessageBox.Show("Bạn có muốn mở file được chọn không",
                "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(xacnhan == DialogResult.Yes)
            {
                AdobeReadPDF.src = Files.path + "\\" + Files.namefile;
            }
            else
            {
                this.Close(); 
            }    
        }
        //Thêm liên kết file cho file mở hiện tại. (Hiển thị tiếp theo file hiện tại)
        private void mAfter_Click(object sender, EventArgs e)
        {
            if (Files.linkedfileout < 1)
            {
                DialogResult xacnhan = MessageBox.Show("Bạn chưa có tập tiếp theo! Chọn tập tiếp theo?",
                    "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xacnhan == DialogResult.Yes)
                {
                    FileinDB = new ChosseFileinDB(Files, folder, 2);
                    FileinDB.Show();
                }
            }
            else
            {
                DialogResult nhan = MessageBox.Show("Bạn có muốn thay đổi tập tiếp theo?",
                            "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (nhan == DialogResult.No)
                {
                    ClassFile file = new ClassFile();
                    file = FileController.getFile(Files.linkedfileout);
                    Files = file;
                    Display();
                }
                else
                {
                    FileinDB = new ChosseFileinDB(Files, folder, 2);
                    FileinDB.Show();
                }    
            }    
        }
        //thêm liên kết file cho file mở hiện tại. (Hiển thị trước file hiện tại)
        private void mBefore_Click(object sender, EventArgs e)
        {
            if (Files.linkedfilein < 1)
            {
                DialogResult xacnhan = MessageBox.Show("Bạn chưa có tập trước! Chọn tập trước?",
                            "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xacnhan == DialogResult.Yes)
                {
                    FileinDB = new ChosseFileinDB(Files, folder, 1);
                    FileinDB.Show();
                }
            }
            else
            {
                DialogResult nhan = MessageBox.Show("Bạn có muốn thay đổi tập trước?",
                            "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (nhan == DialogResult.No)
                {
                    ClassFile file = new ClassFile();
                file = FileController.getFile(Files.linkedfilein);
                Files = file;
                Display();
                }
                else
                {
                    FileinDB = new ChosseFileinDB(Files, folder, 2);
                    FileinDB.Show();
                }
            }
        }
    }
}