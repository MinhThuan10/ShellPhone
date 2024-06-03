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
    public partial class AddNCC : Form
    {
        public AddNCC()
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
             
                SqlCommand comm = new SqlCommand("ThemNhaCungCap", DBConnecttion.conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@TenNCC", SqlDbType.NVarChar));
                comm.Parameters["@TenNCC"].Value = nameInp.Text;
                comm.Parameters.Add(new SqlParameter("@DiaChi", SqlDbType.NVarChar));
                comm.Parameters["@DiaChi"].Value = addressInp.Text;
                comm.Parameters.Add(new SqlParameter("@Email", SqlDbType.Char));
                comm.Parameters["@Email"].Value = emailInp.Text;
                comm.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.close();
            } catch(Exception ex) { 
           
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show("Bạn có muốn thoát!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
