namespace SellPhone
{
    partial class ModifyNCC
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
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailInp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressInp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameInp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.grbInfo.SuspendLayout();
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
            this.grbInfo.Size = new System.Drawing.Size(800, 170);
            this.grbInfo.TabIndex = 2;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailInp
            // 
            this.emailInp.Location = new System.Drawing.Point(251, 125);
            this.emailInp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailInp.Name = "emailInp";
            this.emailInp.Size = new System.Drawing.Size(433, 30);
            this.emailInp.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa Chỉ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressInp
            // 
            this.addressInp.Location = new System.Drawing.Point(251, 83);
            this.addressInp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressInp.Name = "addressInp";
            this.addressInp.Size = new System.Drawing.Size(433, 30);
            this.addressInp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhà Cung Cấp:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameInp
            // 
            this.nameInp.Location = new System.Drawing.Point(251, 41);
            this.nameInp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameInp.Name = "nameInp";
            this.nameInp.Size = new System.Drawing.Size(433, 30);
            this.nameInp.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SellPhone.Properties.Resources.diskette;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(222, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Size = new System.Drawing.Size(130, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "   Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::SellPhone.Properties.Resources.cross;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(426, 198);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Size = new System.Drawing.Size(130, 46);
            this.button5.TabIndex = 6;
            this.button5.Text = "   Hủy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ModifyNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbInfo);
            this.Name = "ModifyNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa nhà cung cấp";
            this.Load += new System.EventHandler(this.ModifyNCC_Load);
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailInp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressInp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
    }
}