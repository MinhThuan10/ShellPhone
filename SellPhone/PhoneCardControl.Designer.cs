namespace SellPhone
{
    partial class PhoneCardControl
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
            this.pnlImageContainer = new System.Windows.Forms.Panel();
            this.pibPhoneImage = new System.Windows.Forms.PictureBox();
            this.pnlPhoneInfor = new System.Windows.Forms.Panel();
            this.pnlPhonePriceContainer = new System.Windows.Forms.Panel();
            this.lblCurrencyUnit = new System.Windows.Forms.Label();
            this.lblPhonePrice = new System.Windows.Forms.Label();
            this.flpPhoneDetailContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRAMInfor = new System.Windows.Forms.Button();
            this.btnMemoryInfor = new System.Windows.Forms.Button();
            this.btnBatteryInfor = new System.Windows.Forms.Button();
            this.btnChipInfor = new System.Windows.Forms.Button();
            this.btnOSInfor = new System.Windows.Forms.Button();
            this.pnlPhoneNameContainer = new System.Windows.Forms.Panel();
            this.lblPhoneName = new System.Windows.Forms.Label();
            this.pnlImageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibPhoneImage)).BeginInit();
            this.pnlPhoneInfor.SuspendLayout();
            this.pnlPhonePriceContainer.SuspendLayout();
            this.flpPhoneDetailContainer.SuspendLayout();
            this.pnlPhoneNameContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImageContainer
            // 
            this.pnlImageContainer.Controls.Add(this.pibPhoneImage);
            this.pnlImageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImageContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlImageContainer.Name = "pnlImageContainer";
            this.pnlImageContainer.Size = new System.Drawing.Size(290, 261);
            this.pnlImageContainer.TabIndex = 5;
            // 
            // pibPhoneImage
            // 
            this.pibPhoneImage.Location = new System.Drawing.Point(20, 5);
            this.pibPhoneImage.Name = "pibPhoneImage";
            this.pibPhoneImage.Size = new System.Drawing.Size(250, 250);
            this.pibPhoneImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibPhoneImage.TabIndex = 0;
            this.pibPhoneImage.TabStop = false;
            this.pibPhoneImage.Click += new System.EventHandler(this.pibPhoneImage_Click);
            // 
            // pnlPhoneInfor
            // 
            this.pnlPhoneInfor.Controls.Add(this.pnlPhonePriceContainer);
            this.pnlPhoneInfor.Controls.Add(this.flpPhoneDetailContainer);
            this.pnlPhoneInfor.Controls.Add(this.pnlPhoneNameContainer);
            this.pnlPhoneInfor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPhoneInfor.Location = new System.Drawing.Point(0, 261);
            this.pnlPhoneInfor.Name = "pnlPhoneInfor";
            this.pnlPhoneInfor.Size = new System.Drawing.Size(290, 224);
            this.pnlPhoneInfor.TabIndex = 4;
            // 
            // pnlPhonePriceContainer
            // 
            this.pnlPhonePriceContainer.Controls.Add(this.lblCurrencyUnit);
            this.pnlPhonePriceContainer.Controls.Add(this.lblPhonePrice);
            this.pnlPhonePriceContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPhonePriceContainer.Location = new System.Drawing.Point(0, 179);
            this.pnlPhonePriceContainer.Name = "pnlPhonePriceContainer";
            this.pnlPhonePriceContainer.Size = new System.Drawing.Size(290, 45);
            this.pnlPhonePriceContainer.TabIndex = 7;
            // 
            // lblCurrencyUnit
            // 
            this.lblCurrencyUnit.AutoSize = true;
            this.lblCurrencyUnit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCurrencyUnit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyUnit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCurrencyUnit.Location = new System.Drawing.Point(261, 0);
            this.lblCurrencyUnit.Name = "lblCurrencyUnit";
            this.lblCurrencyUnit.Size = new System.Drawing.Size(29, 31);
            this.lblCurrencyUnit.TabIndex = 4;
            this.lblCurrencyUnit.Text = "đ";
            // 
            // lblPhonePrice
            // 
            this.lblPhonePrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhonePrice.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPhonePrice.Location = new System.Drawing.Point(52, 0);
            this.lblPhonePrice.Name = "lblPhonePrice";
            this.lblPhonePrice.Size = new System.Drawing.Size(210, 31);
            this.lblPhonePrice.TabIndex = 3;
            this.lblPhonePrice.Text = "15000000";
            this.lblPhonePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flpPhoneDetailContainer
            // 
            this.flpPhoneDetailContainer.Controls.Add(this.btnRAMInfor);
            this.flpPhoneDetailContainer.Controls.Add(this.btnMemoryInfor);
            this.flpPhoneDetailContainer.Controls.Add(this.btnBatteryInfor);
            this.flpPhoneDetailContainer.Controls.Add(this.btnChipInfor);
            this.flpPhoneDetailContainer.Controls.Add(this.btnOSInfor);
            this.flpPhoneDetailContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPhoneDetailContainer.Location = new System.Drawing.Point(0, 61);
            this.flpPhoneDetailContainer.Name = "flpPhoneDetailContainer";
            this.flpPhoneDetailContainer.Size = new System.Drawing.Size(290, 163);
            this.flpPhoneDetailContainer.TabIndex = 6;
            // 
            // btnRAMInfor
            // 
            this.btnRAMInfor.AutoSize = true;
            this.btnRAMInfor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRAMInfor.Enabled = false;
            this.btnRAMInfor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRAMInfor.Location = new System.Drawing.Point(10, 10);
            this.btnRAMInfor.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.btnRAMInfor.Name = "btnRAMInfor";
            this.btnRAMInfor.Size = new System.Drawing.Size(75, 32);
            this.btnRAMInfor.TabIndex = 0;
            this.btnRAMInfor.Text = "button1";
            this.btnRAMInfor.UseVisualStyleBackColor = false;
            // 
            // btnMemoryInfor
            // 
            this.btnMemoryInfor.AutoSize = true;
            this.btnMemoryInfor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMemoryInfor.Enabled = false;
            this.btnMemoryInfor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoryInfor.Location = new System.Drawing.Point(95, 10);
            this.btnMemoryInfor.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.btnMemoryInfor.Name = "btnMemoryInfor";
            this.btnMemoryInfor.Size = new System.Drawing.Size(75, 32);
            this.btnMemoryInfor.TabIndex = 1;
            this.btnMemoryInfor.Text = "button2";
            this.btnMemoryInfor.UseVisualStyleBackColor = false;
            // 
            // btnBatteryInfor
            // 
            this.btnBatteryInfor.AutoSize = true;
            this.btnBatteryInfor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBatteryInfor.Enabled = false;
            this.btnBatteryInfor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatteryInfor.Location = new System.Drawing.Point(180, 10);
            this.btnBatteryInfor.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.btnBatteryInfor.Name = "btnBatteryInfor";
            this.btnBatteryInfor.Size = new System.Drawing.Size(75, 32);
            this.btnBatteryInfor.TabIndex = 2;
            this.btnBatteryInfor.Text = "button3";
            this.btnBatteryInfor.UseVisualStyleBackColor = false;
            // 
            // btnChipInfor
            // 
            this.btnChipInfor.AutoSize = true;
            this.btnChipInfor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChipInfor.Enabled = false;
            this.btnChipInfor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChipInfor.Location = new System.Drawing.Point(10, 52);
            this.btnChipInfor.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.btnChipInfor.Name = "btnChipInfor";
            this.btnChipInfor.Size = new System.Drawing.Size(75, 32);
            this.btnChipInfor.TabIndex = 4;
            this.btnChipInfor.Text = "button5";
            this.btnChipInfor.UseVisualStyleBackColor = false;
            // 
            // btnOSInfor
            // 
            this.btnOSInfor.AutoSize = true;
            this.btnOSInfor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOSInfor.Enabled = false;
            this.btnOSInfor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOSInfor.Location = new System.Drawing.Point(95, 52);
            this.btnOSInfor.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.btnOSInfor.Name = "btnOSInfor";
            this.btnOSInfor.Size = new System.Drawing.Size(75, 32);
            this.btnOSInfor.TabIndex = 3;
            this.btnOSInfor.Text = "button4";
            this.btnOSInfor.UseVisualStyleBackColor = false;
            // 
            // pnlPhoneNameContainer
            // 
            this.pnlPhoneNameContainer.Controls.Add(this.lblPhoneName);
            this.pnlPhoneNameContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPhoneNameContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlPhoneNameContainer.Name = "pnlPhoneNameContainer";
            this.pnlPhoneNameContainer.Size = new System.Drawing.Size(290, 61);
            this.pnlPhoneNameContainer.TabIndex = 5;
            // 
            // lblPhoneName
            // 
            this.lblPhoneName.AutoEllipsis = true;
            this.lblPhoneName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPhoneName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhoneName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneName.Location = new System.Drawing.Point(0, 0);
            this.lblPhoneName.Name = "lblPhoneName";
            this.lblPhoneName.Padding = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.lblPhoneName.Size = new System.Drawing.Size(290, 61);
            this.lblPhoneName.TabIndex = 0;
            this.lblPhoneName.Text = "iPhone 15";
            // 
            // PhoneCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnlImageContainer);
            this.Controls.Add(this.pnlPhoneInfor);
            this.Margin = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.Name = "PhoneCardControl";
            this.Size = new System.Drawing.Size(290, 485);
            this.Load += new System.EventHandler(this.PhoneCardControl_Load);
            this.pnlImageContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibPhoneImage)).EndInit();
            this.pnlPhoneInfor.ResumeLayout(false);
            this.pnlPhonePriceContainer.ResumeLayout(false);
            this.pnlPhonePriceContainer.PerformLayout();
            this.flpPhoneDetailContainer.ResumeLayout(false);
            this.flpPhoneDetailContainer.PerformLayout();
            this.pnlPhoneNameContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImageContainer;
        private System.Windows.Forms.PictureBox pibPhoneImage;
        private System.Windows.Forms.Panel pnlPhoneInfor;
        private System.Windows.Forms.Panel pnlPhonePriceContainer;
        private System.Windows.Forms.Label lblCurrencyUnit;
        private System.Windows.Forms.Label lblPhonePrice;
        private System.Windows.Forms.FlowLayoutPanel flpPhoneDetailContainer;
        private System.Windows.Forms.Button btnRAMInfor;
        private System.Windows.Forms.Button btnMemoryInfor;
        private System.Windows.Forms.Button btnBatteryInfor;
        private System.Windows.Forms.Button btnChipInfor;
        private System.Windows.Forms.Button btnOSInfor;
        private System.Windows.Forms.Panel pnlPhoneNameContainer;
        private System.Windows.Forms.Label lblPhoneName;
    }
}
