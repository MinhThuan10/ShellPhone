namespace SellPhone
{
    partial class PhoneControl
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
            this.pnlTaskbar = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grbPhoneList = new System.Windows.Forms.GroupBox();
            this.dgvPhoneList = new System.Windows.Forms.DataGridView();
            this.grbPhoneImage = new System.Windows.Forms.GroupBox();
            this.pibPhoneImage = new System.Windows.Forms.PictureBox();
            this.grbPhoneInfor = new System.Windows.Forms.GroupBox();
            this.txtPhoneGuaranteeTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhoneBattery = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhoneColor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhoneMemory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneRAM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhoneChip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneOS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneProvider = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTaskbar.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.grbPhoneList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneList)).BeginInit();
            this.grbPhoneImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibPhoneImage)).BeginInit();
            this.grbPhoneInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTaskbar
            // 
            this.pnlTaskbar.Controls.Add(this.button1);
            this.pnlTaskbar.Controls.Add(this.btnAdd);
            this.pnlTaskbar.Controls.Add(this.btnUpdate);
            this.pnlTaskbar.Controls.Add(this.btnDelete);
            this.pnlTaskbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTaskbar.Location = new System.Drawing.Point(0, 548);
            this.pnlTaskbar.Name = "pnlTaskbar";
            this.pnlTaskbar.Size = new System.Drawing.Size(911, 66);
            this.pnlTaskbar.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::SellPhone.Properties.Resources.plus;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(445, 8);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Size = new System.Drawing.Size(130, 46);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "   Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::SellPhone.Properties.Resources.edit;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(596, 8);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Size = new System.Drawing.Size(130, 46);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "   Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::SellPhone.Properties.Resources.trash;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(747, 8);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Size = new System.Drawing.Size(130, 46);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "   Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Controls.Add(this.grbPhoneList);
            this.pnlContainer.Controls.Add(this.grbPhoneImage);
            this.pnlContainer.Controls.Add(this.grbPhoneInfor);
            this.pnlContainer.Controls.Add(this.label12);
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(908, 551);
            this.pnlContainer.TabIndex = 22;
            // 
            // grbPhoneList
            // 
            this.grbPhoneList.Controls.Add(this.dgvPhoneList);
            this.grbPhoneList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPhoneList.Location = new System.Drawing.Point(11, 397);
            this.grbPhoneList.Name = "grbPhoneList";
            this.grbPhoneList.Size = new System.Drawing.Size(880, 300);
            this.grbPhoneList.TabIndex = 20;
            this.grbPhoneList.TabStop = false;
            this.grbPhoneList.Text = "Danh sách sản phẩm";
            // 
            // dgvPhoneList
            // 
            this.dgvPhoneList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPhoneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoneList.Location = new System.Drawing.Point(17, 29);
            this.dgvPhoneList.Name = "dgvPhoneList";
            this.dgvPhoneList.RowHeadersWidth = 51;
            this.dgvPhoneList.RowTemplate.Height = 24;
            this.dgvPhoneList.Size = new System.Drawing.Size(843, 255);
            this.dgvPhoneList.TabIndex = 0;
            this.dgvPhoneList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhoneList_CellClick);
            // 
            // grbPhoneImage
            // 
            this.grbPhoneImage.Controls.Add(this.pibPhoneImage);
            this.grbPhoneImage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPhoneImage.Location = new System.Drawing.Point(591, 67);
            this.grbPhoneImage.Name = "grbPhoneImage";
            this.grbPhoneImage.Size = new System.Drawing.Size(300, 314);
            this.grbPhoneImage.TabIndex = 19;
            this.grbPhoneImage.TabStop = false;
            this.grbPhoneImage.Text = "Hình ảnh";
            // 
            // pibPhoneImage
            // 
            this.pibPhoneImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pibPhoneImage.Location = new System.Drawing.Point(20, 40);
            this.pibPhoneImage.Name = "pibPhoneImage";
            this.pibPhoneImage.Size = new System.Drawing.Size(260, 260);
            this.pibPhoneImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibPhoneImage.TabIndex = 0;
            this.pibPhoneImage.TabStop = false;
            // 
            // grbPhoneInfor
            // 
            this.grbPhoneInfor.Controls.Add(this.txtPhoneGuaranteeTime);
            this.grbPhoneInfor.Controls.Add(this.label11);
            this.grbPhoneInfor.Controls.Add(this.txtPhoneBattery);
            this.grbPhoneInfor.Controls.Add(this.label10);
            this.grbPhoneInfor.Controls.Add(this.txtPhoneColor);
            this.grbPhoneInfor.Controls.Add(this.label9);
            this.grbPhoneInfor.Controls.Add(this.txtPhoneMemory);
            this.grbPhoneInfor.Controls.Add(this.label8);
            this.grbPhoneInfor.Controls.Add(this.txtPhoneRAM);
            this.grbPhoneInfor.Controls.Add(this.label7);
            this.grbPhoneInfor.Controls.Add(this.txtPhoneChip);
            this.grbPhoneInfor.Controls.Add(this.label6);
            this.grbPhoneInfor.Controls.Add(this.txtPhoneOS);
            this.grbPhoneInfor.Controls.Add(this.label5);
            this.grbPhoneInfor.Controls.Add(this.txtPhoneBrand);
            this.grbPhoneInfor.Controls.Add(this.label4);
            this.grbPhoneInfor.Controls.Add(this.txtPhoneProvider);
            this.grbPhoneInfor.Controls.Add(this.label2);
            this.grbPhoneInfor.Controls.Add(this.txtPhoneType);
            this.grbPhoneInfor.Controls.Add(this.label3);
            this.grbPhoneInfor.Controls.Add(this.txtPhoneName);
            this.grbPhoneInfor.Controls.Add(this.label1);
            this.grbPhoneInfor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPhoneInfor.Location = new System.Drawing.Point(11, 67);
            this.grbPhoneInfor.Name = "grbPhoneInfor";
            this.grbPhoneInfor.Size = new System.Drawing.Size(564, 314);
            this.grbPhoneInfor.TabIndex = 18;
            this.grbPhoneInfor.TabStop = false;
            this.grbPhoneInfor.Text = "Thông tin điện thoại";
            // 
            // txtPhoneGuaranteeTime
            // 
            this.txtPhoneGuaranteeTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPhoneGuaranteeTime.Location = new System.Drawing.Point(434, 255);
            this.txtPhoneGuaranteeTime.Name = "txtPhoneGuaranteeTime";
            this.txtPhoneGuaranteeTime.ReadOnly = true;
            this.txtPhoneGuaranteeTime.Size = new System.Drawing.Size(112, 30);
            this.txtPhoneGuaranteeTime.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(430, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "TGBH";
            // 
            // txtPhoneBattery
            // 
            this.txtPhoneBattery.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPhoneBattery.Location = new System.Drawing.Point(387, 193);
            this.txtPhoneBattery.Name = "txtPhoneBattery";
            this.txtPhoneBattery.ReadOnly = true;
            this.txtPhoneBattery.Size = new System.Drawing.Size(160, 30);
            this.txtPhoneBattery.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(383, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Dung lượng pin";
            // 
            // txtPhoneColor
            // 
            this.txtPhoneColor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPhoneColor.Location = new System.Drawing.Point(295, 255);
            this.txtPhoneColor.Name = "txtPhoneColor";
            this.txtPhoneColor.ReadOnly = true;
            this.txtPhoneColor.Size = new System.Drawing.Size(112, 30);
            this.txtPhoneColor.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Màu sắc";
            // 
            // txtPhoneMemory
            // 
            this.txtPhoneMemory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPhoneMemory.Location = new System.Drawing.Point(17, 255);
            this.txtPhoneMemory.Name = "txtPhoneMemory";
            this.txtPhoneMemory.ReadOnly = true;
            this.txtPhoneMemory.Size = new System.Drawing.Size(112, 30);
            this.txtPhoneMemory.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Bộ nhớ";
            // 
            // txtPhoneRAM
            // 
            this.txtPhoneRAM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPhoneRAM.Location = new System.Drawing.Point(156, 255);
            this.txtPhoneRAM.Name = "txtPhoneRAM";
            this.txtPhoneRAM.ReadOnly = true;
            this.txtPhoneRAM.Size = new System.Drawing.Size(112, 30);
            this.txtPhoneRAM.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "RAM";
            // 
            // txtPhoneChip
            // 
            this.txtPhoneChip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPhoneChip.Location = new System.Drawing.Point(202, 193);
            this.txtPhoneChip.Name = "txtPhoneChip";
            this.txtPhoneChip.ReadOnly = true;
            this.txtPhoneChip.Size = new System.Drawing.Size(160, 30);
            this.txtPhoneChip.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Chip";
            // 
            // txtPhoneOS
            // 
            this.txtPhoneOS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPhoneOS.Location = new System.Drawing.Point(17, 193);
            this.txtPhoneOS.Name = "txtPhoneOS";
            this.txtPhoneOS.ReadOnly = true;
            this.txtPhoneOS.Size = new System.Drawing.Size(160, 30);
            this.txtPhoneOS.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hệ điều hành";
            // 
            // txtPhoneBrand
            // 
            this.txtPhoneBrand.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPhoneBrand.Location = new System.Drawing.Point(354, 129);
            this.txtPhoneBrand.Name = "txtPhoneBrand";
            this.txtPhoneBrand.ReadOnly = true;
            this.txtPhoneBrand.Size = new System.Drawing.Size(194, 30);
            this.txtPhoneBrand.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hãng";
            // 
            // txtPhoneProvider
            // 
            this.txtPhoneProvider.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPhoneProvider.Location = new System.Drawing.Point(17, 129);
            this.txtPhoneProvider.Name = "txtPhoneProvider";
            this.txtPhoneProvider.ReadOnly = true;
            this.txtPhoneProvider.Size = new System.Drawing.Size(310, 30);
            this.txtPhoneProvider.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhà cung cấp";
            // 
            // txtPhoneType
            // 
            this.txtPhoneType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPhoneType.Location = new System.Drawing.Point(354, 66);
            this.txtPhoneType.Name = "txtPhoneType";
            this.txtPhoneType.ReadOnly = true;
            this.txtPhoneType.Size = new System.Drawing.Size(194, 30);
            this.txtPhoneType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại sản phẩm";
            // 
            // txtPhoneName
            // 
            this.txtPhoneName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPhoneName.Location = new System.Drawing.Point(17, 66);
            this.txtPhoneName.Name = "txtPhoneName";
            this.txtPhoneName.ReadOnly = true;
            this.txtPhoneName.Size = new System.Drawing.Size(310, 30);
            this.txtPhoneName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 31);
            this.label12.TabIndex = 17;
            this.label12.Text = "Thông tin điện thoại";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SellPhone.Properties.Resources.grid;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(306, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Size = new System.Drawing.Size(130, 46);
            this.button1.TabIndex = 20;
            this.button1.Text = "   Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhoneControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlTaskbar);
            this.Name = "PhoneControl";
            this.Size = new System.Drawing.Size(911, 614);
            this.Load += new System.EventHandler(this.PhoneControl_Load);
            this.pnlTaskbar.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.grbPhoneList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneList)).EndInit();
            this.grbPhoneImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibPhoneImage)).EndInit();
            this.grbPhoneInfor.ResumeLayout(false);
            this.grbPhoneInfor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlTaskbar;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.GroupBox grbPhoneList;
        private System.Windows.Forms.DataGridView dgvPhoneList;
        private System.Windows.Forms.GroupBox grbPhoneImage;
        private System.Windows.Forms.PictureBox pibPhoneImage;
        private System.Windows.Forms.GroupBox grbPhoneInfor;
        private System.Windows.Forms.TextBox txtPhoneGuaranteeTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPhoneBattery;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhoneColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhoneMemory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhoneRAM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhoneChip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneOS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}
