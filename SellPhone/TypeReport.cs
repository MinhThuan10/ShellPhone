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
    public partial class TypeReport : Form
    {
        public TypeReport()
        {
            InitializeComponent();
        }
        DBConnecttion con = new DBConnecttion();
        private void TypeReport_Load(object sender, EventArgs e)
        {
            string sql = "select * from LoaiSP";
            con.connect();
            SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            rptType rptType = new rptType();
            rptType.SetDataSource(dt);
            this.crystalReportViewerType.ReportSource = rptType;
            con.close();
        }
    }
}
