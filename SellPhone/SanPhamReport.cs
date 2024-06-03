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
    public partial class SanPhamReport : Form
    {
        public SanPhamReport()
        {
            InitializeComponent();
        }
        DBConnecttion con = new DBConnecttion();
        private void SanPhamReport_Load(object sender, EventArgs e)
        {
            string sql = "select * from SanPham";
            con.connect();
            SqlCommand cmd = new SqlCommand(sql, DBConnecttion.conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            rptSanPham rptSanPham = new rptSanPham();
            rptSanPham.SetDataSource(dt);
            this.crystalReportViewerSanPham.ReportSource = rptSanPham;
            con.close();
        }
    }
}
