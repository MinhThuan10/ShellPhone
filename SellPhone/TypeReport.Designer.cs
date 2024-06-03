namespace SellPhone
{
    partial class TypeReport
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
            this.crystalReportViewerType = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerType
            // 
            this.crystalReportViewerType.ActiveViewIndex = -1;
            this.crystalReportViewerType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerType.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerType.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerType.Name = "crystalReportViewerType";
            this.crystalReportViewerType.Size = new System.Drawing.Size(1062, 450);
            this.crystalReportViewerType.TabIndex = 0;
            // 
            // TypeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 450);
            this.Controls.Add(this.crystalReportViewerType);
            this.Name = "TypeReport";
            this.Text = "TypeReport";
            this.Load += new System.EventHandler(this.TypeReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerType;
    }
}