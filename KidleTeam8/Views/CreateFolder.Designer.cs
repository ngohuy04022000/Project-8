namespace KindleTeam8.Views
{
    partial class CreateFolder
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.lstFolder = new System.Windows.Forms.ListBox();
            this.txtNameFolder = new System.Windows.Forms.TextBox();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.lstFileName = new System.Windows.Forms.ListView();
            this.fbdChooseFile = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cName
            // 
            cName.Text = "Tên file";
            cName.Width = 233;
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddFile);
            this.splitContainer1.Panel1.Controls.Add(this.lstFolder);
            this.splitContainer1.Panel1.Controls.Add(this.txtNameFolder);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddFolder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstFileName);
            this.splitContainer1.Size = new System.Drawing.Size(1010, 515);
            this.splitContainer1.SplitterDistance = 223;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(20, 302);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete List";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(20, 255);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(112, 35);
            this.btnAddFile.TabIndex = 3;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // lstFolder
            // 
            this.lstFolder.FormattingEnabled = true;
            this.lstFolder.ItemHeight = 20;
            this.lstFolder.Location = new System.Drawing.Point(18, 85);
            this.lstFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstFolder.Name = "lstFolder";
            this.lstFolder.Size = new System.Drawing.Size(178, 144);
            this.lstFolder.TabIndex = 2;
            this.lstFolder.Click += new System.EventHandler(this.lstFolder_Click);
            // 
            // txtNameFolder
            // 
            this.txtNameFolder.Location = new System.Drawing.Point(18, 22);
            this.txtNameFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameFolder.Name = "txtNameFolder";
            this.txtNameFolder.Size = new System.Drawing.Size(132, 26);
            this.txtNameFolder.TabIndex = 1;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(147, 22);
            this.btnAddFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(72, 31);
            this.btnAddFolder.TabIndex = 0;
            this.btnAddFolder.Text = "Add";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lstFileName
            // 
            this.lstFileName.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstFileName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            cName,
            cPath,
            cSize});
            this.lstFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFileName.GridLines = true;
            this.lstFileName.HideSelection = false;
            this.lstFileName.Location = new System.Drawing.Point(0, 0);
            this.lstFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstFileName.Name = "lstFileName";
            this.lstFileName.Size = new System.Drawing.Size(781, 515);
            this.lstFileName.TabIndex = 7;
            this.lstFileName.UseCompatibleStateImageBehavior = false;
            this.lstFileName.View = System.Windows.Forms.View.Details;
            this.lstFileName.DoubleClick += new System.EventHandler(this.lstFileName_DoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "rename";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 515);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateFolder";
            this.Text = "Tạo danh sách";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtNameFolder;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.ListBox lstFolder;
        private System.Windows.Forms.ListView lstFileName;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.FolderBrowserDialog fbdChooseFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button2;
    }
}

