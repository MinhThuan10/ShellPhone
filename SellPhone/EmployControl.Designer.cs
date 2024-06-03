namespace SellPhone
{
    partial class EmployControl
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
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_GioiTinh = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtGridView_NhanVien = new System.Windows.Forms.DataGridView();
            this.col_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayTuyenDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.datetimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.datetimePicker_NgayTuyenDung = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_NhanVien)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datetimePicker_NgayTuyenDung);
            this.groupBox1.Controls.Add(this.datetimePicker_NgaySinh);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.txt_GioiTinh);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.txt_HoTen);
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiaChi.Location = new System.Drawing.Point(104, 160);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(326, 22);
            this.txt_DiaChi.TabIndex = 14;
            // 
            // txt_GioiTinh
            // 
            this.txt_GioiTinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GioiTinh.Location = new System.Drawing.Point(550, 36);
            this.txt_GioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.Size = new System.Drawing.Size(122, 22);
            this.txt_GioiTinh.TabIndex = 12;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.Location = new System.Drawing.Point(326, 38);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(104, 22);
            this.txt_SDT.TabIndex = 10;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HoTen.Location = new System.Drawing.Point(104, 97);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(114, 22);
            this.txt_HoTen.TabIndex = 9;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaNV.Location = new System.Drawing.Point(104, 37);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(114, 22);
            this.txt_MaNV.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(472, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Giới tính:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(419, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày tuyển dụng:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(-4, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(195, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(212, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-2, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGridView_NhanVien);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // dtGridView_NhanVien
            // 
            this.dtGridView_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaNV,
            this.col_HoTen,
            this.col_SDT,
            this.col_NgaySinh,
            this.col_GioiTinh,
            this.col_NgayTuyenDung,
            this.col_DiaChi});
            this.dtGridView_NhanVien.Location = new System.Drawing.Point(7, 25);
            this.dtGridView_NhanVien.Name = "dtGridView_NhanVien";
            this.dtGridView_NhanVien.Size = new System.Drawing.Size(664, 193);
            this.dtGridView_NhanVien.TabIndex = 0;
            this.dtGridView_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_NhanVien_CellContentClick);
            this.dtGridView_NhanVien.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_NhanVien_CellContentDoubleClick);
            // 
            // col_MaNV
            // 
            this.col_MaNV.DataPropertyName = "MaNV";
            this.col_MaNV.HeaderText = "Mã nhân viên ";
            this.col_MaNV.Name = "col_MaNV";
            // 
            // col_HoTen
            // 
            this.col_HoTen.DataPropertyName = "HoTen";
            this.col_HoTen.HeaderText = "Họ tên";
            this.col_HoTen.Name = "col_HoTen";
            // 
            // col_SDT
            // 
            this.col_SDT.DataPropertyName = "SDT";
            this.col_SDT.HeaderText = "Số điện thoại";
            this.col_SDT.Name = "col_SDT";
            // 
            // col_NgaySinh
            // 
            this.col_NgaySinh.DataPropertyName = "NgaySinh";
            this.col_NgaySinh.HeaderText = "Ngày sinh";
            this.col_NgaySinh.Name = "col_NgaySinh";
            // 
            // col_GioiTinh
            // 
            this.col_GioiTinh.DataPropertyName = "GioiTinh";
            this.col_GioiTinh.HeaderText = "Giới tính";
            this.col_GioiTinh.Name = "col_GioiTinh";
            // 
            // col_NgayTuyenDung
            // 
            this.col_NgayTuyenDung.DataPropertyName = "NgayTuyenDung";
            this.col_NgayTuyenDung.HeaderText = "Ngày tuyển dụng";
            this.col_NgayTuyenDung.Name = "col_NgayTuyenDung";
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.DataPropertyName = "DiaChi";
            this.col_DiaChi.HeaderText = "Địa chỉ";
            this.col_DiaChi.Name = "col_DiaChi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_cancel);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_modify);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 430);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Image = global::SellPhone.Properties.Resources.cross;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(562, 29);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Padding = new System.Windows.Forms.Padding(3);
            this.btn_cancel.Size = new System.Drawing.Size(97, 37);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "       Bỏ chọn";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::SellPhone.Properties.Resources.trash;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(380, 29);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(3);
            this.btn_delete.Size = new System.Drawing.Size(97, 37);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "   Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Image = global::SellPhone.Properties.Resources.edit;
            this.btn_modify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modify.Location = new System.Drawing.Point(190, 29);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Padding = new System.Windows.Forms.Padding(3);
            this.btn_modify.Size = new System.Drawing.Size(97, 37);
            this.btn_modify.TabIndex = 3;
            this.btn_modify.Text = "   Sửa";
            this.btn_modify.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Image = global::SellPhone.Properties.Resources.plus;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(20, 29);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(3);
            this.btn_add.Size = new System.Drawing.Size(97, 37);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "   Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // datetimePicker_NgaySinh
            // 
            this.datetimePicker_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimePicker_NgaySinh.Location = new System.Drawing.Point(326, 98);
            this.datetimePicker_NgaySinh.Name = "datetimePicker_NgaySinh";
            this.datetimePicker_NgaySinh.Size = new System.Drawing.Size(104, 22);
            this.datetimePicker_NgaySinh.TabIndex = 15;
            this.datetimePicker_NgaySinh.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // datetimePicker_NgayTuyenDung
            // 
            this.datetimePicker_NgayTuyenDung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimePicker_NgayTuyenDung.Location = new System.Drawing.Point(550, 98);
            this.datetimePicker_NgayTuyenDung.Name = "datetimePicker_NgayTuyenDung";
            this.datetimePicker_NgayTuyenDung.Size = new System.Drawing.Size(122, 22);
            this.datetimePicker_NgayTuyenDung.TabIndex = 16;
            this.datetimePicker_NgayTuyenDung.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // EmployControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployControl";
            this.Size = new System.Drawing.Size(684, 504);
            this.Load += new System.EventHandler(this.EmployControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_NhanVien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_GioiTinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtGridView_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayTuyenDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaChi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DateTimePicker datetimePicker_NgaySinh;
        private System.Windows.Forms.DateTimePicker datetimePicker_NgayTuyenDung;
    }
}
