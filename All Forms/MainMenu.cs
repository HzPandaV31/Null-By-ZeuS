using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
using FireSharp.Config;
using FireSharp.Interfaces;
using KrnlAPI;

namespace Null
{
    public partial class MainMenu : Form
    {
        Point lastPoint;
        public DiscordRpcClient client;
        Properties.Settings settings = Properties.Settings.Default;
        Profile profile;
        Execute execute;
        BuyPremium premium;
        Settings setting;
        bool execute1 = false;
        bool setting1 = false;
        bool premium1 = false;
        bool profile1 = false;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                guna2BorderlessForm1.BorderRadius = 30;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                guna2BorderlessForm1.BorderRadius = 0;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            execute = new Execute();
            DiscordRPC("On Main Menu");
            panelMain.Controls.Clear();
            execute.TopLevel = false;
            execute.Dock = DockStyle.Fill;
            panelMain.Controls.Add(execute);
            execute.BringToFront();
            execute.Show();

            var result = await Connection.db.GetAsync(@"Users/" + settings.User);
            database user = result.ResultAs<database>();
            settings.Level = user.Level;
            settings.Exp = user.Exp;
            settings.Plan = user.Plan;
            settings.Save();
            if(user.Ban == true)
            {
                settings.Remember = false;
                settings.Save();

                MessageBox.Show("Banned!", "Null", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }
            timer1.Enabled = true;
        }

        public void DiscordRPC(string state)
        {
            //Create a Discord client
            client = new DiscordRpcClient("965385543129128960");

            //Set the logger
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            //Subscribe to events
            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            //Connect to the RPC
            client.Initialize();

            //Set the rich presence
            //Call this as many times as you want and anywhere in your code.
            client.SetPresence(new RichPresence()
            {
                Details = " ",
                State = state,
                Timestamps = new Timestamps()
                {
                    Start = DateTime.UtcNow,
                },
                Buttons = new DiscordRPC.Button[]
                {
                    new DiscordRPC.Button() { Label = "Join Discord", Url = "https://discord.gg/hvwXqXprhD" }
                },
                Assets = new Assets()
                {
                    LargeImageKey = "ba_l_ks_z-1",
                    LargeImageText = "Select Best Exploit!",
                    SmallImageKey = "small"
                }
            });
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                settings.Exp = settings.Exp + 4;
                settings.Save();
                if(settings.Exp > 99)
                {
                    settings.Exp = 0;
                    settings.Level = settings.Level + 1;
                    settings.Save();
                    await Connection.db.SetAsync(@"Users/" + settings.User + "/Exp", settings.Exp);
                    await Connection.db.SetAsync(@"Users/" + settings.User + "/Level", settings.Level);
                }
                await Connection.db.SetAsync(@"Users/" + settings.User + "/Level", settings.Level);
                await Connection.db.SetAsync(@"Users/" + settings.User + "/Exp", settings.Exp);
            }
            catch (Exception)
            {

            }
            
        }

        public void Rainbow(Color clr)
        {
            Random rnd = new Random();

            clr = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }
        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            if (guna2Panel1.BackColor == Color.FromArgb(26, 26, 26))
            {
                guna2Panel1.BackColor = Color.Transparent;
            }
            else if (guna2Panel2.BackColor == Color.FromArgb(26, 26, 26))
            {
                guna2Panel2.BackColor = Color.Transparent;
            }

            guna2Panel3.BackColor = Color.FromArgb(26, 26, 26);
            if (premium1 == false)
            {
                premium = new BuyPremium();
                premium1 = true;
            }
            panelMain.Controls.Clear();
            premium.TopLevel = false;
            premium.Dock = DockStyle.Fill;
            panelMain.Controls.Add(premium);
            premium.BringToFront();
            premium.Show();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if (guna2Panel1.BackColor == Color.FromArgb(26, 26, 26))
            {
                guna2Panel1.BackColor = Color.Transparent;
            }
            else if (guna2Panel3.BackColor == Color.FromArgb(26, 26, 26))
            {
                guna2Panel3.BackColor = Color.Transparent;
            }

            guna2Panel2.BackColor = Color.FromArgb(26, 26, 26);

            panelMain.Controls.Clear();
            execute.TopLevel = false;
            execute.Dock = DockStyle.Fill;
            panelMain.Controls.Add(execute);
            execute.BringToFront();
            execute.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(guna2Panel2.BackColor == Color.FromArgb(26, 26, 26))
            {
                guna2Panel2.BackColor = Color.Transparent;
            }
            else if (guna2Panel3.BackColor == Color.FromArgb(26, 26, 26))
            {
                guna2Panel3.BackColor = Color.Transparent;
            }

            guna2Panel1.BackColor = Color.FromArgb(26, 26, 26);
            if(profile1 == false)
            {
                profile = new Profile();
                profile1 = true;
            }
            
            panelMain.Controls.Clear();
            profile.TopLevel = false;
            profile.Dock = DockStyle.Fill;
            panelMain.Controls.Add(profile);
            profile.BringToFront();
            profile.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (guna2Panel2.BackColor == Color.FromArgb(26, 26, 26))
            {
                guna2Panel2.BackColor = Color.Transparent;
            }
            else if (guna2Panel3.BackColor == Color.FromArgb(26, 26, 26))
            {
                guna2Panel3.BackColor = Color.Transparent;
            }
            else if (guna2Panel1.BackColor == Color.FromArgb(26, 26, 26))
            {
                guna2Panel1.BackColor = Color.Transparent;
            }
            if (setting1 == false)
            {
                setting = new Settings();
                setting1 = true;
            }
            panelMain.Controls.Clear();
            setting.TopLevel = false;
            setting.Dock = DockStyle.Fill;
            panelMain.Controls.Add(setting);
            setting.BringToFront();
            setting.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(settings.MainColor != Color.White)
            {
                if(panelTop.BackColor != settings.MainColor)
                {
                    panelTop.BackColor = settings.MainColor;
                    panelSide.BackColor = settings.MainColor;
                }
            }
            timer2.Interval = 2000;
        }
    }
}
