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
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.txtSearchFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.lstFolder = new System.Windows.Forms.ListBox();
            this.txtNameFolder = new System.Windows.Forms.TextBox();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.lstFileName = new System.Windows.Forms.ListView();
            this.fbdChooseFile = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAddFileDB = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
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
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel1.Controls.Add(this.lbSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddFileDB);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteFile);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearchFile);
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
            this.splitContainer1.Size = new System.Drawing.Size(673, 412);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeleteFile.FlatAppearance.BorderSize = 3;
            this.btnDeleteFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeleteFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteFile.Location = new System.Drawing.Point(12, 340);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(143, 27);
            this.btnDeleteFile.TabIndex = 8;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.UseVisualStyleBackColor = false;
            this.btnDeleteFile.Visible = false;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // txtSearchFile
            // 
            this.txtSearchFile.Location = new System.Drawing.Point(12, 235);
            this.txtSearchFile.Name = "txtSearchFile";
            this.txtSearchFile.Size = new System.Drawing.Size(143, 20);
            this.txtSearchFile.TabIndex = 7;
            this.txtSearchFile.TextChanged += new System.EventHandler(this.txtSearchFile_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách folder";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(12, 373);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 27);
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
            this.btnAddFile.Location = new System.Drawing.Point(12, 274);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(143, 27);
            this.btnAddFile.TabIndex = 3;
            this.btnAddFile.Text = "Add File From This PC";
            this.btnAddFile.UseVisualStyleBackColor = false;
            this.btnAddFile.Visible = false;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // lstFolder
            // 
            this.lstFolder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFolder.FormattingEnabled = true;
            this.lstFolder.ItemHeight = 19;
            this.lstFolder.Location = new System.Drawing.Point(12, 90);
            this.lstFolder.Name = "lstFolder";
            this.lstFolder.Size = new System.Drawing.Size(143, 118);
            this.lstFolder.TabIndex = 2;
            this.lstFolder.Click += new System.EventHandler(this.lstFolder_Click);
            // 
            // txtNameFolder
            // 
            this.txtNameFolder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFolder.Location = new System.Drawing.Point(12, 14);
            this.txtNameFolder.Name = "txtNameFolder";
            this.txtNameFolder.Size = new System.Drawing.Size(143, 26);
            this.txtNameFolder.TabIndex = 1;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.BackColor = System.Drawing.Color.White;
            this.btnAddFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolder.Location = new System.Drawing.Point(61, 38);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(48, 20);
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
            this.lstFileName.Name = "lstFileName";
            this.lstFileName.Size = new System.Drawing.Size(492, 412);
            this.lstFileName.TabIndex = 7;
            this.lstFileName.UseCompatibleStateImageBehavior = false;
            this.lstFileName.View = System.Windows.Forms.View.Details;
            this.lstFileName.Click += new System.EventHandler(this.lstFileName_Click);
            this.lstFileName.DoubleClick += new System.EventHandler(this.lstFileName_DoubleClick);
            // 
            // btnAddFileDB
            // 
            this.btnAddFileDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddFileDB.FlatAppearance.BorderSize = 3;
            this.btnAddFileDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddFileDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddFileDB.Location = new System.Drawing.Point(12, 307);
            this.btnAddFileDB.Name = "btnAddFileDB";
            this.btnAddFileDB.Size = new System.Drawing.Size(143, 27);
            this.btnAddFileDB.TabIndex = 8;
            this.btnAddFileDB.Text = "Add File From Program";
            this.btnAddFileDB.UseVisualStyleBackColor = false;
            this.btnAddFileDB.Visible = false;
            this.btnAddFileDB.Click += new System.EventHandler(this.btnAddFileDB_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(12, 219);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(81, 13);
            this.lbSearch.TabIndex = 9;
            this.lbSearch.Text = "Search by word";
            // 
            // CreateFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 412);
            this.Controls.Add(this.splitContainer1);
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
        private System.Windows.Forms.TextBox txtSearchFile;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btnAddFileDB;
    }
}

