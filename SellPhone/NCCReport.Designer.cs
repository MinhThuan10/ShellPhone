namespace SellPhone
{
    partial class NCCReport
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
            this.crystalReportViewerNCC = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerNCC
            // 
            this.crystalReportViewerNCC.ActiveViewIndex = -1;
            this.crystalReportViewerNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerNCC.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerNCC.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerNCC.Name = "crystalReportViewerNCC";
            this.crystalReportViewerNCC.Size = new System.Drawing.Size(1373, 491);
            this.crystalReportViewerNCC.TabIndex = 0;
            // 
            // NCCReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 491);
            this.Controls.Add(this.crystalReportViewerNCC);
            this.Name = "NCCReport";
            this.Text = "NCCReport";
            this.Load += new System.EventHandler(this.NCCReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerNCC;
    }
}