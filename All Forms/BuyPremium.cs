using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Null
{
    public partial class BuyPremium : Form
    {
        public BuyPremium()
        {
            InitializeComponent();
        }
        Properties.Settings settings = Properties.Settings.Default;
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://shoppy.gg/product/uOOj7Qa");
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void BuyPremium_Load(object sender, EventArgs e)
        {
            if (settings.Plan == "Premium")
            {
                guna2GradientButton1.Text = "Owned";
                guna2GradientButton1.Enabled = false;
            }
        }
    }
}
