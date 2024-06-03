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
    public partial class EmployControl : UserControl
    {
        public EmployControl()
        {
            InitializeComponent();
        }
        SqlConnectionManager conn = new SqlConnectionManager();
        public void LoadTable_NhanVien()
        {
            string views = "V_DSNhanVien";
            dtGridView_NhanVien.DataSource = conn.getDataFromSQL_NhanVien(views);

        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            AddEmploy addemploy = new AddEmploy();
            addemploy.ShowDialog();
        }
        

        

        private void EmployControl_Load(object sender, EventArgs e)
        {
            conn.connect();
            LoadTable_NhanVien();
            btn_modify.Enabled = false;
            btn_delete.Enabled = false;
            btn_cancel.Enabled = false;
            txt_MaNV.ReadOnly = true;
        }

        private void dtGridView_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = -1;
            DataTable tb = new DataTable();
            tb = (DataTable)dtGridView_NhanVien.DataSource;
            index = dtGridView_NhanVien.SelectedCells[0].RowIndex;
            DataRow row = tb.Rows[index];

            txt_MaNV.Text = row["MaNV"].ToString(); 
            txt_HoTen.Text = row["HoTen"].ToString();
            txt_SDT.Text = row["SDT"].ToString();
            datetimePicker_NgaySinh.Value = Convert.ToDateTime(row["NgaySinh"].ToString());
            txt_GioiTinh.Text = row["GioiTinh"].ToString();
            datetimePicker_NgayTuyenDung.Value = Convert.ToDateTime(row["NgayTuyenDung"].ToString());
            txt_DiaChi.Text = row["DiaChi"].ToString() ;

            btn_delete.Enabled = true;
            btn_cancel.Enabled = true;
            btn_modify.Enabled = true;
            
        }

        private void dtGridView_NhanVien_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dtGridView_NhanVien_CellContentClick(sender, e);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_MaNV.Text = "";
            txt_HoTen.Text = "";
            txt_SDT.Text = "";
            txt_GioiTinh.Text = "";
            txt_DiaChi.Text = "";
            datetimePicker_NgaySinh.Value = Convert.ToDateTime("1/1/1753");
            datetimePicker_NgayTuyenDung.Value = Convert.ToDateTime("1/1/1753");
            btn_modify.Enabled = false;
            btn_delete.Enabled = false;
            btn_cancel.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            conn.delete_NhanVien(Convert.ToInt32(txt_MaNV.Text));
            btn_modify.Enabled = false;
            btn_delete.Enabled = false;
            btn_cancel.Enabled = false;
            txt_MaNV.Text = "";
            txt_HoTen.Text = "";
            txt_SDT.Text = "";
            txt_GioiTinh.Text = "";
            txt_DiaChi.Text = "";
            datetimePicker_NgaySinh.Value = Convert.ToDateTime("1/1/1753");
            datetimePicker_NgayTuyenDung.Value = Convert.ToDateTime("1/1/1753");
            LoadTable_NhanVien();
        }
    }
}
