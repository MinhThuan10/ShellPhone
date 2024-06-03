using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SellPhone
{
    public partial class Chart : UserControl
    {
        public Chart()
        {
            InitializeComponent();
        }
        DBConnecttion con = new DBConnecttion();
        private void LoadDoanhThu()
        {
            int NamBD = int.Parse(this.txtNamBD.Text.ToString());
            if (rdtMonth.Checked)
            {
                if(NamBD <= 0)
                {
                    MessageBox.Show("Dữ liệu truyền vào không hợp lệ, vui lòng xem xét lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Danh sách tổng thu theo tháng
                string sql = "XemDSDoanhThu_TheoThang";
               
                con.connect();
                SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter _NamBD = new SqlParameter("@Nam", SqlDbType.Int);
                _NamBD.Value = NamBD;
                cmd.Parameters.Add(_NamBD);

                SqlDataAdapter adapter= new SqlDataAdapter(cmd);
                DataTable dt= new DataTable();
                adapter.Fill(dt);
                


                //Danh sách tổng chi theo tháng
                string sql_Chi = "XemDSTongChi_TheoThang";
               
                SqlCommand cmd_Chi = new SqlCommand(sql_Chi, DBConnecttion.conn);
                cmd_Chi.CommandType = CommandType.StoredProcedure;

                SqlParameter _NamBD_Chi = new SqlParameter("@Nam", SqlDbType.Int);
                _NamBD_Chi.Value = NamBD;
                cmd_Chi.Parameters.Add(_NamBD_Chi);

                SqlDataAdapter adapter_Chi = new SqlDataAdapter(cmd_Chi);
                DataTable dt_Chi = new DataTable();
                adapter_Chi.Fill(dt_Chi);

                if (!chartDoanhThu.Series.Any(s => s.Name == "TongThu"))
                {
                    // Chuỗi "TongThu" chưa tồn tại trong danh sách, thêm nó vào
                    chartDoanhThu.Series.Add("TongThu");
                }
                if (!chartDoanhThu.Series.Any(s => s.Name == "TongChi"))
                {
                    // Chuỗi "TongThu" chưa tồn tại trong danh sách, thêm nó vào
                    chartDoanhThu.Series.Add("TongChi");
                }
                chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh Thu";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chartDoanhThu.Series["TongThu"].Points.AddXY(dt.Rows[i]["Thang"], dt.Rows[i]["TongThu"]);
                   
                }
                for (int i = 0; i < dt_Chi.Rows.Count; i++)
                {
                    
                    chartDoanhThu.Series["TongChi"].Points.AddXY(dt_Chi.Rows[i]["Thang"], dt_Chi.Rows[i]["TongChi"]);
                }

                con.close();


            }
            else if (rdtYear.Checked)
            {
                int NamKT = int.Parse(this.txtNamKT.Text.ToString());
                if (NamBD <= 0 || NamKT <= 0)
                {
                    MessageBox.Show("Dữ liệu truyền vào không hợp lệ, vui lòng xem xét lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Danh sách tổng thu theo năm
                string sql = "XemDSDoanhThu_TheoNam";

                con.connect();
                SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter _NamBD = new SqlParameter("@NamBD", SqlDbType.Int);
                _NamBD.Value = NamBD;
                cmd.Parameters.Add(_NamBD);

                SqlParameter _NamKT = new SqlParameter("@NamKT", SqlDbType.Int);
                _NamKT.Value = NamKT;
                cmd.Parameters.Add(_NamKT);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                //Danh sách tổng chi theo năm
                string sql_Chi = "XemDSTongChi_TheoNam";

                SqlCommand cmd_Chi = new SqlCommand(sql_Chi, DBConnecttion.conn);
                cmd_Chi.CommandType = CommandType.StoredProcedure;

                SqlParameter _NamBD_Chi = new SqlParameter("@NamBD", SqlDbType.Int);
                _NamBD_Chi.Value = NamBD;
                cmd_Chi.Parameters.Add(_NamBD_Chi);

                SqlParameter _NamKT_Chi = new SqlParameter("@NamKT", SqlDbType.Int);
                _NamKT_Chi.Value = NamKT;
                cmd_Chi.Parameters.Add(_NamKT_Chi);

                SqlDataAdapter adapter_Chi = new SqlDataAdapter(cmd_Chi);
                DataTable dt_Chi = new DataTable();
                adapter_Chi.Fill(dt_Chi);

                if (!chartDoanhThu.Series.Any(s => s.Name == "TongThu"))
                {
                    // Chuỗi "TongThu" chưa tồn tại trong danh sách, thêm nó vào
                    chartDoanhThu.Series.Add("TongThu");
                }
                if (!chartDoanhThu.Series.Any(s => s.Name == "TongChi"))
                {
                    // Chuỗi "TongThu" chưa tồn tại trong danh sách, thêm nó vào
                    chartDoanhThu.Series.Add("TongChi");
                }
                chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Năm";
                chartDoanhThu.ChartAreas["ChartArea1"].AxisY.Title = "Doanh Thu";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chartDoanhThu.Series["TongThu"].Points.AddXY(dt.Rows[i]["Nam"], dt.Rows[i]["TongThu"]);

                }
                for (int i = 0; i < dt_Chi.Rows.Count; i++)
                {

                    chartDoanhThu.Series["TongChi"].Points.AddXY(dt_Chi.Rows[i]["Nam"], dt_Chi.Rows[i]["TongChi"]);
                }

                con.close();

            }
        }
        private void Chart_Load(object sender, EventArgs e)
        {
            if (chartDoanhThu.Series.IndexOf("Series1") != -1)
            {
                // Xóa series có tên "Series1" nếu nó tồn tại
                chartDoanhThu.Series.Remove(chartDoanhThu.Series["Series1"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu của tất cả các series trong Chart
            foreach (var series in chartDoanhThu.Series)
            {
                series.Points.Clear();
            }
            // Xóa tất cả các series trong Chart
            chartDoanhThu.Series.Clear();

            
            try
            {
                LoadDoanhThu();
            }
            catch {
                MessageBox.Show("Dữ liệu truyền vào không hợp lệ, vui lòng xem xét lại","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void rdtMonth_CheckedChanged(object sender, EventArgs e)
        {
            lblNamBD.Text = "Năm";
            txtNamKT.Visible = false;
            lblNamKT.Visible = false;
        }

        private void rdtYear_CheckedChanged(object sender, EventArgs e)
        {
            lblNamBD.Text = "Năm Bắt Đầu";
            txtNamKT.Visible = true;
            lblNamKT.Visible = true;
        }
    }
}
