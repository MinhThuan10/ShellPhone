using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhone
{
    internal class SqlConnectionManager
    {
        public SqlConnection conn = new SqlConnection("Data Source=LONGNGUYEN;Initial Catalog=HeQuanTriCSDL-CuaHangDienThoai;Integrated Security=True");

        public void connect()
        {
            conn.Open();
        }

        public void close()
        {
            conn.Close();
        }

        public DataTable getDataFromSQL_NhanVien(string views)
        {
            DataTable dt = new DataTable();
            if (views != null)
            {
                string sql = "Select * from " + views ;
                SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
                adapter.Fill(dt);

            }
            return dt;
        }
        public void delete_NhanVien(int maNV)
        {
            string sql = $"EXEC XoaNhanVien @MaNV = {maNV} ";
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
        }
        public void add_NhanVien(string HoTen, string SDT, DateTime NgaySinh, int GioiTinh, DateTime NgayTuyenDung, string DiaChi)
        {
            string sql = $"EXEC ThemNhanVien @HoTen = N'{HoTen}', @SDT = {SDT}, @NgaySinh = {NgaySinh}, @GioiTinh = {GioiTinh}, @NgayTuyenDung = {NgayTuyenDung}, @DiaChi = N'{DiaChi}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
