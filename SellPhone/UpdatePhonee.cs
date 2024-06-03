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
    public partial class UpdatePhonee : Form
    {
        SqlCommand cmd;
        private int id;
        public UpdatePhonee(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        DBConnecttion con = new DBConnecttion();

        private void UpdatePhonee_Load(object sender, EventArgs e)
        {
            con.connect();
            string query = "select * from V_DSSanPham where MaSP = @id";
            SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
            _id.Value = id;
            SqlCommand comm = new SqlCommand(query, DBConnecttion.conn);
            comm.Parameters.Add(_id);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                txtPhoneTypeId.Text = reader["MaLoai"].ToString();
                txtPhoneTypeName.Text = reader["TenLoai"].ToString();
                txtPhoneBrand.Text = reader["Hang"].ToString();
                txtPhoneOS.Text = reader["HDH"].ToString();
                txtPhoneRAM.Text = reader["RAM"].ToString();
                txtPhoneBattery.Text = reader["Pin"].ToString();
                txtPhoneGuaranteeTime.Text = reader["TGBH"].ToString();
                txtPhoneChip.Text = reader["Chip"].ToString();
                txtPhoneProviderId.Text = reader["MaNCC"].ToString();
                txtPhoneProviderName.Text = reader["TenNCC"].ToString();
                txtPhoneName.Text = reader["TenSP"].ToString();
                txtPhoneMemory.Text = reader["BoNho"].ToString();
                txtPhoneColor.Text = reader["Mau"].ToString();
                txtPhoneQuantityRest.Text = reader["SoLuongCL"].ToString();
                txtPhonePrice.Text = reader["GiaBan"].ToString();
                if(reader["Hinh"] != null && reader["Hinh"] != DBNull.Value)
                {
                    Image phoneImage = ByteToImage((byte[])reader["Hinh"]);
                    pibPhoneImage.Image = phoneImage;
                }
            }
            con.close();
        }

        public byte[] ImageToByte(Image image)
        {
            try
            {
                if (image == null)
                {
                    return null;
                }
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
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

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.ico|All Files|*.*";
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                pibPhoneImage.ImageLocation = openImage.FileName;
                openImage.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Hủy bỏ tất cả thay đổi?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();

            }
        }

        public void UpdatePhoneNameandImage(int phoneId, string phoneName, byte[] phoneImage)
        {
            con.connect();
            String query = "UPDATE V_DSSanPham SET TenSP = @TenSP, Hinh = @Hinh WHERE MaSP = @MaSP";
            SqlParameter _phoneId = new SqlParameter("@MaSP", SqlDbType.Int);
            _phoneId.Value = phoneId;
            SqlParameter _phoneName = new SqlParameter("@TenSP", SqlDbType.NVarChar, 100);
            _phoneName.Value = phoneName;
            SqlParameter _phoneImage = new SqlParameter("@Hinh", SqlDbType.Image);
            _phoneImage.Value = phoneImage;
            if (phoneImage == null)
            {
                _phoneImage.Value = DBNull.Value;
            }
            cmd = new SqlCommand(query, DBConnecttion.conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(_phoneId);
            cmd.Parameters.Add(_phoneName);
            cmd.Parameters.Add(_phoneImage);
            cmd.ExecuteNonQuery();
            con.close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int phoneId = id;
                string phoneName = txtPhoneName.Text.Trim();
                Image _phoneImage = pibPhoneImage.Image;
                byte[] phoneImage = ImageToByte(_phoneImage);
                UpdatePhoneNameandImage(phoneId, phoneName, phoneImage);
                MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
