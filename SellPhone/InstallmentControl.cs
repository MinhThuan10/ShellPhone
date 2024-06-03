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
    public partial class InstallmentControl : UserControl
    {
        public InstallmentControl()
        {
            InitializeComponent();
        }
        DBConnecttion con = new DBConnecttion();
        private int maHD, maKH;
        private void selectHoaDon()
        {
            try
            {
                this.maHD = int.Parse(txtMaHD.Text);
            }
            catch
            {
                return;
            }
            
            //select hoa don
            DataTable dt = new DataTable();
            string sql = "select NgayMuaHang,TongGiaHD,MaKH from HoaDon where MaHD=@MaHD";
            try
            {
                if (DBConnecttion.conn.State == ConnectionState.Closed)
                {
                    DBConnecttion.conn.Open();
                }

                SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
                SqlParameter _maHD = new SqlParameter("@MaHD", SqlDbType.Int);
                _maHD.Value = maHD;
                cmd.Parameters.Add(_maHD);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    this.maKH = Convert.ToInt32(dt.Rows[0]["MaKH"]);
                    txtNgayMuaHang.Text = dt.Rows[0]["NgayMuaHang"].ToString();
                    txtTongGiaHD.Text = dt.Rows[0]["TongGiaHD"].ToString();
                }
                else
                {
                    MessageBox.Show("Mã Hóa Đơn Không Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                if (DBConnecttion.conn.State == ConnectionState.Open)
                {
                    DBConnecttion.conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void selectKhachHang()
        {
            try
            {
                this.maHD = int.Parse(txtMaHD.Text);
            }
            catch
            {
                return;
            }
            DataTable dt = new DataTable();
            string sql = "select HoTen,SDT from KhachHang where MaKH=@MaKH";
            try
            {
                if (DBConnecttion.conn.State == ConnectionState.Closed)
                {
                    DBConnecttion.conn.Open();
                }

                SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
                SqlParameter _maKH = new SqlParameter("@MaKH", SqlDbType.Int);
                _maKH.Value = this.maKH;
                cmd.Parameters.Add(_maKH);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                this.txtMaKH.Text = this.maKH.ToString();
                this.txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
                this.txtSDT.Text = dt.Rows[0]["SDT"].ToString();
                if (DBConnecttion.conn.State == ConnectionState.Open)
                {
                    DBConnecttion.conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void selectPhieuTG()
        {
            try
            {
                this.maHD = int.Parse(txtMaHD.Text);
            }
            catch
            {
                return;
            }
            DataTable dt = new DataTable();
            string sql = "select * from PhieuTG where MaHD=@MaHD";
            try
            {
                if (DBConnecttion.conn.State == ConnectionState.Closed)
                {
                    DBConnecttion.conn.Open();
                }

                SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
                SqlParameter _maHD = new SqlParameter("@MaHD", SqlDbType.Int);
                _maHD.Value = maHD;
                cmd.Parameters.Add(_maHD);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                if(dt.Rows.Count == 0) {
                    return;
                }
                int n = dt.Rows.Count;
                this.txtSoTienTT.Text = dt.Rows[n-1]["SoTienTT"].ToString();
                this.txtLaiSuat.Text = dt.Rows[n-1]["LaiSuat"].ToString();
                this.txtSoTienCL.Text = dt.Rows[n - 1]["SoTienCL"].ToString();
                this.txtSoTienTGHT.Text = dt.Rows[n-1]["SoTienTGHT"].ToString();
                DateTime NgayBatDau = (DateTime)dt.Rows[n-1]["NgayBatDau"];
                DateTime NgayDaoHan = (DateTime)dt.Rows[n-1]["NgayDaoHan"];
                this.dtNgayBatDau.Value = NgayBatDau;
                this.dtNgayDaoHan.Value = NgayDaoHan;
                int khoangCachThang = 0;

                for (DateTime ngayHienTai = NgayBatDau; ngayHienTai < NgayDaoHan; ngayHienTai = ngayHienTai.AddMonths(1))
                {
                    khoangCachThang++;
                }
                switch (khoangCachThang)
                {
                    case 3:
                        this.rabtn3.Checked = true;
                        break;
                    case 6:
                        this.rabtn6.Checked = true;
                        break;
                    case 12:
                        this.rabtn12.Checked = true;
                        break;
                    case 24:
                        this.rabtn24.Checked = true;
                        break;
                }
                this.txtSoTienTT.Enabled = false;
                this.gbGoiTraGop.Enabled = false;
                if (DBConnecttion.conn.State == ConnectionState.Open)
                {
                    DBConnecttion.conn.Close();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void thucHienTraGop()
        {
            try
            {
                if (DBConnecttion.conn.State == ConnectionState.Closed)
                {
                    con.connect();
                }
                SqlCommand comm = new SqlCommand("TraGop", DBConnecttion.conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@MaHD", SqlDbType.Int));
                comm.Parameters["@MaHD"].Value = int.Parse(this.txtMaHD.Text);
                comm.Parameters.Add(new SqlParameter("@SoTienTT", SqlDbType.Int));
                comm.Parameters["@SoTienTT"].Value = int.Parse(this.txtSoTienTT.Text);
                comm.Parameters.Add(new SqlParameter("@LaiSuat", SqlDbType.Real));
                comm.Parameters["@LaiSuat"].Value = float.Parse(this.txtLaiSuat.Text);
                comm.Parameters.Add(new SqlParameter("@NgayBatDau", SqlDbType.Date));
                comm.Parameters["@NgayBatDau"].Value = (DateTime)this.dtNgayBatDau.Value;
                comm.Parameters.Add(new SqlParameter("@NgayDaoHan", SqlDbType.Date));
                comm.Parameters["@NgayDaoHan"].Value = (DateTime)this.dtNgayDaoHan.Value;
                comm.ExecuteNonQuery();
                MessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTraGop_Click(object sender, EventArgs e)
        {
            thucHienTraGop();
            selectPhieuTG();
        }

        private void rabtn3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtLaiSuat.Text = "0.01";
                DateTime NgayBatDau = this.dtNgayBatDau.Value;
                DateTime NgayDaoHan = NgayBatDau.AddMonths(3);
                this.dtNgayDaoHan.Value = NgayDaoHan;
                int tongGiaHD = int.Parse(this.txtTongGiaHD.Text.ToString());
                float laiSuat = float.Parse(this.txtLaiSuat.Text.ToString());
                int soTienTT = int.Parse(this.txtSoTienTT.Text.ToString());
                int SoTienTGHT = (int)(tongGiaHD + tongGiaHD * laiSuat - soTienTT) / 3;
                this.txtSoTienTGHT.Text = SoTienTGHT.ToString();
            }
            catch
            {
                this.gbGoiTraGop.Enabled = false;
            }
           
        }

        private void rabtn6_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtLaiSuat.Text = "0.02";
                DateTime NgayBatDau = this.dtNgayBatDau.Value;
                DateTime NgayDaoHan = NgayBatDau.AddMonths(6);
                this.dtNgayDaoHan.Value = NgayDaoHan;
                int tongGiaHD = int.Parse(this.txtTongGiaHD.Text.ToString());
                float laiSuat = float.Parse(this.txtLaiSuat.Text.ToString());
                int soTienTT = int.Parse(this.txtSoTienTT.Text.ToString());
                int SoTienTGHT = (int)(tongGiaHD + tongGiaHD * laiSuat - soTienTT) / 6;
                this.txtSoTienTGHT.Text = SoTienTGHT.ToString();
            }
            catch
            {
                this.gbGoiTraGop.Enabled = false;
            }
            
        }

        private void rabtn12_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtLaiSuat.Text = "0.03";
                DateTime NgayBatDau = this.dtNgayBatDau.Value;
                DateTime NgayDaoHan = NgayBatDau.AddMonths(12);
                this.dtNgayDaoHan.Value = NgayDaoHan;
                int tongGiaHD = int.Parse(this.txtTongGiaHD.Text.ToString());
                float laiSuat = float.Parse(this.txtLaiSuat.Text.ToString());
                int soTienTT = int.Parse(this.txtSoTienTT.Text.ToString());
                int SoTienTGHT = (int)(tongGiaHD + tongGiaHD * laiSuat - soTienTT) / 12;
                this.txtSoTienTGHT.Text = SoTienTGHT.ToString();
            }
            catch
            {
                this.gbGoiTraGop.Enabled=false;
            }
            
        }

        private void rabtn24_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtLaiSuat.Text = "0.04";
                DateTime NgayBatDau = this.dtNgayBatDau.Value;
                DateTime NgayDaoHan = NgayBatDau.AddMonths(24);
                this.dtNgayDaoHan.Value = NgayDaoHan;
                int tongGiaHD = int.Parse(this.txtTongGiaHD.Text.ToString());
                float laiSuat = float.Parse(this.txtLaiSuat.Text.ToString());
                int soTienTT = int.Parse(this.txtSoTienTT.Text.ToString());
                int SoTienTGHT = (int)(tongGiaHD + tongGiaHD * laiSuat - soTienTT) / 24;
                this.txtSoTienTGHT.Text = SoTienTGHT.ToString();
            }
            catch { 
                this.gbGoiTraGop.Enabled= false;
            }
            
        }

        private void txtSoTienTT_TextChanged(object sender, EventArgs e)
        {
            this.gbGoiTraGop.Enabled = true;
            try
            {
                if(int.Parse(this.txtSoTienTT.Text) < 0)
                {
                    MessageBox.Show("Số tiền trả trước phải là số dương", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.gbGoiTraGop.Enabled = false;
                    return;
                }
                if (int.Parse(this.txtSoTienTT.Text) > int.Parse(this.txtTongGiaHD.Text))
                {
                    MessageBox.Show("Số tiền trả trước không được phép lớn hơn tổng giá hóa đơn","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.gbGoiTraGop.Enabled = false;
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Số tiền trả trước phải là số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.gbGoiTraGop.Enabled = false;
                return;
            }
            

        }

        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            selectHoaDon();
            selectKhachHang();
            selectPhieuTG();

        }
    }
}
