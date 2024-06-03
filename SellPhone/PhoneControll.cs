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
    public partial class PhoneControll : UserControl
    {
        public PhoneControll()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        private int id;

        DBConnecttion con = new DBConnecttion();
public void LoadPhoneList()
{
    string query = "SELECT * FROM V_DSSanPham";
    dt = new DataTable();
    adapter = new SqlDataAdapter(query, DBConnecttion.conn);
    adapter.Fill(dt);
    dgvPhoneList.DataSource = dt;
}
        private void ResetTextBox()
        {
            this.txtPhoneProvider.Text = null;
            this.txtPhoneBrand.Text = null;
            this.txtPhoneOS.Text = null;
            this.txtPhoneName.Text = null;
            this.txtPhoneChip.Text = null;
            this.txtPhoneRAM.Text = null;
            this.txtPhoneType.Text = null;
            this.txtPhoneGuaranteeTime.Text = null; 
            this.txtPhoneBattery.Text = null;   
            this.txtPhoneMemory.Text = null;
            this.txtPhoneColor.Text = null;
            this.pibPhoneImage.Image = null;
        }
        private void PhoneControll_Load(object sender, EventArgs e)
        {
            if (DBConnecttion.conn.State == ConnectionState.Closed)
            {
                con.connect();
            }
            this.dgvPhoneList.DefaultCellStyle.SelectionBackColor = this.dgvPhoneList.DefaultCellStyle.BackColor;
            this.dgvPhoneList.DefaultCellStyle.SelectionForeColor = this.dgvPhoneList.DefaultCellStyle.ForeColor;
            LoadPhoneList();
            con.close();
        }

        public bool DeletePhone(int id)
        {
            if (DBConnecttion.conn.State == ConnectionState.Closed)
            {
                con.connect();
            }
            cmd = new SqlCommand("XoaSanPham", DBConnecttion.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSP", SqlDbType.Int).Value = id;
            int rowAffected = cmd.ExecuteNonQuery();
            con.close();
            return rowAffected > 0;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadPhoneList();
            ResetTextBox();
            if (this.dgvPhoneList.RowCount > 1)
            {
                this.dgvPhoneList.ClearSelection();
                id = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InsertPhonee insertPhone = new InsertPhonee();
            ResetTextBox();
            if (this.dgvPhoneList.RowCount > 1)
            {
                this.dgvPhoneList.ClearSelection();
                id = 0;
            }
            insertPhone.ShowDialog();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(id == 0)
            {
                return;
            }
            UpdatePhonee updatePhone = new UpdatePhonee(id);
            updatePhone.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(this.dgvPhoneList.CurrentRow == null)
            {
                return;
            }
            if( id == 0)
            {
                return;

            }
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
            ResetTextBox();
            if (this.dgvPhoneList.RowCount > 1)
            {
                this.dgvPhoneList.SelectedCells[0].Selected = false;
            }
        }
        private void dgvPhoneList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.dgvPhoneList.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                this.dgvPhoneList.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
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

        private void btnrpt_Click(object sender, EventArgs e)
        {
            SanPhamReport sanPhamReport = new SanPhamReport();
            sanPhamReport.Show();
        }
    }
}
