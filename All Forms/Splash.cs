using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KrnlAPI;

namespace Null
{
    public partial class Splash : Form
    {
        Properties.Settings settings = Properties.Settings.Default;

        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //settings.Remember = true;
            guna2ProgressBar1.Value = guna2ProgressBar1.Value + 1;
            if (guna2ProgressBar1.Value == 100)
            {
                if (settings.Remember == true)
                {
                    MainMenu main = new MainMenu();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    login f2 = new login();
                    this.Hide();
                    f2.Show();
                }
                timer1.Stop();
                timer2.Stop();
            } 
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "Loading")
            {
                label1.Text = "Loading.";
            }
            else if (label1.Text == "Loading.")
            {
                label1.Text = "Loading..";
            }
            else if (label1.Text == "Loading..")
            {
                label1.Text = "Loading...";
            }
            else if (label1.Text == "Loading...")
            {
                label1.Text = "Loading";
            }
        }
    }
}
