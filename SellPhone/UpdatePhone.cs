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
    public partial class UpdatePhone : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        private int id;
        public UpdatePhone(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        public void DBConnection()
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=QLCHDT;Persist Security Info=True;User ID=sa;Password=8426");
        }
        public void Connect() { conn.Open(); }
        public void Disconect() { conn.Close(); }

        private void UpdatePhone_Load(object sender, EventArgs e)
        {
            DBConnection();
            Connect();
            string query = "select * from V_DSSanPham where MaSP = @id";
            SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
            _id.Value = id;
            SqlCommand comm = new SqlCommand(query, conn);
            comm.Parameters.Add(_id);
            SqlDataReader reader = comm.ExecuteReader();
            while(reader.Read())
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
                cbxPhoneId.Text = reader["MaSP"].ToString();
                txtPhoneName.Text = reader["TenSP"].ToString();
                txtPhoneMemory.Text = reader["BoNho"].ToString();
                txtPhoneColor.Text = reader["Mau"].ToString();
                txtPhoneQuantityRest.Text = reader["SoLuongCL"].ToString();
                txtPhonePrice.Text = reader["GiaBan"].ToString();
                Image phoneImage = ByteToImage((byte[])reader["Hinh"]);
                pibPhoneImage.Image = phoneImage;
            }
            //this.v_DSSanPhamTableAdapter.Fill(this.qLCHDTDataSet.V_DSSanPham);
            cbxPhoneId.Focus();
            cbxPhoneId.ResetText();           
            Disconect();

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
            if(dialogResult == DialogResult.OK)
            {
                this.Close();
                
            }
        }

        private void cbxPhoneId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connect();
            cmd = new SqlCommand("LayCotDSSanPham", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter maSP = new SqlParameter("@MaSP", SqlDbType.Int);
            maSP.Value = Convert.ToInt32(cbxPhoneId.Text);
            SqlParameter maLoai = new SqlParameter("@MaLoai", SqlDbType.Int);
            maLoai.Direction = ParameterDirection.Output;
            SqlParameter tenLoai = new SqlParameter("@TenLoai", SqlDbType.NVarChar, 100);
            tenLoai.Direction = ParameterDirection.Output;
            SqlParameter tgBH = new SqlParameter("@TGBH", SqlDbType.Int);
            tgBH.Direction = ParameterDirection.Output;
            SqlParameter pin = new SqlParameter("@Pin", SqlDbType.Char, 10);
            pin.Direction = ParameterDirection.Output;
            SqlParameter hdh = new SqlParameter("@HDH", SqlDbType.Char, 50);
            hdh.Direction = ParameterDirection.Output;
            SqlParameter ram = new SqlParameter("@RAM", SqlDbType.Char, 50);
            ram.Direction = ParameterDirection.Output;
            SqlParameter chip = new SqlParameter("@Chip", SqlDbType.Char, 50);
            chip.Direction = ParameterDirection.Output;
            SqlParameter hang = new SqlParameter("@Hang", SqlDbType.Char, 50);
            hang.Direction = ParameterDirection.Output;
            SqlParameter tenSP = new SqlParameter("@TenSP", SqlDbType.NVarChar, 100);
            tenSP.Direction = ParameterDirection.Output;
            SqlParameter boNho = new SqlParameter("@BoNho", SqlDbType.Char, 50);
            boNho.Direction = ParameterDirection.Output;
            SqlParameter mau = new SqlParameter("@Mau", SqlDbType.NVarChar, 14);
            mau.Direction = ParameterDirection.Output;
            SqlParameter soLuongCL = new SqlParameter("@SoLuongCL", SqlDbType.Int);
            soLuongCL.Direction = ParameterDirection.Output;
            SqlParameter giaBan = new SqlParameter("@GiaBan", SqlDbType.Int);
            giaBan.Direction = ParameterDirection.Output;
            SqlParameter maNCC = new SqlParameter("@MaNCC", SqlDbType.Int);
            maNCC.Direction = ParameterDirection.Output;
            SqlParameter tenNCC = new SqlParameter("@TenNCC", SqlDbType.NVarChar, 50);
            tenNCC.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(maSP);
            cmd.Parameters.Add(maLoai);
            cmd.Parameters.Add(tenLoai);
            cmd.Parameters.Add(tgBH);
            cmd.Parameters.Add(pin);
            cmd.Parameters.Add(hdh);
            cmd.Parameters.Add(ram);
            cmd.Parameters.Add(chip);
            cmd.Parameters.Add(hang);
            cmd.Parameters.Add(tenSP);
            cmd.Parameters.Add(boNho);
            cmd.Parameters.Add(mau);
            cmd.Parameters.Add(soLuongCL);
            cmd.Parameters.Add(giaBan);
            cmd.Parameters.Add(maNCC);
            cmd.Parameters.Add(tenNCC);

            cmd.ExecuteNonQuery();
            Disconect();

            try
            {
                txtPhoneTypeId.Text = maLoai.Value.ToString();
                txtPhoneTypeName.Text = tenLoai.Value.ToString().Trim();
                txtPhoneGuaranteeTime.Text = tgBH.Value.ToString();
                txtPhoneBattery.Text = pin.Value.ToString().Trim();
                txtPhoneOS.Text = hdh.Value.ToString().Trim();
                txtPhoneRAM.Text = ram.Value.ToString().Trim();
                txtPhoneChip.Text = chip.Value.ToString().Trim();
                txtPhoneBrand.Text = hang.Value.ToString().Trim();
                txtPhoneName.Text = tenSP.Value.ToString().Trim();
                txtPhoneMemory.Text = boNho.Value.ToString().Trim();
                txtPhoneColor.Text = mau.Value.ToString().Trim();
                txtPhoneQuantityRest.Text = soLuongCL.Value.ToString();
                txtPhonePrice.Text = giaBan.Value.ToString();
                txtPhoneProviderId.Text = maNCC.Value.ToString().Trim();
                txtPhoneProviderName.Text = tenNCC.Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void UpdatePhoneNameandImage(int phoneId, string phoneName, byte[] phoneImage)
        {
            Connect();
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
            cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(_phoneId);
            cmd.Parameters.Add(_phoneName);
            cmd.Parameters.Add(_phoneImage);
            cmd.ExecuteNonQuery();
            Disconect();
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
