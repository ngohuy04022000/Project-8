namespace KidleTeam8
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
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.lstFolder = new System.Windows.Forms.ListBox();
            this.txtNameFolder = new System.Windows.Forms.TextBox();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.lstFileName = new System.Windows.Forms.ListView();
            this.fbdChooseFile = new System.Windows.Forms.FolderBrowserDialog();
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
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCreateFolder);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddFile);
            this.splitContainer1.Panel1.Controls.Add(this.lstFolder);
            this.splitContainer1.Panel1.Controls.Add(this.txtNameFolder);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddFolder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstFileName);
            this.splitContainer1.Size = new System.Drawing.Size(673, 335);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Enabled = false;
            this.btnCreateFolder.Location = new System.Drawing.Point(13, 196);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(75, 23);
            this.btnCreateFolder.TabIndex = 4;
            this.btnCreateFolder.Text = "Tạo Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            //this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(13, 166);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddFile.TabIndex = 3;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // lstFolder
            // 
            this.lstFolder.FormattingEnabled = true;
            this.lstFolder.Location = new System.Drawing.Point(12, 55);
            this.lstFolder.Name = "lstFolder";
            this.lstFolder.Size = new System.Drawing.Size(120, 95);
            this.lstFolder.TabIndex = 2;
            this.lstFolder.DoubleClick += new System.EventHandler(this.lstFolder_DoubleClick);
            // 
            // txtNameFolder
            // 
            this.txtNameFolder.Location = new System.Drawing.Point(12, 14);
            this.txtNameFolder.Name = "txtNameFolder";
            this.txtNameFolder.Size = new System.Drawing.Size(89, 20);
            this.txtNameFolder.TabIndex = 1;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(98, 14);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(48, 20);
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
            this.lstFileName.Name = "lstFileName";
            this.lstFileName.Size = new System.Drawing.Size(519, 335);
            this.lstFileName.TabIndex = 7;
            this.lstFileName.UseCompatibleStateImageBehavior = false;
            this.lstFileName.View = System.Windows.Forms.View.Details;
            this.lstFileName.DoubleClick += new System.EventHandler(this.lstFileName_DoubleClick);
            // 
            // CreateFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 335);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CreateFolder";
            this.Text = "Màn Hình Chính";
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
        private System.Windows.Forms.Button btnCreateFolder;
    }
}

