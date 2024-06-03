using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellPhone
{
    public partial class ViewPhoneDetail : Form
    {
        SqlCommand cmd;
        private int phoneId;
        public ViewPhoneDetail()
        {
            InitializeComponent();
        }
        public ViewPhoneDetail(int phoneId)
        {
            InitializeComponent();
            this.phoneId = phoneId;
        }
        DBConnecttion con = new DBConnecttion();

        private void ViewPhoneDetail_Load(object sender, EventArgs e)
        {
            con.connect();
            string query = "select * from V_DSSanPham where MaSP = @id";
            SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
            _id.Value = phoneId;
            SqlCommand comm = new SqlCommand(query, DBConnecttion.conn);
            comm.Parameters.Add(_id);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                lblPhoneName.Text = reader["TenSP"].ToString();
                lblPhoneTypeInfor.Text = reader["TenLoai"].ToString();
                lblPhoneChipInfor.Text = reader["Chip"].ToString();
                lblPhoneOSInfor.Text = reader["HDH"].ToString();
                lblPhoneBatteryInfor.Text = reader["Pin"].ToString();
                lblPhoneRAMInfor.Text = reader["RAM"].ToString();
                lblPhoneMemoryInfor.Text = reader["BoNho"].ToString();
                lblPhoneColorInfor.Text = reader["Mau"].ToString();
                lblPhoneWarrantyTimeInfor.Text = reader["TGBH"].ToString() + " năm";
                lblPhoneBrandInfor.Text = reader["Hang"].ToString();
                lblPhonePrice.Text = reader["GiaBan"].ToString();
                lblPhoneSL.Text = reader["SoLuongCL"].ToString();
                if (reader["Hinh"] != null && reader["Hinh"] != DBNull.Value)
                {
                    Image phoneImage = ByteToImage((byte[])reader["Hinh"]);
                    pibPhoneImage.Image = phoneImage;
                }
            }
            con.close();
        }
        public Image ByteToImage(byte[] data)
        {
            try
            {
                using (var ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                PhoneInBillControl phoneInBillControl = new PhoneInBillControl(this.phoneId);
                bool isExit = false;
                foreach (var phone in User.billControl.phoneInBills)
                {
                    if (phone.PhoneID == phoneInBillControl.PhoneID) {
                        isExit = true;
                    }
                }
                if(!isExit)
                {
                    User.billControl.phoneInBills.Add(phoneInBillControl);
                    MessageBox.Show("Thêm sản phẩm vào hóa đơn thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sản phẩm đã tồn tại trong hóa đơn", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
               
            }
            catch
            {
                MessageBox.Show("Thêm sản phẩm vào hóa đơn thất bại", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
