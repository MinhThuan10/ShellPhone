namespace SellPhone
{
    partial class EmployeeControl
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdfemale = new System.Windows.Forms.RadioButton();
            this.rdmale = new System.Windows.Forms.RadioButton();
            this.datetimePicker_NgayTuyenDung = new System.Windows.Forms.DateTimePicker();
            this.datetimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtGridView_NhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTuyenDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_NhanVien)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(912, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdfemale);
            this.groupBox4.Controls.Add(this.rdmale);
            this.groupBox4.Location = new System.Drawing.Point(542, 39);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(311, 80);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giới Tính";
            // 
            // rdfemale
            // 
            this.rdfemale.AutoSize = true;
            this.rdfemale.Location = new System.Drawing.Point(150, 37);
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
            this.rdmale.Location = new System.Drawing.Point(18, 37);
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
            this.datetimePicker_NgayTuyenDung.Location = new System.Drawing.Point(692, 190);
            this.datetimePicker_NgayTuyenDung.Margin = new System.Windows.Forms.Padding(4);
            this.datetimePicker_NgayTuyenDung.Name = "datetimePicker_NgayTuyenDung";
            this.datetimePicker_NgayTuyenDung.Size = new System.Drawing.Size(161, 30);
            this.datetimePicker_NgayTuyenDung.TabIndex = 16;
            this.datetimePicker_NgayTuyenDung.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // datetimePicker_NgaySinh
            // 
            this.datetimePicker_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimePicker_NgaySinh.Location = new System.Drawing.Point(692, 140);
            this.datetimePicker_NgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.datetimePicker_NgaySinh.Name = "datetimePicker_NgaySinh";
            this.datetimePicker_NgaySinh.Size = new System.Drawing.Size(161, 30);
            this.datetimePicker_NgaySinh.TabIndex = 15;
            this.datetimePicker_NgaySinh.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiaChi.Location = new System.Drawing.Point(139, 192);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(357, 30);
            this.txt_DiaChi.TabIndex = 14;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.Location = new System.Drawing.Point(139, 89);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SDT.MaxLength = 10;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(357, 30);
            this.txt_SDT.TabIndex = 10;
            this.txt_SDT.TextChanged += new System.EventHandler(this.txt_SDT_TextChanged);
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HoTen.Location = new System.Drawing.Point(139, 140);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(357, 30);
            this.txt_HoTen.TabIndex = 9;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaNV.Location = new System.Drawing.Point(139, 39);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(357, 30);
            this.txt_MaNV.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày tuyển dụng:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGridView_NhanVien);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 239);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(912, 262);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // dtGridView_NhanVien
            // 
            this.dtGridView_NhanVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGridView_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.SDT,
            this.NgaySinh,
            this.GioiTinh,
            this.NgayTuyenDung,
            this.DiaChi});
            this.dtGridView_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridView_NhanVien.Location = new System.Drawing.Point(4, 26);
            this.dtGridView_NhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridView_NhanVien.Name = "dtGridView_NhanVien";
            this.dtGridView_NhanVien.RowHeadersWidth = 51;
            this.dtGridView_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView_NhanVien.Size = new System.Drawing.Size(904, 232);
            this.dtGridView_NhanVien.TabIndex = 0;
            this.dtGridView_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_NhanVien_CellContentClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên ";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // NgayTuyenDung
            // 
            this.NgayTuyenDung.DataPropertyName = "NgayTuyenDung";
            this.NgayTuyenDung.HeaderText = "Ngày tuyển dụng";
            this.NgayTuyenDung.MinimumWidth = 6;
            this.NgayTuyenDung.Name = "NgayTuyenDung";
            this.NgayTuyenDung.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.btn_cancel);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_modify);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 502);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(912, 110);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::SellPhone.Properties.Resources.loading;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(203, 36);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoad.Size = new System.Drawing.Size(130, 46);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "   Reload";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Image = global::SellPhone.Properties.Resources.cross;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(732, 36);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Padding = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Size = new System.Drawing.Size(129, 46);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "       Bỏ chọn";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::SellPhone.Properties.Resources.trash;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(556, 36);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(4);
            this.btn_delete.Size = new System.Drawing.Size(129, 46);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "   Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Image = global::SellPhone.Properties.Resources.edit;
            this.btn_modify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modify.Location = new System.Drawing.Point(380, 36);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Padding = new System.Windows.Forms.Padding(4);
            this.btn_modify.Size = new System.Drawing.Size(129, 46);
            this.btn_modify.TabIndex = 3;
            this.btn_modify.Text = "   Sửa";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = global::SellPhone.Properties.Resources.plus;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(27, 36);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(4);
            this.btn_add.Size = new System.Drawing.Size(129, 46);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "   Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(912, 612);
            this.Load += new System.EventHandler(this.EmployeeControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_NhanVien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datetimePicker_NgayTuyenDung;
        private System.Windows.Forms.DateTimePicker datetimePicker_NgaySinh;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtGridView_NhanVien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTuyenDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdfemale;
        private System.Windows.Forms.RadioButton rdmale;
    }
}
