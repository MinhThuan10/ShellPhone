using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellPhone
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        
        bool menuExpand = false;
        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                pnlSubnav.Height -= pnlSubnav.MaximumSize.Height;
                if(pnlSubnav.Height == pnlSubnav.MinimumSize.Height)
                {
                    menuExpand = false;
                    timerMenu.Stop();
                }
            }
            else
            {
                pnlSubnav.Height += pnlSubnav.MaximumSize.Height;
                if (pnlSubnav.Height == pnlSubnav.MaximumSize.Height)
                {
                    menuExpand = true;
                    timerMenu.Stop();
                }
                
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlSubnav.Height = 0;
        }

        private void btnBrandType_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            BrandTypeControl brandControl = new BrandTypeControl();
            pnlContainer.Controls.Add(brandControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            FindImportControl findImportControl = new FindImportControl();
            pnlContainer.Controls.Add(findImportControl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            ViewThuAndChi viewThuAndChi = new ViewThuAndChi();
            pnlContainer.Controls.Add(viewThuAndChi);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            FindPhoneControl findPhoneControl = new FindPhoneControl();
            pnlContainer.Controls.Add(findPhoneControl);
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            PhoneControll phoneControl = new PhoneControll();
            pnlContainer.Controls.Add(phoneControl);
        }

        private void btnEmploy_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            EmployeeControl emplControl = new EmployeeControl();
            pnlContainer.Controls.Add(emplControl);
        }
        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            FindBillControl findBillControl = new FindBillControl();
            pnlContainer.Controls.Add(findBillControl);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            AccountControl accountControl = new AccountControl();
            pnlContainer.Controls.Add(accountControl);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();  
            Chart chart = new Chart();
            pnlContainer.Controls.Add(chart);
        }
    }
}
