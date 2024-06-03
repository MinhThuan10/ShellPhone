using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellPhone
{
    public partial class PhoneInBillControl : UserControl
    {
        public PhoneInBillControl()
        {
            InitializeComponent();
        }
        DBConnecttion con = new DBConnecttion();
        private int phoneID;
        private string phoneName;
        private int soLuong;

        public int PhoneID
        {
            get { return phoneID; }
            set { this.phoneID = value; }
        }
        public string PhoneName
        {
            get { return phoneName; }
            set { this.phoneName = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { this.soLuong = value; }
        }
        public PhoneInBillControl(int phoneID)
        {
            this.phoneID = phoneID;
            LoadPhone();
            InitializeComponent();
        }

        private void lblPhoneName_Click(object sender, EventArgs e)
        {
            ViewPhoneDetail viewPhoneDetail = new ViewPhoneDetail(this.phoneID);
            viewPhoneDetail.ShowDialog();
        }
        private void LoadPhone() 
        {
            con.connect();
            string query = "select TenSP from SanPham where MaSP = @id";
            SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
            _id.Value = this.phoneID;
            SqlCommand comm = new SqlCommand(query, DBConnecttion.conn);
            comm.Parameters.Add(_id);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                this.PhoneName = reader["TenSP"].ToString();
            }
            con.close();
        }
        private void PhoneInBillControl_Load(object sender, EventArgs e)
        {
            LoadPhone();
            lblPhoneName.Text = this.PhoneName;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            User.billControl.phoneInBills.Remove(this);
            User.billControl.LoadPhone();
        }

        private void txtSoLuong_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.soLuong = int.Parse(txtSoLuong.Text.ToString());
            }
            catch
            {
                if(txtSoLuong.Text.Length > 0)
                {
                    MessageBox.Show("Số lượng phải là số","Warning",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
