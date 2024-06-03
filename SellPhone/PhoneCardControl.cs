using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellPhone
{
    public partial class PhoneCardControl : UserControl
    {
        private int phoneId;
        private string phoneName;
        private int phoneTypeId;
        private string phoneTypeName;
        private string phoneChip;
        private string phoneOS;
        private string phoneBattery;
        private string phoneRAM;
        private string phoneMemory;
        private int phonePrice;
        private string phoneColor;
        private string phoneBrand;
        private int phoneWarrantyTime;
        private Image phoneImage;

        public int PhoneId
        {
            get { return this.phoneId; }
            set { this.phoneId = value; }
        }
        public string PhoneName
        {
            get { return this.phoneName; }
            set { this.phoneName = value; }
        }
        public int PhoneTypeId
        {
            get { return this.phoneTypeId; }
            set { this.phoneTypeId = value; }
        }
        public string PhoneTypeName
        {
            get { return this.phoneTypeName; }
            set { this.phoneTypeName = value; }
        }
        public string PhoneChip
        {
            get { return this.phoneChip; }
            set { this.phoneChip = value; }
        }
        public string PhoneOS
        {
            get { return this.phoneOS; }
            set { this.phoneOS = value; }
        }
        public string PhoneBattery
        {
            get { return this.phoneBattery; }
            set { this.phoneBattery = value; }
        }
        public string PhoneRAM
        {
            get { return this.phoneRAM; }
            set { this.phoneRAM = value; }
        }
        public string PhoneMemory
        {
            get { return this.phoneMemory; }
            set { this.phoneMemory = value; }
        }
        public Image PhoneImage
        {
            get { return this.phoneImage; }
            set { this.phoneImage = value; }
        }
        public int PhonePrice
        {
            get { return this.phonePrice; }
            set { this.phonePrice = value; }
        }
        public string PhoneColor
        {
            get { return this.phoneColor; }
            set { this.phoneColor = value; }
        }
        public string PhoneBrand
        {
            get { return this.phoneBrand; }
            set { this.phoneBrand = value; }
        }
        public int PhoneWarrantyTime
        {
            get { return this.phoneWarrantyTime; }
            set { this.phoneWarrantyTime = value; }
        }
        public PhoneCardControl()
        {
            InitializeComponent();
        }
        public PhoneCardControl(int phoneId, string phoneName, string phoneChip, string phoneOS, string phoneBattery, string phoneRAM, string phoneMemory, int phonePrice, Image phoneImage)
        {
            this.phoneId = phoneId;
            this.phoneName = phoneName;
            this.phoneChip = phoneChip;
            this.phoneOS = phoneOS;
            this.phoneBattery = phoneBattery;
            this.phoneRAM = phoneRAM;
            this.phoneMemory = phoneMemory;
            this.phonePrice = phonePrice;
            this.phoneImage = phoneImage;
            InitializeComponent();
        }

        private void PhoneCardControl_Load(object sender, EventArgs e)
        {
            lblPhoneName.Text = this.phoneName;
            btnRAMInfor.Text = this.phoneRAM;
            btnMemoryInfor.Text = this.phoneMemory;
            btnChipInfor.Text = this.phoneChip;
            btnBatteryInfor.Text = this.phoneBattery;
            btnOSInfor.Text = this.phoneOS;
            lblPhonePrice.Text = this.phonePrice.ToString();
            pibPhoneImage.Image = this.phoneImage;
        }

        private void pibPhoneImage_Click(object sender, EventArgs e)
        {
            ViewPhoneDetail viewPhoneDetail = new ViewPhoneDetail(this.phoneId);
            viewPhoneDetail.ShowDialog();
        }

    }
}
