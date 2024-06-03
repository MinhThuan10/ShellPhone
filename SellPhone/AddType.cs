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
    public partial class AddType : Form
    {
        public AddType()
        {
            InitializeComponent();
        }
        DBConnecttion con = new DBConnecttion();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(DBConnecttion.conn.State== ConnectionState.Closed) { 
                    con.connect();
                }
                SqlCommand comm = new SqlCommand("ThemLoaiSP", DBConnecttion.conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@TenLoai", SqlDbType.NVarChar));
                comm.Parameters["@TenLoai"].Value = typeInp.Text;
                comm.Parameters.Add(new SqlParameter("@TGBH", SqlDbType.Int));
                comm.Parameters["@TGBH"].Value = int.Parse(timeInp.Text);
                comm.Parameters.Add(new SqlParameter("@Pin", SqlDbType.Char));
                comm.Parameters["@Pin"].Value = pinInp.Text;
                comm.Parameters.Add(new SqlParameter("@HDH", SqlDbType.Char));
                comm.Parameters["@HDH"].Value = OSInp.Text;
                comm.Parameters.Add(new SqlParameter("@RAM", SqlDbType.Char));
                comm.Parameters["@RAM"].Value = RAMInp.Text;
                comm.Parameters.Add(new SqlParameter("@Chip", SqlDbType.Char));
                comm.Parameters["@Chip"].Value = chipInp.Text;
                comm.Parameters.Add(new SqlParameter("@Hang", SqlDbType.Char));
                comm.Parameters["@Hang"].Value = brandInp.Text;
                comm.ExecuteNonQuery();
                MessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.close();
            } catch(Exception ex)
            {
                string msg = ex.Message;
                if (msg.Contains("Check_LoaiSP_TGBH"))
                {
                    msg = "Giá trị 'thời gian bảo hành' phải lớn hơn 0";
                }
                else if (msg.Contains("string"))
                {
                    msg = "Giá trị 'thời gian bảo hành' phải là số";
                }
                MessageBox.Show(msg, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
