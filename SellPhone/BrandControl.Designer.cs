namespace SellPhone
{
    partial class BrandControl
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
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailInp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressInp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameInp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnrpt = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnRep = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.label3);
            this.grbInfo.Controls.Add(this.emailInp);
            this.grbInfo.Controls.Add(this.label2);
            this.grbInfo.Controls.Add(this.addressInp);
            this.grbInfo.Controls.Add(this.label1);
            this.grbInfo.Controls.Add(this.nameInp);
            this.grbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbInfo.Location = new System.Drawing.Point(0, 0);
            this.grbInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfo.Size = new System.Drawing.Size(1020, 178);
            this.grbInfo.TabIndex = 0;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailInp
            // 
            this.emailInp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailInp.Location = new System.Drawing.Point(687, 49);
            this.emailInp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailInp.Name = "emailInp";
            this.emailInp.ReadOnly = true;
            this.emailInp.Size = new System.Drawing.Size(240, 34);
            this.emailInp.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa Chỉ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressInp
            // 
            this.addressInp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addressInp.Location = new System.Drawing.Point(276, 111);
            this.addressInp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressInp.Name = "addressInp";
            this.addressInp.ReadOnly = true;
            this.addressInp.Size = new System.Drawing.Size(652, 34);
            this.addressInp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhà Cung Cấp:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameInp
            // 
            this.nameInp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameInp.Location = new System.Drawing.Point(276, 49);
            this.nameInp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameInp.Name = "nameInp";
            this.nameInp.ReadOnly = true;
            this.nameInp.Size = new System.Drawing.Size(307, 34);
            this.nameInp.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 178);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1020, 298);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // dgView
            // 
            this.dgView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.DiaChi,
            this.Email});
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.Location = new System.Drawing.Point(3, 29);
            this.dgView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.RowHeadersWidth = 62;
            this.dgView.RowTemplate.Height = 28;
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView.Size = new System.Drawing.Size(1014, 267);
            this.dgView.TabIndex = 0;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã Nhà Cung Cấp";
            this.MaNCC.MinimumWidth = 150;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            this.MaNCC.Width = 150;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.TenNCC.MinimumWidth = 150;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.ReadOnly = true;
            this.TenNCC.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 253;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 253;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 253;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 253;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnrpt);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnRep);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 476);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1020, 108);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // btnrpt
            // 
            this.btnrpt.Image = global::SellPhone.Properties.Resources.business_report1;
            this.btnrpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrpt.Location = new System.Drawing.Point(842, 31);
            this.btnrpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnrpt.Name = "btnrpt";
            this.btnrpt.Padding = new System.Windows.Forms.Padding(4);
            this.btnrpt.Size = new System.Drawing.Size(146, 58);
            this.btnrpt.TabIndex = 5;
            this.btnrpt.Text = "     Báo Cáo";
            this.btnrpt.UseVisualStyleBackColor = true;
            this.btnrpt.Click += new System.EventHandler(this.btnrpt_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::SellPhone.Properties.Resources.trash;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(644, 32);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Padding = new System.Windows.Forms.Padding(4);
            this.btnDel.Size = new System.Drawing.Size(146, 58);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "   Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnRep
            // 
            this.btnRep.Image = global::SellPhone.Properties.Resources.edit;
            this.btnRep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRep.Location = new System.Drawing.Point(446, 32);
            this.btnRep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRep.Name = "btnRep";
            this.btnRep.Padding = new System.Windows.Forms.Padding(4);
            this.btnRep.Size = new System.Drawing.Size(146, 58);
            this.btnRep.TabIndex = 2;
            this.btnRep.Text = "   Sửa";
            this.btnRep.UseVisualStyleBackColor = true;
            this.btnRep.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::SellPhone.Properties.Resources.loading;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(248, 32);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Padding = new System.Windows.Forms.Padding(4);
            this.btnLoad.Size = new System.Drawing.Size(146, 58);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "   Reload";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::SellPhone.Properties.Resources.plus;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(50, 32);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(4);
            this.btnAdd.Size = new System.Drawing.Size(146, 58);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "   Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrandControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BrandControl";
            this.Size = new System.Drawing.Size(1020, 588);
            this.Load += new System.EventHandler(this.BrandControl_Load);
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInp;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnRep;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailInp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressInp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button btnrpt;
    }
}
