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
    public partial class Api_Confirguration : Form
    {
        public Api_Confirguration()
        {
            InitializeComponent();
        }
        Properties.Settings settings = Properties.Settings.Default;
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.SelectedAPI = guna2ComboBox1.SelectedIndex + 1;
            settings.Save();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RobloxPID.ProcKill(RobloxPID.RobloxGetPID());
        }

        private void Api_Confirguration_Load(object sender, EventArgs e)
        {
            guna2ComboBox1.SelectedIndex = settings.SelectedAPI - 1;
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
