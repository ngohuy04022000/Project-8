namespace KindleTeam8.Views
{
    partial class ChosseFileinDB
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
            this.lstFile = new System.Windows.Forms.ListView();
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLinked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstFile
            // 
            this.lstFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.cLinked});
            this.lstFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstFile.HideSelection = false;
            this.lstFile.Location = new System.Drawing.Point(0, 0);
            this.lstFile.Name = "lstFile";
            this.lstFile.Size = new System.Drawing.Size(384, 332);
            this.lstFile.TabIndex = 0;
            this.lstFile.UseCompatibleStateImageBehavior = false;
            this.lstFile.View = System.Windows.Forms.View.Details;
            this.lstFile.DoubleClick += new System.EventHandler(this.lstFile_DoubleClick);
            // 
            // cName
            // 
            this.cName.Text = "Tên";
            // 
            // cLinked
            // 
            this.cLinked.Text = "Danh sách";
            this.cLinked.Width = 73;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(0, 332);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(384, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // ChosseFileinDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstFile);
            this.Name = "ChosseFileinDB";
            this.Text = "ChosseFileinDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstFile;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cLinked;
        private System.Windows.Forms.TextBox txtSearch;
    }
}