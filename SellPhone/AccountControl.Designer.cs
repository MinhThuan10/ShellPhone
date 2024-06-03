namespace SellPhone
{
    partial class AccountControl
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
            this.accountType = new System.Windows.Forms.GroupBox();
            this.cbAdmin = new System.Windows.Forms.RadioButton();
            this.cbStaff = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRep = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.accountType.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.accountType);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1026, 228);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // accountType
            // 
            this.accountType.Controls.Add(this.cbAdmin);
            this.accountType.Controls.Add(this.cbStaff);
            this.accountType.Location = new System.Drawing.Point(310, 25);
            this.accountType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountType.Name = "accountType";
            this.accountType.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountType.Size = new System.Drawing.Size(430, 75);
            this.accountType.TabIndex = 12;
            this.accountType.TabStop = false;
            this.accountType.Text = "Account Type";
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(22, 29);
            this.cbAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(96, 34);
            this.cbAdmin.TabIndex = 13;
            this.cbAdmin.TabStop = true;
            this.cbAdmin.Text = "admin";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // cbStaff
            // 
            this.cbStaff.AutoSize = true;
            this.cbStaff.Location = new System.Drawing.Point(188, 29);
            this.cbStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStaff.Name = "cbStaff";
            this.cbStaff.Size = new System.Drawing.Size(79, 34);
            this.cbStaff.TabIndex = 12;
            this.cbStaff.TabStop = true;
            this.cbStaff.Text = "staff";
            this.cbStaff.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(451, 180);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(289, 35);
            this.txtPassword.TabIndex = 9;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(451, 126);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(289, 35);
            this.txtUserName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(305, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(305, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAccounts);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 228);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1026, 390);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tài khoản";
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.passwd,
            this.isAdmin});
            this.dgvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccounts.Location = new System.Drawing.Point(4, 31);
            this.dgvAccounts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersWidth = 51;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(1018, 354);
            this.dgvAccounts.TabIndex = 0;
            this.dgvAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellClick);
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "UserName";
            this.username.MinimumWidth = 300;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 300;
            // 
            // passwd
            // 
            this.passwd.DataPropertyName = "passwd";
            this.passwd.HeaderText = "PassWord";
            this.passwd.MinimumWidth = 300;
            this.passwd.Name = "passwd";
            this.passwd.ReadOnly = true;
            this.passwd.Width = 300;
            // 
            // isAdmin
            // 
            this.isAdmin.DataPropertyName = "isAdmin";
            this.isAdmin.HeaderText = "Admin";
            this.isAdmin.MinimumWidth = 100;
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.ReadOnly = true;
            this.isAdmin.Width = 150;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRep);
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 627);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1026, 138);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            // 
            // btnRep
            // 
            this.btnRep.Image = global::SellPhone.Properties.Resources.edit;
            this.btnRep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRep.Location = new System.Drawing.Point(338, 49);
            this.btnRep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRep.Name = "btnRep";
            this.btnRep.Padding = new System.Windows.Forms.Padding(4);
            this.btnRep.Size = new System.Drawing.Size(146, 58);
            this.btnRep.TabIndex = 7;
            this.btnRep.Text = "   Sửa";
            this.btnRep.UseVisualStyleBackColor = true;
            this.btnRep.Click += new System.EventHandler(this.btnRep_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::SellPhone.Properties.Resources.loading;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(573, 49);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Padding = new System.Windows.Forms.Padding(4);
            this.btnLoad.Size = new System.Drawing.Size(146, 58);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "   Reload";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::SellPhone.Properties.Resources.trash;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(808, 49);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Size = new System.Drawing.Size(145, 58);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "   Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = global::SellPhone.Properties.Resources.plus;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(104, 49);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add.Size = new System.Drawing.Size(145, 58);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "   Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // AccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AccountControl";
            this.Size = new System.Drawing.Size(1026, 765);
            this.Load += new System.EventHandler(this.AccountControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.accountType.ResumeLayout(false);
            this.accountType.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAdmin;
        private System.Windows.Forms.GroupBox accountType;
        private System.Windows.Forms.RadioButton cbAdmin;
        private System.Windows.Forms.RadioButton cbStaff;
        private System.Windows.Forms.Button btnRep;
    }
}
