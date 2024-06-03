namespace SellPhone
{
    partial class FindBillControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxQ = new System.Windows.Forms.CheckBox();
            this.checkBoxYear = new System.Windows.Forms.CheckBox();
            this.checkBoxMonth = new System.Windows.Forms.CheckBox();
            this.checkBoxDay = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.findBtn = new System.Windows.Forms.Button();
            this.refeshBtn = new System.Windows.Forms.Button();
            this.yearInp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.monthInp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dayInp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgBill = new System.Windows.Forms.DataGridView();
            this.btnrpt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBill)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnrpt);
            this.groupBox1.Controls.Add(this.checkBoxQ);
            this.groupBox1.Controls.Add(this.checkBoxYear);
            this.groupBox1.Controls.Add(this.checkBoxMonth);
            this.groupBox1.Controls.Add(this.checkBoxDay);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.findBtn);
            this.groupBox1.Controls.Add(this.refeshBtn);
            this.groupBox1.Controls.Add(this.yearInp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.monthInp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dayInp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(986, 266);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // checkBoxQ
            // 
            this.checkBoxQ.AutoSize = true;
            this.checkBoxQ.Location = new System.Drawing.Point(389, 54);
            this.checkBoxQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxQ.Name = "checkBoxQ";
            this.checkBoxQ.Size = new System.Drawing.Size(22, 21);
            this.checkBoxQ.TabIndex = 13;
            this.checkBoxQ.UseVisualStyleBackColor = true;
            this.checkBoxQ.CheckedChanged += new System.EventHandler(this.checkBoxQ_CheckedChanged);
            // 
            // checkBoxYear
            // 
            this.checkBoxYear.AutoSize = true;
            this.checkBoxYear.Location = new System.Drawing.Point(37, 182);
            this.checkBoxYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxYear.Name = "checkBoxYear";
            this.checkBoxYear.Size = new System.Drawing.Size(22, 21);
            this.checkBoxYear.TabIndex = 12;
            this.checkBoxYear.UseVisualStyleBackColor = true;
            this.checkBoxYear.CheckedChanged += new System.EventHandler(this.checkBoxYear_CheckedChanged);
            // 
            // checkBoxMonth
            // 
            this.checkBoxMonth.AutoSize = true;
            this.checkBoxMonth.Location = new System.Drawing.Point(37, 115);
            this.checkBoxMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxMonth.Name = "checkBoxMonth";
            this.checkBoxMonth.Size = new System.Drawing.Size(22, 21);
            this.checkBoxMonth.TabIndex = 11;
            this.checkBoxMonth.UseVisualStyleBackColor = true;
            this.checkBoxMonth.CheckedChanged += new System.EventHandler(this.checkBoxMonth_CheckedChanged);
            // 
            // checkBoxDay
            // 
            this.checkBoxDay.AutoSize = true;
            this.checkBoxDay.Location = new System.Drawing.Point(37, 54);
            this.checkBoxDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxDay.Name = "checkBoxDay";
            this.checkBoxDay.Size = new System.Drawing.Size(22, 21);
            this.checkBoxDay.TabIndex = 10;
            this.checkBoxDay.UseVisualStyleBackColor = true;
            this.checkBoxDay.CheckedChanged += new System.EventHandler(this.checkBoxDay_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(416, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(296, 169);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quý";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(168, 115);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(93, 34);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Quý 4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(54, 115);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(93, 34);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Quý 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(168, 46);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 34);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Quý 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(54, 46);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 34);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Quý 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // findBtn
            // 
            this.findBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.Image = global::SellPhone.Properties.Resources.zoom_in;
            this.findBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findBtn.Location = new System.Drawing.Point(774, 117);
            this.findBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findBtn.Name = "findBtn";
            this.findBtn.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findBtn.Size = new System.Drawing.Size(174, 58);
            this.findBtn.TabIndex = 9;
            this.findBtn.Text = "    Tìm Kiếm";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // refeshBtn
            // 
            this.refeshBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refeshBtn.Image = global::SellPhone.Properties.Resources.loading;
            this.refeshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refeshBtn.Location = new System.Drawing.Point(774, 54);
            this.refeshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refeshBtn.Name = "refeshBtn";
            this.refeshBtn.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refeshBtn.Size = new System.Drawing.Size(174, 59);
            this.refeshBtn.TabIndex = 7;
            this.refeshBtn.Text = "    Làm Mới";
            this.refeshBtn.UseVisualStyleBackColor = true;
            this.refeshBtn.Click += new System.EventHandler(this.refeshBtn_Click);
            // 
            // yearInp
            // 
            this.yearInp.Location = new System.Drawing.Point(152, 174);
            this.yearInp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yearInp.Name = "yearInp";
            this.yearInp.Size = new System.Drawing.Size(185, 35);
            this.yearInp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Năm: ";
            // 
            // monthInp
            // 
            this.monthInp.FormattingEnabled = true;
            this.monthInp.Location = new System.Drawing.Point(152, 106);
            this.monthInp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.monthInp.Name = "monthInp";
            this.monthInp.Size = new System.Drawing.Size(185, 36);
            this.monthInp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tháng: ";
            // 
            // dayInp
            // 
            this.dayInp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayInp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dayInp.Location = new System.Drawing.Point(152, 42);
            this.dayInp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dayInp.Name = "dayInp";
            this.dayInp.Size = new System.Drawing.Size(185, 35);
            this.dayInp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "TÌM KIẾM HÓA ĐƠN";
            // 
            // dgBill
            // 
            this.dgBill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBill.Location = new System.Drawing.Point(20, 344);
            this.dgBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgBill.Name = "dgBill";
            this.dgBill.RowHeadersWidth = 51;
            this.dgBill.RowTemplate.Height = 24;
            this.dgBill.Size = new System.Drawing.Size(986, 392);
            this.dgBill.TabIndex = 14;
            this.dgBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBill_CellContentClick);
            // 
            // btnrpt
            // 
            this.btnrpt.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnrpt.Image = global::SellPhone.Properties.Resources.business_report1;
            this.btnrpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrpt.Location = new System.Drawing.Point(774, 192);
            this.btnrpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnrpt.Name = "btnrpt";
            this.btnrpt.Padding = new System.Windows.Forms.Padding(4);
            this.btnrpt.Size = new System.Drawing.Size(174, 58);
            this.btnrpt.TabIndex = 23;
            this.btnrpt.Text = "     Báo Cáo";
            this.btnrpt.UseVisualStyleBackColor = true;
            this.btnrpt.Click += new System.EventHandler(this.btnrpt_Click);
            // 
            // FindBillControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FindBillControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1026, 765);
            this.Load += new System.EventHandler(this.FindBillControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxYear;
        private System.Windows.Forms.CheckBox checkBoxMonth;
        private System.Windows.Forms.CheckBox checkBoxDay;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button refeshBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxQ;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox yearInp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox monthInp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dayInp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgBill;
        private System.Windows.Forms.Button btnrpt;
    }
}
