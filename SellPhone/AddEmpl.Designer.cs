namespace SellPhone
{
    partial class AddEmpl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdfemale = new System.Windows.Forms.RadioButton();
            this.rdmale = new System.Windows.Forms.RadioButton();
            this.datetimePicker_NgayTuyenDung = new System.Windows.Forms.DateTimePicker();
            this.datetimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.datetimePicker_NgayTuyenDung);
            this.groupBox1.Controls.Add(this.datetimePicker_NgaySinh);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.txt_HoTen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(903, 272);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdfemale);
            this.groupBox4.Controls.Add(this.rdmale);
            this.groupBox4.Location = new System.Drawing.Point(533, 91);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(292, 64);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giới Tính";
            // 
            // rdfemale
            // 
            this.rdfemale.AutoSize = true;
            this.rdfemale.Location = new System.Drawing.Point(155, 27);
            this.rdfemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdfemale.Name = "rdfemale";
            this.rdfemale.Size = new System.Drawing.Size(54, 27);
            this.rdfemale.TabIndex = 1;
            this.rdfemale.TabStop = true;
            this.rdfemale.Text = "Nữ";
            this.rdfemale.UseVisualStyleBackColor = true;
            // 
            // rdmale
            // 
            this.rdmale.AutoSize = true;
            this.rdmale.Location = new System.Drawing.Point(23, 27);
            this.rdmale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdmale.Name = "rdmale";
            this.rdmale.Size = new System.Drawing.Size(68, 27);
            this.rdmale.TabIndex = 0;
            this.rdmale.TabStop = true;
            this.rdmale.Text = "Nam";
            this.rdmale.UseVisualStyleBackColor = true;
            // 
            // datetimePicker_NgayTuyenDung
            // 
            this.datetimePicker_NgayTuyenDung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimePicker_NgayTuyenDung.Location = new System.Drawing.Point(688, 218);
            this.datetimePicker_NgayTuyenDung.Margin = new System.Windows.Forms.Padding(4);
            this.datetimePicker_NgayTuyenDung.Name = "datetimePicker_NgayTuyenDung";
            this.datetimePicker_NgayTuyenDung.Size = new System.Drawing.Size(137, 30);
            this.datetimePicker_NgayTuyenDung.TabIndex = 18;
            this.datetimePicker_NgayTuyenDung.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // datetimePicker_NgaySinh
            // 
            this.datetimePicker_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimePicker_NgaySinh.Location = new System.Drawing.Point(688, 161);
            this.datetimePicker_NgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.datetimePicker_NgaySinh.Name = "datetimePicker_NgaySinh";
            this.datetimePicker_NgaySinh.Size = new System.Drawing.Size(137, 30);
            this.datetimePicker_NgaySinh.TabIndex = 17;
            this.datetimePicker_NgaySinh.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiaChi.Location = new System.Drawing.Point(166, 218);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(328, 30);
            this.txt_DiaChi.TabIndex = 14;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.Location = new System.Drawing.Point(166, 104);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SDT.MaxLength = 10;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(328, 30);
            this.txt_SDT.TabIndex = 10;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HoTen.Location = new System.Drawing.Point(166, 161);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(328, 30);
            this.txt_HoTen.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày tuyển dụng:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = global::SellPhone.Properties.Resources.plus;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(233, 325);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(4);
            this.btn_add.Size = new System.Drawing.Size(129, 46);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "   Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Image = global::SellPhone.Properties.Resources.cross;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(516, 325);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Padding = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Size = new System.Drawing.Size(129, 46);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "       Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // AddEmpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddEmpl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm nhân viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datetimePicker_NgayTuyenDung;
        private System.Windows.Forms.DateTimePicker datetimePicker_NgaySinh;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdfemale;
        private System.Windows.Forms.RadioButton rdmale;
    }
}