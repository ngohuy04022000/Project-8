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
            System.Windows.Forms.ColumnHeader cID;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.lstFolder = new System.Windows.Forms.ListBox();
            this.txtNameFolder = new System.Windows.Forms.TextBox();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.lstFileName = new System.Windows.Forms.ListView();
            this.fbdChooseFile = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cName
            // 
            cName.DisplayIndex = 1;
            cName.Text = "Tên file";
            cName.Width = 233;
            // 
            // cPath
            // 
            cPath.DisplayIndex = 2;
            cPath.Text = "Đường dẫn";
            cPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            cPath.Width = 435;
            // 
            // cSize
            // 
            cSize.DisplayIndex = 3;
            cSize.Text = "Dung lượng";
            cSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            cSize.Width = 124;
            // 
            // cID
            // 
            cID.DisplayIndex = 0;
            cID.Text = "ID";
            cID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddFile);
            this.splitContainer1.Panel1.Controls.Add(this.lstFolder);
            this.splitContainer1.Panel1.Controls.Add(this.txtNameFolder);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddFolder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstFileName);
            this.splitContainer1.Size = new System.Drawing.Size(1010, 515);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(20, 442);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(216, 42);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete List";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddFile.FlatAppearance.BorderSize = 3;
            this.btnAddFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddFile.Location = new System.Drawing.Point(20, 380);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(216, 42);
            this.btnAddFile.TabIndex = 3;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = false;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // lstFolder
            // 
            this.lstFolder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFolder.FormattingEnabled = true;
            this.lstFolder.ItemHeight = 27;
            this.lstFolder.Location = new System.Drawing.Point(20, 138);
            this.lstFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstFolder.Name = "lstFolder";
            this.lstFolder.Size = new System.Drawing.Size(216, 193);
            this.lstFolder.TabIndex = 2;
            this.lstFolder.Click += new System.EventHandler(this.lstFolder_Click);
            // 
            // txtNameFolder
            // 
            this.txtNameFolder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFolder.Location = new System.Drawing.Point(18, 22);
            this.txtNameFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameFolder.Name = "txtNameFolder";
            this.txtNameFolder.Size = new System.Drawing.Size(218, 35);
            this.txtNameFolder.TabIndex = 1;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.BackColor = System.Drawing.Color.White;
            this.btnAddFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolder.Location = new System.Drawing.Point(92, 58);
            this.btnAddFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(72, 31);
            this.btnAddFolder.TabIndex = 0;
            this.btnAddFolder.Text = "Add";
            this.btnAddFolder.UseVisualStyleBackColor = false;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lstFileName
            // 
            this.lstFileName.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstFileName.BackColor = System.Drawing.SystemColors.Info;
            this.lstFileName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            cName,
            cPath,
            cSize,
            cID});
            this.lstFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFileName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFileName.GridLines = true;
            this.lstFileName.HideSelection = false;
            this.lstFileName.Location = new System.Drawing.Point(0, 0);
            this.lstFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstFileName.Name = "lstFileName";
            this.lstFileName.Size = new System.Drawing.Size(738, 515);
            this.lstFileName.TabIndex = 7;
            this.lstFileName.UseCompatibleStateImageBehavior = false;
            this.lstFileName.View = System.Windows.Forms.View.Details;
            this.lstFileName.DoubleClick += new System.EventHandler(this.lstFileName_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách folder";
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
    }
}

