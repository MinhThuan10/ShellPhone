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
    public partial class HDReport : Form
    {
        public HDReport()
        {
            InitializeComponent();
        }
        DBConnecttion con = new DBConnecttion();
        private void HDReport_Load(object sender, EventArgs e)
        {
            string sql = "select * from V_DSHoaDon";
            con.connect();
            SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            rptHD rptHD = new rptHD();
            rptHD.SetDataSource(dt);
            this.crystalReportViewerHD.ReportSource = rptHD;
            con.close();
        }
    }
}
