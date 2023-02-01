using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Null
{
    public partial class login : Form
    {
        Point lastPoint;
        Properties.Settings settings = Properties.Settings.Default;
        bool hide = true;
        MainMenu main;
        register form2;
        public login()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                guna2BorderlessForm2.BorderRadius = 30;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                guna2BorderlessForm2.BorderRadius = 0;
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_Load(object sender, EventArgs e)
        {
            
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

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await Connection.db.GetAsync(@"Users/" + TextBoxUser.Text.Trim());
                database data = result.ResultAs<database>();

                if (data != null)
                {
                    if (TextBoxPass.Text == data.Password && data.Ban == false)
                    {
                        settings.Remember = CheckBoxRemember.Checked;
                        settings.User = TextBoxUser.Text.Trim();
                        settings.Save();

                        main = new MainMenu();
                        main.Show();
                        this.Hide();
                    }
                    else if (TextBoxPass.Text == data.Password && data.Ban == true)
                    {
                        WrongPass(ButtonLogin,"Login", "Banned!", Color.FromArgb(27, 28, 31), Color.FromArgb(27, 28, 31), Color.Red);
                    }
                    else
                    {
                        WrongPass(ButtonLogin,"Login", "Wrong!", Color.FromArgb(27, 28, 31), Color.FromArgb(27, 28, 31), Color.Red);
                    }
                }
                else
                {
                    WrongPass(ButtonLogin,"Login", "Wrong!", Color.FromArgb(27, 28, 31), Color.FromArgb(27, 28, 31), Color.Red);
                }
            }
            catch (Exception a)
            {
                WrongPass(ButtonLogin,"Login", "Wrong!", Color.FromArgb(27, 28, 31), Color.FromArgb(27, 28, 31), Color.Red);
                MessageBox.Show(a.Message);
            }
            
        }
        public async void WrongPass(Guna.UI2.WinForms.Guna2GradientButton button,string maintext,string wrongtext,Color oldclr,Color oldclr2,Color newclr)
        {
            button.Text = wrongtext;
            button.FillColor = newclr;
            button.FillColor2 = newclr;
            await Task.Delay(2000);
            button.Text = maintext;
            button.FillColor = oldclr;
            button.FillColor2 = oldclr2;
        }

        private void ButtonReg_Click(object sender, EventArgs e)
        {
            form2 = new register();
            form2.TopLevel = false;
            form2.Dock = DockStyle.Fill;
            panel1.Controls.Add(form2);
            form2.BringToFront();
            form2.Show();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (hide == false)
            {
                BtnShow.Image = Properties.Resources.hide1_30px;
                hide = true;
                TextBoxPass.PasswordChar = '*';
            }
            else if (hide == true)
            {
                BtnShow.Image = Properties.Resources.eye_30px;
                hide = false;
                TextBoxPass.PasswordChar = '\0';
            }
        }
    }
}
