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
            this.mnsReadPDF = new System.Windows.Forms.MenuStrip();
            this.OpenPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.DetailsPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitPDF = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.AdobeReadPDF)).BeginInit();
            this.mnsReadPDF.SuspendLayout();
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
            // mnsReadPDF
            // 
            this.mnsReadPDF.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnsReadPDF.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenPDF,
            this.DetailsPDF,
            this.ExitPDF});
            this.mnsReadPDF.Location = new System.Drawing.Point(0, 0);
            this.mnsReadPDF.Name = "mnsReadPDF";
            this.mnsReadPDF.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mnsReadPDF.Size = new System.Drawing.Size(800, 24);
            this.mnsReadPDF.TabIndex = 1;
            this.mnsReadPDF.Text = "mnsReadPDF";
            // 
            // OpenPDF
            // 
            this.OpenPDF.Name = "OpenPDF";
            this.OpenPDF.Size = new System.Drawing.Size(48, 22);
            this.OpenPDF.Text = "Open";
            this.OpenPDF.Click += new System.EventHandler(this.OpenPDF_Click);
            // 
            // DetailsPDF
            // 
            this.DetailsPDF.Name = "DetailsPDF";
            this.DetailsPDF.Size = new System.Drawing.Size(54, 22);
            this.DetailsPDF.Text = "Details";
            this.DetailsPDF.Click += new System.EventHandler(this.DetailsPDF_Click);
            // 
            // ExitPDF
            // 
            this.ExitPDF.Name = "ExitPDF";
            this.ExitPDF.Size = new System.Drawing.Size(38, 22);
            this.ExitPDF.Text = "Exit";
            this.ExitPDF.Click += new System.EventHandler(this.ExitPDF_Click);
            // 
            // ReadPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdobeReadPDF);
            this.Controls.Add(this.mnsReadPDF);
            this.MainMenuStrip = this.mnsReadPDF;
            this.Name = "ReadPDF";
            this.Text = "ReadPDF";
            ((System.ComponentModel.ISupportInitialize)(this.AdobeReadPDF)).EndInit();
            this.mnsReadPDF.ResumeLayout(false);
            this.mnsReadPDF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF AdobeReadPDF;
        private System.Windows.Forms.MenuStrip mnsReadPDF;
        private System.Windows.Forms.ToolStripMenuItem OpenPDF;
        private System.Windows.Forms.ToolStripMenuItem DetailsPDF;
        private System.Windows.Forms.ToolStripMenuItem ExitPDF;
    }
}