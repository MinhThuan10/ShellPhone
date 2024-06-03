namespace SellPhone
{
    partial class SanPhamReport
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
            this.crystalReportViewerSanPham = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerSanPham
            // 
            this.crystalReportViewerSanPham.ActiveViewIndex = -1;
            this.crystalReportViewerSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerSanPham.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerSanPham.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerSanPham.Name = "crystalReportViewerSanPham";
            this.crystalReportViewerSanPham.Size = new System.Drawing.Size(1212, 450);
            this.crystalReportViewerSanPham.TabIndex = 0;
            // 
            // SanPhamReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 450);
            this.Controls.Add(this.crystalReportViewerSanPham);
            this.Name = "SanPhamReport";
            this.Text = "SanPhamReport";
            this.Load += new System.EventHandler(this.SanPhamReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerSanPham;
    }
}