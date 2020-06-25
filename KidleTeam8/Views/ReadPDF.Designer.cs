namespace KindleTeam8.Views
{
    partial class ReadPDF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadPDF));
            this.txtNote = new System.Windows.Forms.TextBox();
            this.AdobeReadPDF = new AxAcroPDFLib.AxAcroPDF();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OpenPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileLinked = new System.Windows.Forms.ToolStripMenuItem();
            this.mNote = new System.Windows.Forms.ToolStripMenuItem();
            this.mSaveNote = new System.Windows.Forms.ToolStripMenuItem();
            this.mFixNote = new System.Windows.Forms.ToolStripMenuItem();
            this.DetailsPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsReadPDF = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.AdobeReadPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.mnsReadPDF.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Enabled = false;
            this.txtNote.Location = new System.Drawing.Point(0, 0);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(464, 25);
            this.txtNote.TabIndex = 2;
            this.txtNote.Text = "Note: ";
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // AdobeReadPDF
            // 
            this.AdobeReadPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdobeReadPDF.Enabled = true;
            this.AdobeReadPDF.Location = new System.Drawing.Point(0, 0);
            this.AdobeReadPDF.Name = "AdobeReadPDF";
            this.AdobeReadPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AdobeReadPDF.OcxState")));
            this.AdobeReadPDF.Size = new System.Drawing.Size(464, 213);
            this.AdobeReadPDF.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtNote);
            this.splitContainer1.Panel1.Enabled = this.Enabled;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AdobeReadPDF);
            this.splitContainer1.Size = new System.Drawing.Size(464, 241);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 3;
            // 
            // OpenPDF
            // 
            this.OpenPDF.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileLinked,
            this.mNote});
            this.OpenPDF.Name = "OpenPDF";
            this.OpenPDF.Size = new System.Drawing.Size(48, 22);
            this.OpenPDF.Text = "View";
            // 
            // mFileLinked
            // 
            this.mFileLinked.Name = "mFileLinked";
            this.mFileLinked.Size = new System.Drawing.Size(138, 22);
            this.mFileLinked.Text = "File Linked";
            this.mFileLinked.Click += new System.EventHandler(this.mFileLinked_Click);
            // 
            // mNote
            // 
            this.mNote.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSaveNote,
            this.mFixNote});
            this.mNote.Name = "mNote";
            this.mNote.Size = new System.Drawing.Size(138, 22);
            this.mNote.Text = "Note";
            // 
            // mSaveNote
            // 
            this.mSaveNote.Enabled = false;
            this.mSaveNote.Name = "mSaveNote";
            this.mSaveNote.Size = new System.Drawing.Size(184, 22);
            this.mSaveNote.Text = "Lưu Note";
            this.mSaveNote.Click += new System.EventHandler(this.mSaveNote_Click);
            // 
            // mFixNote
            // 
            this.mFixNote.Name = "mFixNote";
            this.mFixNote.Size = new System.Drawing.Size(184, 22);
            this.mFixNote.Text = "Tạo hoặc sửa Note";
            this.mFixNote.Click += new System.EventHandler(this.mFixNote_Click);
            // 
            // DetailsPDF
            // 
            this.DetailsPDF.Name = "DetailsPDF";
            this.DetailsPDF.Size = new System.Drawing.Size(58, 22);
            this.DetailsPDF.Text = "Details";
            this.DetailsPDF.Click += new System.EventHandler(this.DetailsPDF_Click);
            // 
            // ExitPDF
            // 
            this.ExitPDF.Name = "ExitPDF";
            this.ExitPDF.Size = new System.Drawing.Size(42, 22);
            this.ExitPDF.Text = "Exit";
            this.ExitPDF.Click += new System.EventHandler(this.ExitPDF_Click);
            // 
            // mnsReadPDF
            // 
            this.mnsReadPDF.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsReadPDF.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnsReadPDF.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenPDF,
            this.DetailsPDF,
            this.ExitPDF});
            this.mnsReadPDF.Location = new System.Drawing.Point(0, 0);
            this.mnsReadPDF.Name = "mnsReadPDF";
            this.mnsReadPDF.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mnsReadPDF.Size = new System.Drawing.Size(464, 24);
            this.mnsReadPDF.TabIndex = 1;
            this.mnsReadPDF.Text = "mnsReadPDF";
            // 
            // ReadPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(464, 265);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mnsReadPDF);
            this.MainMenuStrip = this.mnsReadPDF;
            this.Name = "ReadPDF";
            this.Load += new System.EventHandler(this.ReadPDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdobeReadPDF)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.mnsReadPDF.ResumeLayout(false);
            this.mnsReadPDF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF AdobeReadPDF;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem OpenPDF;
        private System.Windows.Forms.ToolStripMenuItem mFileLinked;
        private System.Windows.Forms.ToolStripMenuItem mNote;
        private System.Windows.Forms.ToolStripMenuItem mSaveNote;
        private System.Windows.Forms.ToolStripMenuItem mFixNote;
        private System.Windows.Forms.ToolStripMenuItem DetailsPDF;
        private System.Windows.Forms.ToolStripMenuItem ExitPDF;
        private System.Windows.Forms.MenuStrip mnsReadPDF;
    }
}