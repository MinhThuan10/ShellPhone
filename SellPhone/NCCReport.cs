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
    public partial class NCCReport : Form
    {
        public NCCReport()
        {
            InitializeComponent();
        }
        DBConnecttion con = new DBConnecttion();
        private void NCCReport_Load(object sender, EventArgs e)
        {
            string sql = "select * from NCC";
            con.connect();
            SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
            DataTable dt = new DataTable(); 
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            rptNCC rptNCC = new rptNCC();
            rptNCC.SetDataSource(dt);
            this.crystalReportViewerNCC.ReportSource = rptNCC;
            con.close();
        }
    }
}
