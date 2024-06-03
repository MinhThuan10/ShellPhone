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
    public partial class AddEmpl : Form
    {
        public AddEmpl()
        {
            InitializeComponent();
        }

        DBConnecttion con = new DBConnecttion();

        public void add_NhanVien(string HoTen, string SDT, DateTime NgaySinh, int GioiTinh, DateTime NgayTuyenDung, string DiaChi)
        {
            if (DBConnecttion.conn.State == ConnectionState.Closed)
            {
                DBConnecttion.conn.Open();
            }
            try {
                string sql = $"EXEC ThemNhanVien @HoTen = N'{HoTen}', @SDT = '{SDT}', @NgaySinh = '{NgaySinh.ToString("yyyy/MM/dd")}', @GioiTinh = {GioiTinh}, @NgayTuyenDung = '{NgayTuyenDung.ToString("yyyy/MM/dd")}', @DiaChi = N'{DiaChi}'";
                SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch(Exception ex) {

                MessageBox.Show(ex.Message,
                    "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(rdmale.Checked)
            {
                add_NhanVien(txt_HoTen.Text, txt_SDT.Text, datetimePicker_NgaySinh.Value, 1, datetimePicker_NgayTuyenDung.Value, txt_DiaChi.Text);

            }
            else
            {
                add_NhanVien(txt_HoTen.Text, txt_SDT.Text, datetimePicker_NgaySinh.Value, 0, datetimePicker_NgayTuyenDung.Value, txt_DiaChi.Text);
            }
        }
    }
}
