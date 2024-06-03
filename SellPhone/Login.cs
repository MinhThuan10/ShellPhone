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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DBConnecttion con = new DBConnecttion();
        private void btn__login_Click(object sender, EventArgs e)
        {

            string user = this.txt_account.Text;
            string password = this.txt_password.Text;
            if(DBConnecttion.conn.State == ConnectionState.Closed) { 
                con.connect();
            }
            DataTable dt = new DataTable();
            string sql = "select * from Account where username = @username";
            SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
            SqlParameter _username = new SqlParameter("@username", SqlDbType.VarChar);
            _username.Value = user;
            cmd.Parameters.Add(_username);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            if(dt.Rows.Count > 0 )
            {
                if (dt.Rows[0]["passwd"].ToString() == password)
                {
                    string strConnect = $"Data Source=.;Initial Catalog=QLCHDT;User ID={user};Password={password}";
                    DBConnecttion.conn = new SqlConnection(strConnect);
                    if ((bool)dt.Rows[0]["isAdmin"] == true)
                    {
                        Admin adminControl = new Admin();
                        adminControl.ShowDialog();
                    }
                    else
                    {
                        User userControl = new User();
                        userControl.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Password không đúng!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("UserName không tồn tại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (DBConnecttion.conn.State == ConnectionState.Open)
            {
                con.close();
            }
        }
    }
}
