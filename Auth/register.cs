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
    public partial class register : Form
    {
        login login = new login();
        bool hide = true;
        public register()
        {
            InitializeComponent();
        }

        private void ButtonReg_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            if(TextBoxPass.Text.Length < 6)
            {
                login.WrongPass(ButtonRegister,"Register", "Too Short!", Color.FromArgb(27, 28, 31), Color.FromArgb(27, 28, 31), Color.Red);
            }
            else if(TextBoxUser.Text.Length < 4)
            {
                login.WrongPass(ButtonRegister, "Register", "Too Short!", Color.FromArgb(27, 28, 31), Color.FromArgb(27, 28, 31), Color.Red);
            }
            else
            {
                
                var result = await Connection.db.GetAsync(@"Users/" + TextBoxUser.Text.Trim());
                database user = result.ResultAs<database>();
                
                if(user == null)
                {
                    login.WrongPass(ButtonRegister, "Register", "Succes!", Color.FromArgb(27, 28, 31), Color.FromArgb(27, 28, 31), Color.Green);
                    await Connection.db.SetAsync(@"Users/" + TextBoxUser.Text + "/Password", TextBoxPass.Text);
                    await Connection.db.SetAsync(@"Users/" + TextBoxUser.Text + "/Ban", false);
                    await Connection.db.SetAsync(@"Users/" + TextBoxUser.Text + "/Discord", TextBoxDc.Text);
                    await Connection.db.SetAsync(@"Users/" + TextBoxUser.Text + "/Key", "Qdx." + RandomString(20));
                    await Connection.db.SetAsync(@"Users/" + TextBoxUser.Text + "/Plan", "Free");
                    await Connection.db.SetAsync(@"Users/" + TextBoxUser.Text + "/Exp", 0);
                    await Connection.db.SetAsync(@"Users/" + TextBoxUser.Text + "/Level", 0);

                    this.Hide();
                    
                }
                else
                {
                    login.WrongPass(ButtonRegister, "Register", "User Exists!", Color.FromArgb(27, 28, 31), Color.FromArgb(27, 28, 31), Color.Red);
                }
                
            }
            
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if(hide == false)
            {
                BtnShow.Image = Properties.Resources.hide1_30px;
                hide = true;
                TextBoxPass.PasswordChar = '*';
            }
            else if(hide == true)
            {
                BtnShow.Image = Properties.Resources.eye_30px;
                hide = false;
                TextBoxPass.PasswordChar = '\0';
            }
        }
    }
}
