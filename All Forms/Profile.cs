using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Null
{
    public partial class Profile : Form
    {

        public Profile()
        {
            InitializeComponent();
        }
        
        
        Properties.Settings settings = Properties.Settings.Default;
        DirectoryInfo dinfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
        WebClient client = new WebClient();
        private void Profile_Load(object sender, EventArgs e)
        {
            try
            {
                if (settings.Image.Trim() != "" || settings.Banner.Trim() != "")
                {
                    guna2PictureBox1.Image = ConvertBase64ToImage(settings.Image);

                    FileInfo[] File1 = dinfo.GetFiles("*.png");
                    foreach (FileInfo file in File1)
                    {
                        if (file.Name != Classes.GetDiscord.pnghash + ".png")
                        {
                            file.Delete();
                        }
                    }
                }
                else
                {
                    Classes.GetDiscord.Pp();
                    string imagepath = Application.StartupPath + "/" + Classes.GetDiscord.pnghash + ".png";

                    if (!File.Exists(imagepath))
                    {
                        client.DownloadFile(settings.DcImageLink, imagepath);
                    }
                    if (settings.Image != ConvertImageToBase64(Image.FromFile(imagepath)))
                    {
                        settings.Image = ConvertImageToBase64(Image.FromFile(imagepath));
                        settings.Save();
                    }
                    
                    guna2PictureBox1.Image = Image.FromFile(imagepath);
                }

                if (settings.DcNick != Classes.GetDiscord.DcFullNick())
                {
                    settings.DcNick = Classes.GetDiscord.DcFullNick();
                    settings.Save();
                    label2.Text = settings.DcNick;
                }
                else if(settings.DcNick != null)
                {
                    label2.Text = settings.DcNick;
                }

                
                label10.Text = settings.User;
                label3.Text += settings.Plan;
                label5.Text = Classes.GetRobloxNick.RobloxNick();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                MessageBox.Show("ERROR: No Internet connection or bad connection", "NULL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public string ConvertImageToBase64(Image file)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                file.Save(memoryStream, file.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
        public Image ConvertBase64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                label6.Text = settings.Exp.ToString() + "/100";
                guna2ProgressBar1.Value = Convert.ToInt32(settings.Exp);
                label8.Text = "Level " + settings.Level.ToString();

                ExpLevel.Interval = 5000;
            }
            catch (Exception)
            {

            }

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            settings.Remember = false;
            settings.Save();

            Application.Restart();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label2.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label5.Text);
        }
    }
}