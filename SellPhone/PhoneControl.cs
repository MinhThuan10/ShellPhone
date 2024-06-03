using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SellPhone
{
    public partial class PhoneControl : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        private int id;
        public PhoneControl()
        {
            InitializeComponent();
        }
        public void DBConnection()
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=QLCHDT;Persist Security Info=True;User ID=sa;Password=8426");
        }
        public void Connect() { conn.Open(); }
        public void Disconect() { conn.Close(); }
        public void LoadPhoneList()
        {
            string query = "SELECT * FROM V_DSSanPham";
            dt = new DataTable();
            adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dt);
            dgvPhoneList.DataSource = dt;
        }
        private void PhoneControl_Load(object sender, EventArgs e)
        {
            DBConnection();
            Connect();
            LoadPhoneList();
            Disconect();
        }
        public bool DeletePhone(int id)
        {
            Connect();
            cmd = new SqlCommand("XoaSanPham", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSP", SqlDbType.Int).Value = id;
            int rowAffected = cmd.ExecuteNonQuery();
            Disconect();
            return rowAffected > 0;
        }
        private void dgvPhoneList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.id = int.Parse(dgvPhoneList.CurrentRow.Cells["MaSP"].Value.ToString());
                txtPhoneName.Text = dgvPhoneList.CurrentRow.Cells["TenSP"].Value.ToString();
                txtPhoneType.Text = dgvPhoneList.CurrentRow.Cells["TenLoai"].Value.ToString(); 
                txtPhoneProvider.Text = dgvPhoneList.CurrentRow.Cells["TenNCC"].Value.ToString();
                txtPhoneBrand.Text = dgvPhoneList.CurrentRow.Cells["Hang"].Value.ToString();
                txtPhoneOS.Text = dgvPhoneList.CurrentRow.Cells["HDH"].Value.ToString();
                txtPhoneChip.Text = dgvPhoneList.CurrentRow.Cells["Chip"].Value.ToString();
                txtPhoneBattery.Text = dgvPhoneList.CurrentRow.Cells["Pin"].Value.ToString();
                txtPhoneMemory.Text = dgvPhoneList.CurrentRow.Cells["BoNho"].Value.ToString();
                txtPhoneRAM.Text = dgvPhoneList.CurrentRow.Cells["RAM"].Value.ToString();
                txtPhoneColor.Text = dgvPhoneList.CurrentRow.Cells["Mau"].Value.ToString();
                txtPhoneGuaranteeTime.Text = dgvPhoneList.CurrentRow.Cells["TGBH"].Value.ToString();
                Image phoneImage = ByteToImage((byte[])dgvPhoneList.CurrentRow.Cells["Hinh"].Value);
                pibPhoneImage.Image = phoneImage;
            }
            catch
            {
                pibPhoneImage.Image = null;
                return;
            }
        }
        public byte[] ImageToByte(Image image)
        {
            try
            {
                if (image == null)
                {
                    return null;
                }
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePhone updatePhone = new UpdatePhone(id);
            updatePhone.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InsertPhone insertPhone = new InsertPhone();
            insertPhone.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvPhoneList.CurrentRow.Cells["MaSP"].Value.ToString());
            DialogResult dialogResult = MessageBox.Show("Sản phẩm sau khi xóa sẽ không thể xem lại trong bảng Chi tiết phiếu nhập. Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                bool check = DeletePhone(id);
                if (check)
                {
                    LoadPhoneList();
                    MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadPhoneList();
        }
    }
}
