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
    public partial class ViewThuAndChi : UserControl
    {
        public ViewThuAndChi()
        {
            InitializeComponent();
        }

        DBConnecttion con = new DBConnecttion();

        private void checkBoxDay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDay.Checked)
            {
                checkBoxMonth.Checked = false;
                checkBoxYear.Checked = false;
                checkBoxQ.Checked = false;
            }
        }

        private void checkBoxMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMonth.Checked)
            {
                checkBoxYear.Checked = true;
                checkBoxQ.Checked = false;
                checkBoxDay.Checked = false;
            }
        }

        private void checkBoxYear_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYear.Checked)
            {
                checkBoxDay.Checked = false;
            }
        }

        private void checkBoxQ_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ.Checked)
            {
                checkBoxMonth.Checked = false;
                checkBoxYear.Checked = true;
                checkBoxDay.Checked = false;
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            if(DBConnecttion.conn.State == ConnectionState.Closed)
            {
                DBConnecttion.conn.Open();
            }
            SqlCommand comm = null;
            SqlCommand comm2 = null;
            SqlCommand comm3 = null;
            SqlCommand comm4 = null;
            if (checkBoxDay.Checked)
            {
                comm = new SqlCommand("LocDoanhThu_TheoNgay", DBConnecttion.conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm3 = new SqlCommand("LocChi_TheoNgay", DBConnecttion.conn);
                comm3.CommandType = CommandType.StoredProcedure;
                comm2 = new SqlCommand("XemDoanhThu_TheoNgay", DBConnecttion.conn);
                comm2.CommandType = CommandType.StoredProcedure;
                comm4 = new SqlCommand("XemChi_TheoNgay", DBConnecttion.conn);
                comm4.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date));
                comm.Parameters["@Ngay"].Value = dayInp.Value;
                comm2.Parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date));
                comm2.Parameters["@Ngay"].Value = dayInp.Value;
                comm3.Parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date));
                comm3.Parameters["@Ngay"].Value = dayInp.Value;
                comm4.Parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date));
                comm4.Parameters["@Ngay"].Value = dayInp.Value;
            }
            else if (checkBoxMonth.Checked)
            {
                comm = new SqlCommand("LocDoanhThu_TheoThang", DBConnecttion.conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm3 = new SqlCommand("LocChi_TheoThang", DBConnecttion.conn);
                comm3.CommandType = CommandType.StoredProcedure;
                comm2 = new SqlCommand("XemDoanhThu_TheoThang", DBConnecttion.conn);
                comm2.CommandType = CommandType.StoredProcedure;
                comm4 = new SqlCommand("XemChi_TheoThang", DBConnecttion.conn);
                comm4.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@Thang", SqlDbType.Int));
                comm.Parameters["@Thang"].Value = monthInp.Text;
                comm.Parameters.Add(new SqlParameter("@Nam", SqlDbType.Int));
                comm.Parameters["@Nam"].Value = yearInp.Text;
                comm2.Parameters.Add(new SqlParameter("@Thang", SqlDbType.Int));
                comm2.Parameters["@Thang"].Value = monthInp.Text;
                comm2.Parameters.Add(new SqlParameter("@Nam", SqlDbType.Int));
                comm2.Parameters["@Nam"].Value = yearInp.Text;
                comm3.Parameters.Add(new SqlParameter("@Thang", SqlDbType.Int));
                comm3.Parameters["@Thang"].Value = monthInp.Text;
                comm3.Parameters.Add(new SqlParameter("@Nam", SqlDbType.Int));
                comm3.Parameters["@Nam"].Value = yearInp.Text;
                comm4.Parameters.Add(new SqlParameter("@Thang", SqlDbType.Int));
                comm4.Parameters["@Thang"].Value = monthInp.Text;
                comm4.Parameters.Add(new SqlParameter("@Nam", SqlDbType.Int));
                comm4.Parameters["@Nam"].Value = yearInp.Text;
            }
            else if (checkBoxQ.Checked)
            {
                comm = new SqlCommand("LocDoanhThu_TheoQuy", DBConnecttion.conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm3 = new SqlCommand("LocChi_TheoQuy", DBConnecttion.conn);
                comm3.CommandType = CommandType.StoredProcedure;
                comm2 = new SqlCommand("XemDoanhThu_TheoQuy", DBConnecttion.conn);
                comm2.CommandType = CommandType.StoredProcedure;
                comm4 = new SqlCommand("XemChi_TheoQuy", DBConnecttion.conn);
                comm4.CommandType = CommandType.StoredProcedure;
                int quy = 1;
                if (radioButton2.Checked)
                {
                    quy = 2;
                }
                else if (radioButton3.Checked)
                {
                    quy = 3;
                }
                else if (radioButton4.Checked)
                {
                    quy = 4;
                }
                comm.Parameters.Add(new SqlParameter("@Quy", SqlDbType.Int));
                comm.Parameters["@Quy"].Value = quy;
                comm.Parameters.Add(new SqlParameter("@Nam", SqlDbType.Int));
                comm.Parameters["@Nam"].Value = yearInp.Text;
                comm2.Parameters.Add(new SqlParameter("@Quy", SqlDbType.Int));
                comm2.Parameters["@Quy"].Value = quy;
                comm2.Parameters.Add(new SqlParameter("@Nam", SqlDbType.Int));
                comm2.Parameters["@Nam"].Value = yearInp.Text;
                comm3.Parameters.Add(new SqlParameter("@Quy", SqlDbType.Int));
                comm3.Parameters["@Quy"].Value = quy;
                comm3.Parameters.Add(new SqlParameter("@Nam", SqlDbType.Int));
                comm3.Parameters["@Nam"].Value = yearInp.Text;
                comm4.Parameters.Add(new SqlParameter("@Quy", SqlDbType.Int));
                comm4.Parameters["@Quy"].Value = quy;
                comm4.Parameters.Add(new SqlParameter("@Nam", SqlDbType.Int));
                comm4.Parameters["@Nam"].Value = yearInp.Text;
            }
            else if (checkBoxYear.Checked)
            {
                comm = new SqlCommand("LocDoanhThu_TheoNam", DBConnecttion.conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm3 = new SqlCommand("LocChi_TheoNam", DBConnecttion.conn);
                comm3.CommandType = CommandType.StoredProcedure;
                comm2 = new SqlCommand("XemDoanhThu_TheoNam", DBConnecttion.conn);
                comm2.CommandType = CommandType.StoredProcedure;
                comm4 = new SqlCommand("XemChi_TheoNam", DBConnecttion.conn);
                comm4.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@Nam", SqlDbType.Int));
                comm.Parameters["@Nam"].Value = int.Parse(yearInp.Text.ToString());
                comm2.Parameters.Add(new SqlParameter("@Nam", SqlDbType.Int));
                comm2.Parameters["@Nam"].Value = int.Parse(yearInp.Text.ToString());
                comm3.Parameters.Add(new SqlParameter("@Nam", SqlDbType.Int));
                comm3.Parameters["@Nam"].Value = int.Parse(yearInp.Text.ToString());
                comm4.Parameters.Add(new SqlParameter("@Nam", SqlDbType.Int));
                comm4.Parameters["@Nam"].Value = int.Parse(yearInp.Text.ToString());
            }
           
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            SqlDataAdapter adapter2 = new SqlDataAdapter(comm3);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            adapter.Fill(dt);
            adapter2.Fill(dt2);
            dgViewThu.DataSource = dt;
            dgViewChi.DataSource = dt2;
            SqlParameter tongThu = new SqlParameter("@TongThu", SqlDbType.Money);
            tongThu.Direction = ParameterDirection.ReturnValue;
            comm2.Parameters.Add(tongThu);
            SqlParameter tongChi = new SqlParameter("@TongChi", SqlDbType.Money);
            tongChi.Direction = ParameterDirection.ReturnValue;
            comm4.Parameters.Add(tongChi);
            comm2.ExecuteNonQuery();
            comm4.ExecuteNonQuery();
            sumThu.Text = tongThu.Value.ToString();
            sumChi.Text = tongChi.Value.ToString();
            if (dt.Rows.Count == 0 && dt2.Rows.Count == 0)
            {
                MessageBox.Show("Không có kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sumThu.Text = "";
                sumChi.Text = "";
            }
            DBConnecttion.conn.Close();
        }

        private void refeshBtn_Click(object sender, EventArgs e)
        {
            monthInp.Text = "1";
            yearInp.Text = "2023";
            radioButton1.Checked = true;
            checkBoxDay.Checked = true;
            checkBoxMonth.Checked = false;
            checkBoxYear.Checked = false;
            checkBoxQ.Checked = false;
            sumThu.Text = "";
            sumChi.Text = "";
        }

        private void ViewThuAndChi_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                monthInp.Items.Add(i);
            }
            monthInp.Text = "1";
            yearInp.Text = "2023";
            radioButton1.Checked = true;
            checkBoxDay.Checked = true;
        }
    }
}
