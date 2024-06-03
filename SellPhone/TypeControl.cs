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
    public partial class TypeControl : UserControl
    {

        private int id;
        public TypeControl()
        {
            InitializeComponent();
        }

        DBConnecttion con = new DBConnecttion();

private void loadData()
{
    string sql = "select * from LoaiSP";
    SqlCommand comm = new SqlCommand(sql, DBConnecttion.conn);
    SqlDataAdapter adapter = new SqlDataAdapter(comm);
    DataTable dt = new DataTable();
    adapter.Fill(dt);
    dgView.DataSource = dt;
}
        private void ResetTextBox()
        {
            this.typeInp.Text = null;
            this.OSInp.Text = null;
            this.timeInp.Text = null;
            this.pinInp.Text = null;
            this.chipInp.Text = null;
            this.RAMInp.Text = null;
            this.brandInp.Text = null;  
        }
        private void TypeControl_Load(object sender, EventArgs e)
        {
            this.dgView.DefaultCellStyle.SelectionBackColor = this.dgView.DefaultCellStyle.BackColor;
            this.dgView.DefaultCellStyle.SelectionForeColor = this.dgView.DefaultCellStyle.ForeColor;
            this.loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ResetTextBox();
            AddType addType = new AddType();
            addType.ShowDialog();
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
                ModifyType modifyType = new ModifyType(id);
                modifyType.ShowDialog();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if(DBConnecttion.conn.State == ConnectionState.Closed)
                {
                    con.connect();
                }
                if(id == 0)
                {
                    return;
                }
                SqlCommand comm = new SqlCommand("XoaLoaiSP", DBConnecttion.conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@MaLoai", SqlDbType.Int));
                comm.Parameters["@MaLoai"].Value = this.id;
                comm.ExecuteNonQuery();
                MessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.loadData();
                this.ResetTextBox();
                if (this.dgView.RowCount > 1)
                {
                    this.dgView.SelectedCells[0].Selected = false;
                }
                con.close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                this.dgView.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                this.dgView.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
                this.id = int.Parse(dgView.CurrentRow.Cells["MaLoai"].Value.ToString());
                typeInp.Text = dgView.CurrentRow.Cells["TenLoai"].Value.ToString();
                OSInp.Text = dgView.CurrentRow.Cells["HDH"].Value.ToString();
                timeInp.Text = dgView.CurrentRow.Cells["TGBH"].Value.ToString();
                pinInp.Text = dgView.CurrentRow.Cells["Pin"].Value.ToString();
                chipInp.Text = dgView.CurrentRow.Cells["Chip"].Value.ToString();
                RAMInp.Text = dgView.CurrentRow.Cells["RAM"].Value.ToString();
                brandInp.Text = dgView.CurrentRow.Cells["Hang"].Value.ToString();
            } catch
            {
                return;
            }
            
        }

        private void btnrpt_Click(object sender, EventArgs e)
        {
            TypeReport typeReport = new TypeReport();
            typeReport.ShowDialog();
        }
    }
}
