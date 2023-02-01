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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        Customize customize;
        Api_Confirguration apiconfig;
        In_Game ingame;
        Volume volume;
        bool volume1 = false;
        bool customize1 = false;
        bool ingame1 = false;
        bool apiconfig1 = false;
        Properties.Settings settings = Properties.Settings.Default;

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (apiconfig1 == false)
            {
                apiconfig = new Api_Confirguration();
                apiconfig1 = true;
            }
            
            guna2Panel2.Controls.Clear();
            apiconfig.TopLevel = false;
            apiconfig.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Add(apiconfig);
            apiconfig.BringToFront();
            apiconfig.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (ingame1 == false)
            {
                ingame = new In_Game();
                ingame1 = true;
            }
            
            guna2Panel2.Controls.Clear();
            ingame.TopLevel = false;
            ingame.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Add(ingame);
            ingame.BringToFront();
            ingame.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (volume1 == false)
            {
                volume = new Volume();
                volume1 = true;
            }
            
            guna2Panel2.Controls.Clear();
            volume.TopLevel = false;
            volume.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Add(volume);
            volume.BringToFront();
            volume.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (customize1 == false)
            {
                customize = new Customize();
                customize1 = true;
            }
            guna2Panel2.Controls.Clear();
            customize.TopLevel = false;
            customize.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Add(customize);
            customize.BringToFront();
            customize.Show();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if(settings.Plan == "Free")
            {
                guna2Button1.Enabled = false;
                guna2Button1.Text = "Buy Premium!";
            }
            if(settings.Plan == "Premium")
            {
                guna2Button1.Enabled = true;
            }
        }
    }
}
