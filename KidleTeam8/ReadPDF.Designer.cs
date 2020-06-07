namespace KidleTeam8
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
            this.AdobeReadPDF = new AxAcroPDFLib.AxAcroPDF();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpenPDF = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.AdobeReadPDF)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdobeReadPDF
            // 
            this.AdobeReadPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdobeReadPDF.Enabled = true;
            this.AdobeReadPDF.Location = new System.Drawing.Point(0, 24);
            this.AdobeReadPDF.Name = "AdobeReadPDF";
            this.AdobeReadPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AdobeReadPDF.OcxState")));
            this.AdobeReadPDF.Size = new System.Drawing.Size(800, 426);
            this.AdobeReadPDF.TabIndex = 0;
            this.AdobeReadPDF.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenPDF});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OpenPDF
            // 
            this.OpenPDF.Name = "OpenPDF";
            this.OpenPDF.Size = new System.Drawing.Size(102, 20);
            this.OpenPDF.Text = "Mở Tập Tin PDF";
            this.OpenPDF.Click += new System.EventHandler(this.OpenPDF_Click);
            // 
            // ReadPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdobeReadPDF);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReadPDF";
            this.Text = "ReadPDF";
            ((System.ComponentModel.ISupportInitialize)(this.AdobeReadPDF)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF AdobeReadPDF;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenPDF;
    }
}