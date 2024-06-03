using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SellPhone
{
    public partial class BillControl: UserControl
    {
        public BillControl()
        {
            InitializeComponent();
        }

        DBConnecttion con = new DBConnecttion();
        public List<PhoneInBillControl> phoneInBills = new List<PhoneInBillControl>();
        public void insertBill()
        {
             if (DBConnecttion.conn.State == ConnectionState.Closed)
             {
                DBConnecttion.conn.Open();
             }
            string sql = "TaoHoaDon";
            DateTime NgayMua = DateTime.Now;
            foreach (var phoneInBill in phoneInBills)
            {
                try
                {
                   
                    SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter HoTen = new SqlParameter("@HoTen", SqlDbType.NVarChar);
                    HoTen.Value = txtHoTen.Text.ToString();


                    SqlParameter SDT = new SqlParameter("@SDT", SqlDbType.Char);
                    SDT.Value = txtSDT.Text;


                    SqlParameter CCCD = new SqlParameter("@CCCD", SqlDbType.Char);
                    CCCD.Value = txtCCCD.Text;


                    SqlParameter MaNV = new SqlParameter("@MaNV", SqlDbType.Int);
                    MaNV.Value = int.Parse(txtMaNV.Text);


                    SqlParameter PhuongThucTT = new SqlParameter("@PhuongThucTT", SqlDbType.Int);
                    if (cbPhuongThucTT.Checked)
                    {
                        PhuongThucTT.Value = 0;
                    }
                    else
                    {
                        PhuongThucTT.Value = 1;
                    }


                    SqlParameter NgayMuaHang = new SqlParameter("@NgayMuaHang", SqlDbType.DateTime);
                    NgayMuaHang.Value = NgayMua;

                    SqlParameter MaSP = new SqlParameter("@MaSP", SqlDbType.Int);
                    SqlParameter TongSL = new SqlParameter("@TongSL", SqlDbType.Int);

                    MaSP.Value = phoneInBill.PhoneID;
                    TongSL.Value = phoneInBill.SoLuong;

                    SqlParameter TienGiamGia = new SqlParameter("@TienGiamGia",SqlDbType.Int);
                    TienGiamGia.Value = this.txtGiamGia.Text;
                    cmd.Parameters.Add(TienGiamGia);

                    cmd.Parameters.Add(HoTen);
                    cmd.Parameters.Add(SDT);
                    cmd.Parameters.Add(CCCD);
                    cmd.Parameters.Add(MaNV);
                    cmd.Parameters.Add(PhuongThucTT);
                    cmd.Parameters.Add(NgayMuaHang);
                    cmd.Parameters.Add(MaSP);
                    cmd.Parameters.Add(TongSL);
                    cmd.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            if (DBConnecttion.conn.State == ConnectionState.Open)
            {
                DBConnecttion.conn.Close();
            }
        }
        public void TongGiaHoaDon()
        {
            int sumBill = 0;
            foreach (var phoneInBill in phoneInBills)
            {
                con.connect();
                string sql = "select GiaBan from SanPham where MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(sql,DBConnecttion.conn);
                cmd.CommandType = CommandType.Text;
                SqlParameter _MaSP  = new SqlParameter("@MaSP",SqlDbType.Int);
                _MaSP.Value = phoneInBill.PhoneID;
                cmd.Parameters.Add(_MaSP);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                sumBill += phoneInBill.SoLuong * (int)dt.Rows[0]["GiaBan"];
                con.close();
                
                
            }
            this.txtTongGia.Text = sumBill.ToString();
        }
        public void LoadPhone()
        {
            flowLayoutPanelPhone.Controls.Clear();
            foreach(var phoneInBill in phoneInBills)
            {
                flowLayoutPanelPhone.Controls.Add(phoneInBill);
               
            }
        }
        public void LoadBill()
        {
            DataTable dt = new DataTable();
            string sql = "select * from HoaDon";
            try
            {
                if (DBConnecttion.conn.State == ConnectionState.Closed)
                {
                    DBConnecttion.conn.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dgvHoaDon.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (int.Parse(txtSDT.Text.ToString()) <= 0)
                    {
                        MessageBox.Show("Số điện thoại phải là số dương!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Số điện thoại phải là số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    if (Int64.Parse(txtCCCD.Text.ToString()) <= 0)
                    {
                        MessageBox.Show("Số căn cước công dân phải là số dương!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Số căn cước công dân phải là số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(phoneInBills.Count > 0)
                {
                    insertBill();
                    User.billControl.phoneInBills.Clear();
                    flowLayoutPanelPhone.Controls.Clear();
                    LoadBill();
                    MessageBox.Show("Thêm Hóa Đơn Thành Công!", "Thông báo");
                }
                else
                {
                    return;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void BillControl_Load(object sender, EventArgs e)
        {
            LoadBill();
            LoadPhone();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            BillControl_Load(sender, e);
            TongGiaHoaDon();
            try
            {
                this.txtThanhTien.Text = (int.Parse(this.txtTongGia.Text) - int.Parse(this.txtGiamGia.Text)).ToString();
            }
            catch
            {
                return;
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            try
            {
                string sdt = this.txtSDT.Text.ToString();
                string sql = "select * from KhachHang where SDT = @SDT";
                SqlCommand cmd = new SqlCommand(sql,DBConnecttion.conn);
                SqlParameter _SDT = new SqlParameter("@SDT", SqlDbType.Char);
                _SDT.Value = sdt;
                cmd.Parameters.Add(_SDT);
                SqlDataAdapter adapter= new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); 
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    this.txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
                    this.txtCCCD.Text = dt.Rows[0]["CCCD"].ToString();
                    this.txtGiamGia.Text = ((int)dt.Rows[0]["DiemTichLuy"] * 1000).ToString();
                }
                else
                {
                    this.txtGiamGia.Text = "0";
                    return;
                }
                
            }
            catch (Exception ex)
            {
                if(this.txtSDT.Text.Length > 0)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    return;
                }
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (this.txtSDT.Text.Contains("+"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCCCD.Text.Contains("+"))
            {
                MessageBox.Show("Số căn cước công dân không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
