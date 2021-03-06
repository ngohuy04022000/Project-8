﻿namespace KindleTeam8.Views
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
            this.btnFind = new System.Windows.Forms.Button();
            this.fbdSearchFile = new System.Windows.Forms.FolderBrowserDialog();
            this.bgwFound = new System.ComponentModel.BackgroundWorker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lvwSearch = new System.Windows.Forms.ListView();
            this.cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbrSearch = new System.Windows.Forms.ProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.sctLibrary = new System.Windows.Forms.SplitContainer();
            this.cmbFolderName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            cSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.sctLibrary)).BeginInit();
            this.sctLibrary.Panel1.SuspendLayout();
            this.sctLibrary.Panel2.SuspendLayout();
            this.sctLibrary.SuspendLayout();
            this.SuspendLayout();
            // 
            // cName
            // 
            cName.DisplayIndex = 1;
            cName.Text = "Tên file";
            cName.Width = 237;
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
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::KindleTeam8.Properties.Resources.folder_open;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFind.Location = new System.Drawing.Point(528, 15);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(170, 35);
            this.btnFind.TabIndex = 1;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Location = new System.Drawing.Point(166, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(354, 30);
            this.txtSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(45, 29);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(97, 22);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Đường dẫn";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 83);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 22);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Tên file";
            this.lblName.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 72);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(354, 30);
            this.txtName.TabIndex = 5;
            this.txtName.Visible = false;
            // 
            // lvwSearch
            // 
            this.lvwSearch.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvwSearch.BackColor = System.Drawing.SystemColors.Info;
            this.lvwSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            cName,
            cPath,
            cSize,
            this.cID});
            this.lvwSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwSearch.GridLines = true;
            this.lvwSearch.HideSelection = false;
            this.lvwSearch.Location = new System.Drawing.Point(0, 0);
            this.lvwSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvwSearch.Name = "lvwSearch";
            this.lvwSearch.Size = new System.Drawing.Size(1200, 448);
            this.lvwSearch.TabIndex = 6;
            this.lvwSearch.UseCompatibleStateImageBehavior = false;
            this.lvwSearch.View = System.Windows.Forms.View.Details;
            this.lvwSearch.DoubleClick += new System.EventHandler(this.lvwSearch_DoubleClick);
            // 
            // cID
            // 
            this.cID.DisplayIndex = 0;
            this.cID.Text = "ID";
            this.cID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbrSearch
            // 
            this.pbrSearch.Location = new System.Drawing.Point(48, 126);
            this.pbrSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbrSearch.Name = "pbrSearch";
            this.pbrSearch.Size = new System.Drawing.Size(501, 31);
            this.pbrSearch.TabIndex = 7;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(558, 126);
            this.lblPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(54, 29);
            this.lblPercent.TabIndex = 8;
            this.lblPercent.Text = "0 %";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(44, 178);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 20);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Trạng thái";
            // 
            // sctLibrary
            // 
            this.sctLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sctLibrary.Location = new System.Drawing.Point(0, 0);
            this.sctLibrary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sctLibrary.Name = "sctLibrary";
            this.sctLibrary.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sctLibrary.Panel1
            // 
            this.sctLibrary.Panel1.BackColor = System.Drawing.Color.MintCream;
            this.sctLibrary.Panel1.Controls.Add(this.cmbFolderName);
            this.sctLibrary.Panel1.Controls.Add(this.label1);
            this.sctLibrary.Panel1.Controls.Add(this.lblSearch);
            this.sctLibrary.Panel1.Controls.Add(this.lblPercent);
            this.sctLibrary.Panel1.Controls.Add(this.lblStatus);
            this.sctLibrary.Panel1.Controls.Add(this.txtName);
            this.sctLibrary.Panel1.Controls.Add(this.lblName);
            this.sctLibrary.Panel1.Controls.Add(this.pbrSearch);
            this.sctLibrary.Panel1.Controls.Add(this.txtSearch);
            this.sctLibrary.Panel1.Controls.Add(this.btnFind);
            this.sctLibrary.Panel1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sctLibrary.Panel1.ForeColor = System.Drawing.Color.SteelBlue;
            // 
            // sctLibrary.Panel2
            // 
            this.sctLibrary.Panel2.Controls.Add(this.lvwSearch);
            this.sctLibrary.Size = new System.Drawing.Size(1200, 692);
            this.sctLibrary.SplitterDistance = 238;
            this.sctLibrary.SplitterWidth = 6;
            this.sctLibrary.TabIndex = 10;
            // 
            // cmbFolderName
            // 
            this.cmbFolderName.FormattingEnabled = true;
            this.cmbFolderName.Location = new System.Drawing.Point(704, 69);
            this.cmbFolderName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFolderName.Name = "cmbFolderName";
            this.cmbFolderName.Size = new System.Drawing.Size(180, 30);
            this.cmbFolderName.TabIndex = 11;
            this.cmbFolderName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên List";
            this.label1.Visible = false;
            // 
            // LibraryFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.sctLibrary);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LibraryFile";
            this.Text = "Tìm trong máy";
            this.sctLibrary.Panel1.ResumeLayout(false);
            this.sctLibrary.Panel1.PerformLayout();
            this.sctLibrary.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sctLibrary)).EndInit();
            this.sctLibrary.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.SplitContainer sctLibrary;
        private System.Windows.Forms.ComboBox cmbFolderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader cID;
    }
}

