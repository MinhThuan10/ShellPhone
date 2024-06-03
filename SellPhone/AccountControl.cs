using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellPhone
{
    public partial class AccountControl : UserControl
    {
        public AccountControl()
        {
            InitializeComponent();
        }
        DBConnecttion con = new DBConnecttion();
        private void ResetTextBox()
        {
            this.cbAdmin.Checked = true;
            this.txtUserName.Text = null;
            this.txtPassword.Text = null;
        }
        public void delete_Account(string username)
        {
            if (DBConnecttion.conn.State == ConnectionState.Closed)
            {
                con.connect();
            }
            string sql = "DeleteAccount";
            SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
            cmd.CommandType= CommandType.StoredProcedure;
            SqlParameter _username = new SqlParameter("@username", SqlDbType.VarChar);
            _username.Value = username;
            cmd.Parameters.Add(_username);
            cmd.ExecuteNonQuery();
            if (DBConnecttion.conn.State == ConnectionState.Open)
            {
                con.close();
            }
        }
        public void add_Account()
        {
            if (DBConnecttion.conn.State == ConnectionState.Closed)
            {
                con.connect();
            }
            try
            {
                string sql = "CreateAccount";
                SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter _username = new SqlParameter("@username", SqlDbType.VarChar);
                _username.Value = this.txtUserName.Text;
                cmd.Parameters.Add(_username);

                SqlParameter _passwd = new SqlParameter("@passwd", SqlDbType.VarChar);
                _passwd.Value = this.txtPassword.Text;
                cmd.Parameters.Add(_passwd);

                SqlParameter _isAdmin = new SqlParameter("@isAdmin", SqlDbType.Bit);
                if (this.cbAdmin.Checked)
                {
                    _isAdmin.Value = true;
                }
                else if (this.cbStaff.Checked)
                {
                    _isAdmin.Value = false;
                }
                cmd.Parameters.Add(_isAdmin);

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            if (DBConnecttion.conn.State == ConnectionState.Open)
            {
                con.close();
            }
        }
        public void update_Account()
        {
            if (DBConnecttion.conn.State == ConnectionState.Closed)
            {
                con.connect();
            }
            try
            {
                string sql = "proc_ThayDoiMatKhau";
                SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter _username = new SqlParameter("@username", SqlDbType.VarChar);
                _username.Value = this.txtUserName.Text;
                cmd.Parameters.Add(_username);

                SqlParameter _passwd = new SqlParameter("@passwd", SqlDbType.VarChar);
                _passwd.Value = this.txtPassword.Text;
                cmd.Parameters.Add(_passwd);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (DBConnecttion.conn.State == ConnectionState.Open)
            {
                con.close();
            }
        }
        public void Load_Account()
        {
            if(DBConnecttion.conn.State == ConnectionState.Closed)
            {
                con.connect();
            }
            string sql = "select * from Account";
            SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvAccounts.DataSource = dt;
            if (DBConnecttion.conn.State == ConnectionState.Open)
            {
                con.close();
            }
        }
        private void AccountControl_Load(object sender, EventArgs e)
        {
            Load_Account();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            add_Account();
            ResetTextBox();
            Load_Account();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Load_Account();
            ResetTextBox();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            delete_Account(this.txtUserName.Text);
            ResetTextBox();
            Load_Account();
        }

        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtUserName.Text = dgvAccounts.CurrentRow.Cells["username"].Value.ToString();
                this.txtPassword.Text = dgvAccounts.CurrentRow.Cells["passwd"].Value.ToString();
                if ((bool)dgvAccounts.CurrentRow.Cells["isAdmin"].Value == true)
                {
                    this.cbAdmin.Checked = true;
                }
                else
                {
                    this.cbStaff.Checked = true;
                }
            }catch
            {
                return;
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            update_Account();
            ResetTextBox();
            Load_Account();
        }
    }
}
