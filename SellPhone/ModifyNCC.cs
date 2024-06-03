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
    public partial class ModifyNCC : Form
    {
        private int id;
        public ModifyNCC(int id)
        {
            InitializeComponent();
            this.id = id;   
        }

        DBConnecttion con = new DBConnecttion();

        private void ModifyNCC_Load(object sender, EventArgs e)
        {
            if(DBConnecttion.conn.State == ConnectionState.Closed)
            {
                con.connect();
            }
            try {
                string sql = "select * from NCC where MaNCC = @id";
                SqlParameter _id = new SqlParameter("@id", SqlDbType.Int);
                _id.Value = id;
                SqlCommand comm = new SqlCommand(sql, DBConnecttion.conn);
                comm.Parameters.Add(_id);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    nameInp.Text = reader["TenNCC"].ToString();
                    addressInp.Text = reader["DiaChi"].ToString();
                    emailInp.Text = reader["Email"].ToString();
                }
                reader.Close();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
            con.close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(DBConnecttion.conn.State == ConnectionState.Closed)
                {
                    con.connect();
                }
                SqlCommand comm = new SqlCommand("SuaNhaCungCap", DBConnecttion.conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@MaNCC", SqlDbType.Int));
                comm.Parameters["@MaNCC"].Value = id;
                comm.Parameters.Add(new SqlParameter("@TenNCC", SqlDbType.NVarChar));
                comm.Parameters["@TenNCC"].Value = nameInp.Text;
                comm.Parameters.Add(new SqlParameter("@DiaChi", SqlDbType.NVarChar));
                comm.Parameters["@DiaChi"].Value = addressInp.Text;
                comm.Parameters.Add(new SqlParameter("@Email", SqlDbType.Char));
                comm.Parameters["@Email"].Value = emailInp.Text;
                comm.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.close();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
