namespace KidleTeam8
{
    partial class LibraryFile
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
            System.Windows.Forms.ColumnHeader cName;
            System.Windows.Forms.ColumnHeader cPath;
            System.Windows.Forms.ColumnHeader cSize;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryFile));
            this.btnFind = new System.Windows.Forms.Button();
            this.fbdSearchFile = new System.Windows.Forms.FolderBrowserDialog();
            this.bgwFound = new System.ComponentModel.BackgroundWorker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lvwSearch = new System.Windows.Forms.ListView();
            this.pbrSearch = new System.Windows.Forms.ProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.adbPDF = new AxAcroPDFLib.AxAcroPDF();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClosePDF = new System.Windows.Forms.ToolStripMenuItem();
            cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.adbPDF)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cName
            // 
            cName.Text = "Tên file";
            cName.Width = 237;
            // 
            // cPath
            // 
            cPath.Text = "Đường dẫn";
            cPath.Width = 435;
            // 
            // cSize
            // 
            cSize.Text = "Dung lượng";
            cSize.Width = 124;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(392, 38);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(111, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(237, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(30, 42);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Đường dẫn";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Tên file";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 20);
            this.txtName.TabIndex = 5;
            // 
            // lvwSearch
            // 
            this.lvwSearch.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvwSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            cName,
            cPath,
            cSize});
            this.lvwSearch.GridLines = true;
            this.lvwSearch.HideSelection = false;
            this.lvwSearch.Location = new System.Drawing.Point(-2, 186);
            this.lvwSearch.Name = "lvwSearch";
            this.lvwSearch.Size = new System.Drawing.Size(801, 262);
            this.lvwSearch.TabIndex = 6;
            this.lvwSearch.UseCompatibleStateImageBehavior = false;
            this.lvwSearch.View = System.Windows.Forms.View.Details;
            this.lvwSearch.DoubleClick += new System.EventHandler(this.lvwSearch_DoubleClick);
            // 
            // pbrSearch
            // 
            this.pbrSearch.Location = new System.Drawing.Point(33, 133);
            this.pbrSearch.Name = "pbrSearch";
            this.pbrSearch.Size = new System.Drawing.Size(334, 23);
            this.pbrSearch.TabIndex = 7;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(373, 134);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(36, 20);
            this.lblPercent.TabIndex = 8;
            this.lblPercent.Text = "0 %";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(29, 163);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 20);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Trạng thái";
            // 
            // adbPDF
            // 
            this.adbPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adbPDF.Enabled = true;
            this.adbPDF.Location = new System.Drawing.Point(0, 24);
            this.adbPDF.Name = "adbPDF";
            this.adbPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("adbPDF.OcxState")));
            this.adbPDF.Size = new System.Drawing.Size(800, 426);
            this.adbPDF.TabIndex = 10;
            this.adbPDF.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClosePDF});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ClosePDF
            // 
            this.ClosePDF.Name = "ClosePDF";
            this.ClosePDF.Size = new System.Drawing.Size(180, 22);
            this.ClosePDF.Text = "Close PDF";
            this.ClosePDF.Click += new System.EventHandler(this.ClosePDF_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.pbrSearch);
            this.Controls.Add(this.lvwSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.adbPDF);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Đọc file PDF";
            ((System.ComponentModel.ISupportInitialize)(this.adbPDF)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.FolderBrowserDialog fbdSearchFile;
        private System.ComponentModel.BackgroundWorker bgwFound;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListView lvwSearch;
        private System.Windows.Forms.ProgressBar pbrSearch;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblStatus;
        private AxAcroPDFLib.AxAcroPDF adbPDF;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClosePDF;
    }
}

