namespace SellPhone
{
    partial class HDReport
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
            this.crystalReportViewerHD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerHD
            // 
            this.crystalReportViewerHD.ActiveViewIndex = -1;
            this.crystalReportViewerHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerHD.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerHD.Name = "crystalReportViewerHD";
            this.crystalReportViewerHD.Size = new System.Drawing.Size(1191, 450);
            this.crystalReportViewerHD.TabIndex = 0;
            // 
            // HDReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 450);
            this.Controls.Add(this.crystalReportViewerHD);
            this.Name = "HDReport";
            this.Text = "HDReport";
            this.Load += new System.EventHandler(this.HDReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerHD;
    }
}