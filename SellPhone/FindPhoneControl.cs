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
    public partial class FindPhoneControl : UserControl
    {
        public FindPhoneControl()
        {
            InitializeComponent();
        }

        DBConnecttion con = new DBConnecttion();


        private void findBtn_Click(object sender, EventArgs e)
        {
            if(DBConnecttion.conn.State == ConnectionState.Closed)
            {
                DBConnecttion.conn.Open();
            }
            string typePhone = "", phoneManu = "";
            typePhone = typePhoneComboBox.Text;
            phoneManu = phoneManufacturerComboBox.Text;
            List<CheckBox> listMemory = new List<CheckBox>();
            listMemory.Add(checkBox128GB);
            listMemory.Add(checkBox256GB);
            listMemory.Add(checkBox512GB);
            listMemory.Add(checkBox1TB);

            List<CheckBox> listColor = new List<CheckBox>();
            listColor.Add(checkBoxBlack);
            listColor.Add(checkBoxBlue);
            listColor.Add(checkBoxPink);

            List<CheckBox> listPrice = new List<CheckBox>();
            listPrice.Add(checkBoxPrice_1);
            listPrice.Add(checkBoxPrice_2);
            listPrice.Add(checkBoxPrice_3);
            listPrice.Add(checkBoxPrice_4);
            listPrice.Add(checkBoxPrice_5);

            string listMemoryString = "";
            for(int i = 0;i < listMemory.Count;i++)
            {
                if (listMemory[i].Checked)
                {
                    listMemoryString += listMemory[i].Text + ',';
                }
            }

            string listColorString = "";
            for (int i = 0; i < listColor.Count; i++)
            {
               
                if (listColor[i].Checked)
                {
                    listColorString += listColor[i].Text + ',';
                }
            }

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
            if(typePhone != "")
            {
                comm.Parameters.Add(new SqlParameter("@Loai", SqlDbType.NVarChar));
                comm.Parameters["@Loai"].Value = typePhone;
            }
            if (phoneManu != "")
            {
                comm.Parameters.Add(new SqlParameter("@Hang", SqlDbType.Char));
                comm.Parameters["@Hang"].Value = phoneManu;
            }
            if (listMemoryString != "")
            {
                listMemoryString = listMemoryString.Substring(0, listMemoryString.Length - 1);
                comm.Parameters.Add(new SqlParameter("@BoNho", SqlDbType.Char));
                comm.Parameters["@BoNho"].Value = listMemoryString;
            }
            if(listColorString != "")
            {
                listColorString = listColorString.Substring(0, listColorString.Length - 1);
                comm.Parameters.Add(new SqlParameter("@Mau", SqlDbType.Char));
                comm.Parameters["@Mau"].Value = listColorString;
            }
            comm.Parameters.Add(new SqlParameter("@MinPrice", SqlDbType.Int));
            comm.Parameters["@MinPrice"].Value = min_price;
            comm.Parameters.Add(new SqlParameter("@MaxPrice", SqlDbType.Int));
            comm.Parameters["@MaxPrice"].Value = max_price;

            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgPhone.DataSource = dt;
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DBConnecttion.conn.Close();
        }

        private void FindPhoneControl_Load(object sender, EventArgs e)
        {
            if(DBConnecttion.conn.State == ConnectionState.Closed)
            {
                DBConnecttion.conn.Open();
            }
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
                for(int i = 0; i < manu.Count;i++)
                {
                    if(reader.GetString(0) == manu[i])
                    {
                        check = false;
                        break;
                    }
                }
                if(check)
                {
                    phoneManufacturerComboBox.Items.Add(reader.GetString(0));
                    manu.Add(reader.GetString(0));
                }
            }
            DBConnecttion.conn.Close();
        }

        private void refeshBtn_Click(object sender, EventArgs e)
        {
            typePhoneComboBox.Text = "";
            phoneManufacturerComboBox.Text = "";
            checkBox128GB.Checked = false;
            checkBox256GB.Checked = false;
            checkBox512GB.Checked = false;
            checkBox1TB.Checked = false;
            checkBoxBlue.Checked = false;
            checkBoxBlack.Checked = false;
            checkBoxPink.Checked = false;
            checkBoxPrice_1.Checked = false;
            checkBoxPrice_2.Checked = false;
            checkBoxPrice_3.Checked = false;
            checkBoxPrice_4.Checked = false;
            checkBoxPrice_5.Checked = false;
        }

       
    }
}
