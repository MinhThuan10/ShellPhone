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
    public partial class BrandControl : UserControl
    {
        private int id;
        public BrandControl()
        {
            InitializeComponent();
        }

        DBConnecttion con = new DBConnecttion();
        private void ResetTextBox()
        {
            this.nameInp.Text = null;
            this.emailInp.Text = null;
            this.addressInp.Text = null;

        }
        private void loadData()
        {
            string sql = "select * from NCC";
            SqlCommand comm = new SqlCommand(sql, DBConnecttion.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgView.DataSource = dataTable;
        }

        private void BrandControl_Load(object sender, EventArgs e)
        {
           
            this.dgView.DefaultCellStyle.SelectionBackColor = this.dgView.DefaultCellStyle.BackColor;
            this.dgView.DefaultCellStyle.SelectionForeColor = this.dgView.DefaultCellStyle.ForeColor;
            this.loadData();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.ResetTextBox();
            AddNCC addNCC = new AddNCC();
            addNCC.ShowDialog();
            this.dgView.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ResetTextBox();
            this.loadData();
            if (this.dgView.RowCount > 1)
            {
                this.dgView.ClearSelection();
                id = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                ModifyNCC modifyNCC = new ModifyNCC(id);
                modifyNCC.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (DBConnecttion.conn.State == ConnectionState.Closed)
                {
                    con.connect();
                }
                if(this.id == 0)
                {
                    return;
                }
                SqlCommand comm = new SqlCommand("XoaNhaCungCap", DBConnecttion.conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@MaNCC", SqlDbType.Int));
                comm.Parameters["@MaNCC"].Value = this.id;
                comm.ExecuteNonQuery();
                MessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.loadData();
                this.ResetTextBox();
                if (this.dgView.RowCount > 1)
                {
                    this.dgView.SelectedCells[0].Selected = false;
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.dgView.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                this.dgView.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
                this.id = int.Parse(dgView.CurrentRow.Cells["MaNCC"].Value.ToString());
                nameInp.Text = dgView.CurrentRow.Cells["TenNCC"].Value.ToString();
                addressInp.Text = dgView.CurrentRow.Cells["DiaChi"].Value.ToString();
                emailInp.Text = dgView.CurrentRow.Cells["Email"].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void btnrpt_Click(object sender, EventArgs e)
        {
            NCCReport nCCReport = new NCCReport();
            nCCReport.Show();
        }
    }
}
