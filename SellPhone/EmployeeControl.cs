using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellPhone
{
    public partial class EmployeeControl : UserControl
    {
        public EmployeeControl()
        {
            InitializeComponent();
        }

        DBConnecttion con = new DBConnecttion();

        public DataTable getDataFromSQL_NhanVien(string views)
        {
            DataTable dt = new DataTable();
            if (views != null)
            {
                string sql = "Select * from " + views;
                SqlDataAdapter adapter = new SqlDataAdapter(sql, DBConnecttion.conn);
                adapter.Fill(dt);

            }
            return dt;
        }
        private void ResetTextBox()
        {
            this.btn_modify.Enabled = false;
            this.btn_delete.Enabled = false;
            this.btn_cancel.Enabled = false;
            this.txt_MaNV.Text = null;
            this.txt_HoTen.Text = null;
            this.txt_SDT.Text = null;
            this.rdmale.Checked = true;
            this.txt_DiaChi.Text = null;
            this.datetimePicker_NgaySinh.Value = Convert.ToDateTime("1/1/1753");
            this.datetimePicker_NgayTuyenDung.Value = Convert.ToDateTime("1/1/1753");
        }
        public void delete_NhanVien(int maNV)
        {
            string sql = $"EXEC XoaNhanVien @MaNV = {maNV} ";
            SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
            cmd.ExecuteNonQuery();
        }
        public void LoadTable_NhanVien()
        {
            string views = "V_DSNhanVien";
            dtGridView_NhanVien.DataSource = getDataFromSQL_NhanVien(views);

        }

        private void EmployeeControl_Load(object sender, EventArgs e)
        {
            con.connect();
            this.dtGridView_NhanVien.DefaultCellStyle.SelectionBackColor = this.dtGridView_NhanVien.DefaultCellStyle.BackColor;
            this.dtGridView_NhanVien.DefaultCellStyle.SelectionForeColor = this.dtGridView_NhanVien.DefaultCellStyle.ForeColor;
            LoadTable_NhanVien();
            btn_modify.Enabled = false;
            btn_delete.Enabled = false;
            btn_cancel.Enabled = false;
            txt_MaNV.ReadOnly = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.dtGridView_NhanVien.DefaultCellStyle.SelectionBackColor = this.dtGridView_NhanVien.DefaultCellStyle.BackColor;
            this.dtGridView_NhanVien.DefaultCellStyle.SelectionForeColor = this.dtGridView_NhanVien.DefaultCellStyle.ForeColor;
            AddEmpl addemploy = new AddEmpl();
            this.ResetTextBox();
            addemploy.ShowDialog();
        }

        public void sua_NhanVien(int MaSV, string HoTen, string SDT, DateTime NgaySinh, int GioiTinh, DateTime NgayTuyenDung, string DiaChi)
        {
            if (DBConnecttion.conn.State == ConnectionState.Closed)
            {
                DBConnecttion.conn.Open();
            }
            try {
                string sql = $"EXEC CapNhatNhanVien @MaNV = {MaSV},@HoTen = N'{HoTen}', @SDT = '{SDT}', @NgaySinh = '{NgaySinh.ToString("yyyy/MM/dd")}', @GioiTinh = {GioiTinh}, @NgayTuyenDung = '{NgayTuyenDung.ToString("yyyy/MM/dd")}', @DiaChi = N'{DiaChi}'";
                SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } catch(Exception ex) {

                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
               
            

        }

        private void dtGridView_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_delete.Enabled = true;
            btn_cancel.Enabled = true;
            btn_modify.Enabled = true;
            try
            {
                this.dtGridView_NhanVien.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                this.dtGridView_NhanVien.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
                txt_MaNV.Text = dtGridView_NhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
                txt_HoTen.Text = dtGridView_NhanVien.CurrentRow.Cells["HoTen"].Value.ToString();
                txt_SDT.Text = dtGridView_NhanVien.CurrentRow.Cells["SDT"].Value.ToString();
                datetimePicker_NgaySinh.Value = Convert.ToDateTime(dtGridView_NhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString());
                
                if (dtGridView_NhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString() == "1")
                {
                    rdmale.Checked = true;
                }
                else
                {
                    rdfemale.Checked = true;
                }
                datetimePicker_NgayTuyenDung.Value = Convert.ToDateTime(dtGridView_NhanVien.CurrentRow.Cells["NgayTuyenDung"].Value.ToString());
                txt_DiaChi.Text = dtGridView_NhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();

               
            }
            catch
            {
                return;
            }
            
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.dtGridView_NhanVien.DefaultCellStyle.SelectionBackColor = this.dtGridView_NhanVien.DefaultCellStyle.BackColor;
            this.dtGridView_NhanVien.DefaultCellStyle.SelectionForeColor = this.dtGridView_NhanVien.DefaultCellStyle.ForeColor;
            this.ResetTextBox();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            delete_NhanVien(Convert.ToInt32(txt_MaNV.Text));
            this.dtGridView_NhanVien.DefaultCellStyle.SelectionBackColor = this.dtGridView_NhanVien.DefaultCellStyle.BackColor;
            this.dtGridView_NhanVien.DefaultCellStyle.SelectionForeColor = this.dtGridView_NhanVien.DefaultCellStyle.ForeColor;
            ResetTextBox();
            LoadTable_NhanVien();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            if (rdmale.Checked)
            {
                sua_NhanVien(Convert.ToInt32(txt_MaNV.Text), txt_HoTen.Text, txt_SDT.Text, datetimePicker_NgaySinh.Value, 1, datetimePicker_NgayTuyenDung.Value, txt_DiaChi.Text);
            }
            else
            {
                sua_NhanVien(Convert.ToInt32(txt_MaNV.Text), txt_HoTen.Text, txt_SDT.Text, datetimePicker_NgaySinh.Value, 0, datetimePicker_NgayTuyenDung.Value, txt_DiaChi.Text);
            }
            this.dtGridView_NhanVien.DefaultCellStyle.SelectionBackColor = this.dtGridView_NhanVien.DefaultCellStyle.BackColor;
            this.dtGridView_NhanVien.DefaultCellStyle.SelectionForeColor = this.dtGridView_NhanVien.DefaultCellStyle.ForeColor;
            this.ResetTextBox();
            LoadTable_NhanVien();
        }
        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {
            if (txt_SDT.Text.Length > 0 && !Regex.IsMatch(txt_SDT.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Số điện thoại phải là kiểu số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.dtGridView_NhanVien.DefaultCellStyle.SelectionBackColor = this.dtGridView_NhanVien.DefaultCellStyle.BackColor;
            this.dtGridView_NhanVien.DefaultCellStyle.SelectionForeColor = this.dtGridView_NhanVien.DefaultCellStyle.ForeColor;
            ResetTextBox();
            LoadTable_NhanVien();
        }
    }
}
