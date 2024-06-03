using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellPhone
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        static public BillControl billControl = new BillControl();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DBConnecttion con = new DBConnecttion();
        private void User_Load(object sender, EventArgs e)
        {
            if(DBConnecttion.conn.State == ConnectionState.Closed)
            {
                con.connect();
            }
            dt = selectPhone(9);
            LoadPhone(dt);

            string query = "SELECT TenLoai FROM LoaiSP";
            SqlCommand comm = new SqlCommand(query, DBConnecttion.conn);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                typePhoneComboBox.Items.Add(reader.GetString(0));
            }
            reader.Close();
            query = "SELECT Hang FROM LoaiSP";
            comm = new SqlCommand(query, DBConnecttion.conn);
            reader = comm.ExecuteReader();
            List<string> manu = new List<string>();
            while (reader.Read())
            {
                Boolean check = true;
                for (int i = 0; i < manu.Count; i++)
                {
                    if (reader.GetString(0) == manu[i])
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    phoneManufacturerComboBox.Items.Add(reader.GetString(0));
                    manu.Add(reader.GetString(0));
                }
            }
            con.close();
        }
        private DataTable selectPhone(int topProduct)
        {
            cmd = new SqlCommand("LaySanPhamMoi", DBConnecttion.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sl", SqlDbType.Int).Value = topProduct;
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        private void LoadPhone(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                int phoneId = Convert.ToInt32(row["MaSP"]);
                string phoneName = row["TenSP"].ToString().Trim();
                string phoneChip = row["Chip"].ToString().Trim();
                string phoneOS = row["HDH"].ToString().Trim();
                string phoneBattery = row["Pin"].ToString().Trim();
                string phoneRAM = row["RAM"].ToString().Trim();
                string phoneMemory = row["BoNho"].ToString().Trim();
                Image phoneImage = ByteToImage((byte[])row["Hinh"]);
                int phonePrice = Convert.ToInt32(row["GiaBan"]);
                PhoneCardControl card = new PhoneCardControl(phoneId, phoneName, phoneChip, phoneOS, phoneBattery, phoneRAM, phoneMemory, phonePrice, phoneImage);
                flowLayoutProductPanel.Controls.Add(card);
            }
        }
        public Image ByteToImage(byte[] data)
        {
            try
            {
                using (var ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            flowLayoutProductPanel.Controls.Clear();
            flowLayoutProductPanel.Controls.Add(billControl);
        }

        private void btnInstallment_Click(object sender, EventArgs e)
        {
            flowLayoutProductPanel.Controls.Clear();
            InstallmentControl billControl = new InstallmentControl();
            flowLayoutProductPanel.Controls.Add(billControl);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (DBConnecttion.conn.State == ConnectionState.Closed)
            {
                con.connect();
            }
            flowLayoutProductPanel.Controls.Clear();
            dt = selectPhone(9);
            LoadPhone(dt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DBConnecttion.conn.State == ConnectionState.Closed)
            {
                DBConnecttion.conn.Open();
            }
            string typePhone = typePhoneComboBox.Text;
            string phoneManu = phoneManufacturerComboBox.Text;
            
            List<CheckBox> listPrice = new List<CheckBox>();
            listPrice.Add(checkBoxPrice_1);
            listPrice.Add(checkBoxPrice_2);
            listPrice.Add(checkBoxPrice_3);
            listPrice.Add(checkBoxPrice_4);
            listPrice.Add(checkBoxPrice_5);

            int min_price = 0;
            int max_price = 999999999;
            for (int i = 0; i < listPrice.Count; i++)
            {
                if (listPrice[i].Checked)
                {
                    switch (i)
                    {
                        case 0:
                            min_price = 0;
                            max_price = 1999999;
                            break;
                        case 1:
                            min_price = 2000000;
                            max_price = 4000000;
                            break;
                        case 2:
                            min_price = 4000000;
                            max_price = 7000000;
                            break;
                        case 3:
                            min_price = 7000000;
                            max_price = 13000000;
                            break;
                        case 4:
                            min_price = 13000000;
                            break;
                    }
                }
            }
            SqlCommand comm = new SqlCommand("LocSanPham", DBConnecttion.conn);
            comm.CommandType = CommandType.StoredProcedure;
            // Thêm các tham số (nếu cần)
            if (typePhone != "")
            {
                comm.Parameters.Add(new SqlParameter("@Loai", SqlDbType.NVarChar));
                comm.Parameters["@Loai"].Value = typePhone;
            }
            if (phoneManu != "")
            {
                comm.Parameters.Add(new SqlParameter("@Hang", SqlDbType.Char));
                comm.Parameters["@Hang"].Value = phoneManu;
            }
            comm.Parameters.Add(new SqlParameter("@MinPrice", SqlDbType.Int));
            comm.Parameters["@MinPrice"].Value = min_price;
            comm.Parameters.Add(new SqlParameter("@MaxPrice", SqlDbType.Int));
            comm.Parameters["@MaxPrice"].Value = max_price;

            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            flowLayoutProductPanel.Controls.Clear();
            LoadPhone(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DBConnecttion.conn.Close();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            string strConnect = $"Data Source=.;Initial Catalog=QLCHDT;Integrated Security=True";
            DBConnecttion.conn = new SqlConnection(strConnect);
            this.Close();
        }
    }
}
