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
    public partial class PNReport : Form
    {
        public PNReport()
        {
            InitializeComponent();
        }
        DBConnecttion con = new DBConnecttion();
        private void PNReport_Load(object sender, EventArgs e)
        {
            string sql = "select * from V_DSPhieuNhap";
            con.connect();
            SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            rptPN rptPN = new rptPN();
            rptPN.SetDataSource(dt);
            this.crystalReportViewerPN.ReportSource = rptPN;
            con.close();
        }
    }
}
