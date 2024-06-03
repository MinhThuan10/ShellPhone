namespace SellPhone
{
    partial class PNReport
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
            this.crystalReportViewerPN = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerPN
            // 
            this.crystalReportViewerPN.ActiveViewIndex = -1;
            this.crystalReportViewerPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerPN.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerPN.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerPN.Name = "crystalReportViewerPN";
            this.crystalReportViewerPN.Size = new System.Drawing.Size(1199, 450);
            this.crystalReportViewerPN.TabIndex = 0;
            // 
            // PNReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 450);
            this.Controls.Add(this.crystalReportViewerPN);
            this.Name = "PNReport";
            this.Text = "PNReport";
            this.Load += new System.EventHandler(this.PNReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerPN;
    }
}