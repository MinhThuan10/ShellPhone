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
    public partial class InsertPhonee : Form
    {
        SqlCommand cmd;
        public InsertPhonee()
        {
            InitializeComponent();
        }

        DBConnecttion con = new DBConnecttion();
        public void FillPhoneTypeComboBox()
        {
            string query = "SELECT MaLoai FROM LoaiSP";
            cmd = new SqlCommand(query, DBConnecttion.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbxPhoneTypeId.Items.Add(reader["MaLoai"].ToString());
            }
            reader.Close();
        }
        public void FillPhoneProviderIdComboBox()
        {
            string query = "SELECT MaNCC FROM NCC";
            cmd = new SqlCommand(query, DBConnecttion.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbxPhoneProviderId.Items.Add(reader["MaNCC"].ToString());
            }
            reader.Close();
        }
        public void FillEmployeeIdComboBox()
        {
            string query = "SELECT MaNV FROM NhanVien";
            cmd = new SqlCommand(query, DBConnecttion.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbxEmployeeId.Items.Add(reader["MaNV"].ToString());
            }
            reader.Close();
        }
        private void InsertPhonee_Load(object sender, EventArgs e)
        {
            con.connect();
            cbxPhoneTypeId.ResetText();
            cbxPhoneProviderId.ResetText();
            cbxEmployeeId.ResetText();
            FillEmployeeIdComboBox();
            FillPhoneProviderIdComboBox();
            FillPhoneTypeComboBox();
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

        private void cbxPhoneProviderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.connect();
                cmd = new SqlCommand("LayCotNCC", DBConnecttion.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter maNCC = new SqlParameter("@MaNCC", SqlDbType.Int);
                maNCC.Value = Convert.ToInt32(cbxPhoneProviderId.Text);

                SqlParameter tenNCC = new SqlParameter("@TenNCC", SqlDbType.NVarChar, 50);
                tenNCC.Direction = ParameterDirection.Output;

                SqlParameter diaChi = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 100);
                diaChi.Direction = ParameterDirection.Output;

                SqlParameter email = new SqlParameter("@Email", SqlDbType.Char, 50);
                email.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(maNCC);
                cmd.Parameters.Add(tenNCC);
                cmd.Parameters.Add(diaChi);
                cmd.Parameters.Add(email);

                cmd.ExecuteNonQuery();
                txtPhoneProviderName.Text = tenNCC.Value.ToString();
                con.close();
            }
            catch
            {
                return;
            }
            
        }

        private void cbxEmployeeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.connect();
                cmd = new SqlCommand("LayCotNhanVien", DBConnecttion.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter maNV = new SqlParameter("@MaNV", SqlDbType.Int);
                maNV.Value = Convert.ToInt32(cbxEmployeeId.Text);
                SqlParameter hoTen = new SqlParameter("@HoTen", SqlDbType.NVarChar, 50);
                hoTen.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(hoTen);
                cmd.Parameters.Add(maNV);
                cmd.ExecuteNonQuery();
                txtEmployeeName.Text = hoTen.Value.ToString();
                con.close();
            }
            catch { return; }
            
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
            cbxPhoneTypeId.Text = null;
            txtPhoneTypeName.Text = null;
            txtPhoneBrand.Text = null;
            txtPhoneOS.Text = null;
            txtPhoneRAM.Text = null;
            txtPhoneGuaranteeTime.Text = null;
            txtPhoneChip.Text = null;
            txtPhoneBattery.Text = null;
            cbxPhoneProviderId.Text = null;
            txtPhoneProviderName.Text = null;
            cbxEmployeeId.Text = null;
            txtEmployeeName.Text = null;
            txtPhoneName.Text = null;
            cbxPhoneMemory.Text = null;
            cbxPhoneColor.Text = null;
            txtPhoneQuantity.Text = null;
            txtPhoneHistoricalCost.Text = "";
            txtPhonePrice.Text = null;
            pibPhoneImage.Image = null;
        }

        public void AddNewPhone(int maLoai, int maNCC, string tenSP, string boNho, byte[] hinh, string mau, int maNV, int giaGoc, int soLuong)
        {
            con.connect();
            cmd = new SqlCommand("TaoPhieuNhap", DBConnecttion.conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter _maLoai = new SqlParameter("@MaLoai", SqlDbType.Int);
            _maLoai.Value = maLoai;
            SqlParameter _maNCC = new SqlParameter("@MaNCC", SqlDbType.Int);
            _maNCC.Value = maNCC;
            SqlParameter _tenSP = new SqlParameter("@TenSP", SqlDbType.NVarChar, 100);
            _tenSP.Value = tenSP;
            SqlParameter _boNho = new SqlParameter("@BoNho", SqlDbType.Char, 50);
            _boNho.Value = boNho;
            SqlParameter _mau = new SqlParameter("@Mau", SqlDbType.NVarChar, 50);
            _mau.Value = mau;
            SqlParameter _maNV = new SqlParameter("@MaNV", SqlDbType.Int);
            _maNV.Value = maNV;
            SqlParameter _giaGoc = new SqlParameter("@GiaGoc", SqlDbType.Int);
            _giaGoc.Value = giaGoc;
            SqlParameter _soLuong = new SqlParameter("@TongSL", SqlDbType.Int);
            _soLuong.Value = soLuong;
            SqlParameter _soLuongConLai = new SqlParameter("@SoLuongCL", SqlDbType.Int);
            _soLuongConLai.Value = 0;
            SqlParameter _hinh = new SqlParameter("@Hinh", SqlDbType.Image);
            _hinh.Value = hinh;
            if (hinh == null)
            {
                _hinh.Value = DBNull.Value;
            }

            cmd.Parameters.Add(_maLoai);
            cmd.Parameters.Add(_maNCC);
            cmd.Parameters.Add(_tenSP);
            cmd.Parameters.Add(_boNho);
            cmd.Parameters.Add(_mau);
            cmd.Parameters.Add(_giaGoc);
            cmd.Parameters.Add(_soLuong);
            cmd.Parameters.Add(_maNV);
            cmd.Parameters.Add(_hinh);
            cmd.ExecuteNonQuery();
            con.close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                int maLoai = Convert.ToInt32(cbxPhoneTypeId.Text);
                int maNCC = Convert.ToInt32(cbxPhoneProviderId.Text);
                string tenSP = txtPhoneName.Text.Trim();
                string boNho = cbxPhoneMemory.Text.Trim();
                Image phoneImage = pibPhoneImage.Image;
                byte[] hinh = ImageToByte(phoneImage);
                string mau = cbxPhoneColor.Text.Trim();
                int maNV = Convert.ToInt32(cbxEmployeeId.Text);
                int giaGoc = Convert.ToInt32(txtPhoneHistoricalCost.Text);
                int soLuong = Convert.ToInt32(txtPhoneQuantity.Text);
                AddNewPhone(maLoai, maNCC, tenSP, boNho, hinh, mau, maNV, giaGoc, soLuong);
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                if (msg.Contains("string"))
                {
                    msg = "Giá trị 'Số lượng' phải là số";
                }
                else if (msg.Contains("Check_ChiTietPN_GiaGoc"))
                {
                    msg = "Giá trị 'Giá gốc' phải là số dương";
                }
                else if (msg.Contains("Check_ChiTietPN_TongSL"))
                {
                    msg = "Giá trị 'Số lượng' phải là số dương";
                }
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPhoneHistoricalCost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double phonePrice = Convert.ToDouble(txtPhoneHistoricalCost.Text);
                phonePrice *= 1.25;
                txtPhonePrice.Text = phonePrice.ToString();
            }
            catch (Exception ex)
            {
                if(txtPhoneHistoricalCost.Text.Length > 0)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    return;
                }
            }
        }

        private void cbxPhoneTypeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.connect();
                cmd = new SqlCommand("LayCotLoaiSP", DBConnecttion.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter maLoai = new SqlParameter("@MaLoai", SqlDbType.Int);
                maLoai.Value = Convert.ToInt32(cbxPhoneTypeId.Text);

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

                cmd.Parameters.Add(maLoai);
                cmd.Parameters.Add(tenLoai);
                cmd.Parameters.Add(tgBH);
                cmd.Parameters.Add(pin);
                cmd.Parameters.Add(hdh);
                cmd.Parameters.Add(ram);
                cmd.Parameters.Add(chip);
                cmd.Parameters.Add(hang);

                cmd.ExecuteNonQuery();

                txtPhoneTypeName.Text = tenLoai.Value.ToString();
                txtPhoneBrand.Text = hang.Value.ToString();
                txtPhoneOS.Text = hdh.Value.ToString();
                txtPhoneRAM.Text = ram.Value.ToString();
                txtPhoneChip.Text = chip.Value.ToString();
                txtPhoneBattery.Text = pin.Value.ToString();
                txtPhoneGuaranteeTime.Text = tgBH.Value.ToString();
                con.close();
            }
            catch
            {
                return;
            }
            
        }
    }
}
