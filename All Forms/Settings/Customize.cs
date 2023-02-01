using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Null
{
    public partial class Customize : Form
    {
        public Customize()
        {
            InitializeComponent();
        }
        Properties.Settings settings = Properties.Settings.Default;
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = DesktopLocation.ToString();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    settings.scriptboxImage = openFileDialog1.FileName;
                    settings.Save();

                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Error Found" + a.Message);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                settings.MainColor = colorDialog1.Color;
                settings.Save();
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            settings.MainColor = Color.Black;
            settings.Save();
        }

        private void Customize_Load(object sender, EventArgs e)
        {

        }
    }
}
