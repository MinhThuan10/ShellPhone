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
    public partial class BrandTypeControl : UserControl
    {
        public BrandTypeControl()
        {
            InitializeComponent();
        }

        private void BrandTypeControl_Load(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();  
            BrandControl brandControl = new BrandControl();
            pnlContainer.Controls.Add(brandControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            TypeControl typeControl = new TypeControl();
            pnlContainer.Controls.Add(typeControl);
        }
    }
}
