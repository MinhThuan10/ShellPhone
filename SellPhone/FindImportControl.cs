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
    public partial class FindImportControl : UserControl
    {
        public FindImportControl()
        {
            InitializeComponent();
        }

        DBConnecttion con = new DBConnecttion();

        private void FindImportControl_Load(object sender, EventArgs e)
        {
            for(int i = 1;i <= 12;i++)
            {
                monthInp.Items.Add(i);
            }
            monthInp.Text = "1";
            yearInp.Text = "2023";
            radioButton1.Checked = true;
            checkBoxDay.Checked = true; 
        }

        private void checkBoxDay_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxDay.Checked)
            {
                checkBoxMonth.Checked = false; 
                checkBoxYear.Checked = false;
                checkBoxQ.Checked = false;
            }
        }

        private void checkBoxMonth_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxMonth.Checked)
            {
                checkBoxYear.Checked = true;
                checkBoxQ.Checked = false;
                checkBoxDay.Checked = false;
            }
        }

        private void checkBoxYear_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxYear.Checked)
            {
                checkBoxDay.Checked = false;
            }
        }

        private void checkBoxQ_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxQ.Checked)
            {
                checkBoxMonth.Checked = false;
                checkBoxYear.Checked = true;
                checkBoxDay.Checked = false;
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            DBConnecttion.conn.Open();
            SqlCommand comm = null;
            if(checkBoxDay.Checked)
            {
                comm = new SqlCommand("LocPhieuNhap_TheoNgay", DBConnecttion.conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date));
                comm.Parameters["@Ngay"].Value = dayInp.Value;
            } else if(checkBoxMonth.Checked)
            {
                comm = new SqlCommand("LocPhieuNhap_TheoThang", DBConnecttion.conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@Thang", SqlDbType.Int));
                comm.Parameters["@Thang"].Value = monthInp.Text;
                comm.Parameters.Add(new SqlParameter("@Nam", SqlDbType.Int));
                comm.Parameters["@Nam"].Value = yearInp.Text;
            } else if(checkBoxQ.Checked)
            {
                comm = new SqlCommand("LocPhieuNhap_TheoQuy", DBConnecttion.conn);
                comm.CommandType = CommandType.StoredProcedure;
                int quy = 1;
                if(radioButton2.Checked)
                {
                    quy = 2;
                } else if(radioButton3.Checked)
                {
                    quy = 3;
                } else if(radioButton4.Checked)
                {
                    quy = 4;
                }
                comm.Parameters.Add(new SqlParameter("@Quy", SqlDbType.Int));
                comm.Parameters["@Quy"].Value = quy;
                comm.Parameters.Add(new SqlParameter("@Nam", SqlDbType.Int));
                comm.Parameters["@Nam"].Value = yearInp.Text;
            } else if(checkBoxYear.Checked)
            {
                comm = new SqlCommand("LocPhieuNhap_TheoNam", DBConnecttion.conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@Nam", SqlDbType.Int));
                comm.Parameters["@Nam"].Value = yearInp.Text;
            }
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgImport.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void btnrpt_Click(object sender, EventArgs e)
        {
            PNReport pNReport = new PNReport();
            pNReport.ShowDialog();
        }
    }
}
