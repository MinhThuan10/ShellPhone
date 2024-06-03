namespace SellPhone
{
    partial class Chart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chosen = new System.Windows.Forms.GroupBox();
            this.txtNamBD = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.rdtMonth = new System.Windows.Forms.RadioButton();
            this.rdtYear = new System.Windows.Forms.RadioButton();
            this.lblNamBD = new System.Windows.Forms.Label();
            this.lblNamKT = new System.Windows.Forms.Label();
            this.txtNamKT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.Chosen.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(0, 297);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(1022, 444);
            this.chartDoanhThu.TabIndex = 0;
            this.chartDoanhThu.Text = "chart1";
            // 
            // Chosen
            // 
            this.Chosen.Controls.Add(this.lblNamKT);
            this.Chosen.Controls.Add(this.txtNamKT);
            this.Chosen.Controls.Add(this.lblNamBD);
            this.Chosen.Controls.Add(this.rdtYear);
            this.Chosen.Controls.Add(this.rdtMonth);
            this.Chosen.Controls.Add(this.txtNamBD);
            this.Chosen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Chosen.Location = new System.Drawing.Point(32, 18);
            this.Chosen.Name = "Chosen";
            this.Chosen.Size = new System.Drawing.Size(454, 243);
            this.Chosen.TabIndex = 1;
            this.Chosen.TabStop = false;
            this.Chosen.Text = "Doanh Thu";
            // 
            // txtNamBD
            // 
            this.txtNamBD.Location = new System.Drawing.Point(223, 120);
            this.txtNamBD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamBD.Name = "txtNamBD";
            this.txtNamBD.Size = new System.Drawing.Size(185, 39);
            this.txtNamBD.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(760, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 59);
            this.panel1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::SellPhone.Properties.Resources.icons8_restart_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-17, -6);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(284, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "        Load";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdtMonth
            // 
            this.rdtMonth.AutoSize = true;
            this.rdtMonth.Location = new System.Drawing.Point(27, 53);
            this.rdtMonth.Name = "rdtMonth";
            this.rdtMonth.Size = new System.Drawing.Size(106, 36);
            this.rdtMonth.TabIndex = 20;
            this.rdtMonth.TabStop = true;
            this.rdtMonth.Text = "Tháng";
            this.rdtMonth.UseVisualStyleBackColor = true;
            this.rdtMonth.CheckedChanged += new System.EventHandler(this.rdtMonth_CheckedChanged);
            // 
            // rdtYear
            // 
            this.rdtYear.AutoSize = true;
            this.rdtYear.Location = new System.Drawing.Point(318, 53);
            this.rdtYear.Name = "rdtYear";
            this.rdtYear.Size = new System.Drawing.Size(90, 36);
            this.rdtYear.TabIndex = 21;
            this.rdtYear.TabStop = true;
            this.rdtYear.Text = "Năm";
            this.rdtYear.UseVisualStyleBackColor = true;
            this.rdtYear.CheckedChanged += new System.EventHandler(this.rdtYear_CheckedChanged);
            // 
            // lblNamBD
            // 
            this.lblNamBD.AutoSize = true;
            this.lblNamBD.Location = new System.Drawing.Point(33, 123);
            this.lblNamBD.Name = "lblNamBD";
            this.lblNamBD.Size = new System.Drawing.Size(161, 32);
            this.lblNamBD.TabIndex = 22;
            this.lblNamBD.Text = "Năm Bắt Đầu:";
            // 
            // lblNamKT
            // 
            this.lblNamKT.AutoSize = true;
            this.lblNamKT.Location = new System.Drawing.Point(33, 176);
            this.lblNamKT.Name = "lblNamKT";
            this.lblNamKT.Size = new System.Drawing.Size(171, 32);
            this.lblNamKT.TabIndex = 24;
            this.lblNamKT.Text = "Năm Kết Thúc:";
            // 
            // txtNamKT
            // 
            this.txtNamKT.Location = new System.Drawing.Point(223, 173);
            this.txtNamKT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamKT.Name = "txtNamKT";
            this.txtNamKT.Size = new System.Drawing.Size(185, 39);
            this.txtNamKT.TabIndex = 23;
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Chosen);
            this.Controls.Add(this.chartDoanhThu);
            this.Name = "Chart";
            this.Size = new System.Drawing.Size(1022, 741);
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.Chosen.ResumeLayout(false);
            this.Chosen.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.GroupBox Chosen;
        private System.Windows.Forms.TextBox txtNamBD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNamKT;
        private System.Windows.Forms.TextBox txtNamKT;
        private System.Windows.Forms.Label lblNamBD;
        private System.Windows.Forms.RadioButton rdtYear;
        private System.Windows.Forms.RadioButton rdtMonth;
    }
}
