using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using injection;
using KrnlAPI;
using WeAreDevs_API;

namespace Null
{
    public partial class Execute : Form
    {
        KrnlApi krnl = new KrnlApi();
        ExploitAPI wrd = new ExploitAPI();

        string PathScripts = AppDomain.CurrentDomain.BaseDirectory + @"Scripts\";
        DirectoryInfo dinfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "Scripts");
        Properties.Settings settings = Properties.Settings.Default;
        int i = 0;

        public Execute()
        {
            InitializeComponent();
        }

        private void Execute_Load(object sender, EventArgs e)
        {

        }
        
        private async void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if(settings.SelectedAPI == 1)
                {
                    if (i == 0)
                    {
                        await Task.Run(() => krnl.Initialize());
                        i = 1;
                    }
                    await Task.Run(() => krnl.Inject());
                }
                else if(settings.SelectedAPI == 2)
                {
                    await Task.Run(() => wrd.LaunchExploit());
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (settings.SelectedAPI == 1)
                {
                    if (settings.Plan == "Premium")
                    {
                        krnl.Execute("_G.SDUghuaosdhgaoshdiasohydiash31 = true");
                    }
                    krnl.Execute(ScriptBox.Text);
                }
                else if (settings.SelectedAPI == 2)
                {
                    if (settings.Plan == "Premium")
                    {
                        wrd.SendLuaScript("_G.SDUghuaosdhgaoshdiasohydiash31 = true");
                    }
                    wrd.SendLuaScript(ScriptBox.Text);
                }
            }
            catch (Exception)
            {

            }     
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            ScriptList(".txt",".lua");
        }
        public void ScriptList(string uzanti, string uzanti2)
        {
            try
            {
                System.IO.Directory.CreateDirectory(PathScripts);
                FileInfo[] File = dinfo.GetFiles("*" + uzanti);
                FileInfo[] File1 = dinfo.GetFiles("*" + uzanti2);
                
                foreach (FileInfo file in File)
                {
                    if (!ScriptMenu.Items.Contains(file.Name))
                    {
                        ScriptMenu.Items.Add(file.Name);
                    }
                }
                foreach (FileInfo file in File1)
                {
                    if (!ScriptMenu.Items.Contains(file.Name))
                    {
                        ScriptMenu.Items.Add(file.Name);
                    }
                }

                if (File.Length + File1.Length != ScriptMenu.Items.Count)
                {
                    ScriptMenu.Items.Clear();
                }

                if(ScriptMenu.Items.Count == 0)
                {
                    ScriptMenu.Items.Add("Script Not Found!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void ScriptMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ScriptBox.Text = File.ReadAllText($"./Scripts/{ScriptMenu.SelectedItem}");
            }
            catch (Exception a)
            {
                if (a is FileNotFoundException)
                {
                    ScriptMenu.Items.Remove(ScriptMenu.SelectedItem);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = PathScripts;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ScriptBox.Text = "";
                    System.IO.Stream stream;
                    if ((stream = openFileDialog1.OpenFile()) == null)
                        return;
                    using (stream)
                        this.ScriptBox.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Error Found" + a.Message);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = Application.StartupPath + @"\Scripts\";
                sfd.Filter = "Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Stream s = sfd.OpenFile();
                    StreamWriter sw = new StreamWriter(s);
                    sw.Write(ScriptBox.Text);
                    sw.Close();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Error Found" + a.Message);
            }
        }

        private void ScriptMenu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    DeleteFile();
                }
            }
            catch (Exception a)
            {
                if (a is FileNotFoundException)
                {
                    ScriptMenu.Items.Remove(ScriptMenu.SelectedItem);
                }
                else
                {
                    MessageBox.Show(a.Message);
                }
            }
        }

        public void DeleteFile()
        {
            if (ScriptMenu.SelectedItem != null)
            {
                File.Delete(Path.Combine(dinfo.ToString(), ScriptMenu.SelectedItem.ToString()));
                ScriptMenu.Items.Remove(ScriptMenu.SelectedItem);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(PathScripts);
            FileInfo[] File = dinfo.GetFiles("*.txt");
            FileInfo[] File1 = dinfo.GetFiles("*.lua");

            ScriptMenu.Items.Clear();
            timerRefresh.Enabled = false;

            foreach (FileInfo file in File)
            {
                if (file.Name.ToLowerInvariant().Contains(guna2TextBox1.Text.ToLower()) || file.Name.ToUpperInvariant().Contains(guna2TextBox1.Text.ToUpper()) || file.Name.Contains(guna2TextBox1.Text))
                {
                    ScriptMenu.Items.Add(file.Name);
                }
            }
            foreach (FileInfo file in File1)
            {
                if (file.Name.ToLowerInvariant().Contains(guna2TextBox1.Text.ToLower()) || file.Name.ToUpperInvariant().Contains(guna2TextBox1.Text.ToUpper()) || file.Name.Contains(guna2TextBox1.Text))
                {
                    ScriptMenu.Items.Add(file.Name);
                }
            }

            if (ScriptMenu.Items.Count == 0)
            {
                ScriptMenu.Items.Add("Script Not Found!");
            }

            if (guna2TextBox1.Text.Trim() == "")
            {
                timerRefresh.Enabled = true;
            }
        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged();
            guna2TabControl1.SelectedTab.Controls.Add(ScriptBox);
            if(guna2TabControl1.SelectedTab.Text == "Main")
            {
                ButtonAddTab.Left = ButtonAddTab.Left - 20;
                ButtonRemoveTab.Hide();
            }
            else
            {
                ButtonAddTab.Left = ButtonRemoveTab.Left + 20;
                ButtonRemoveTab.Show();
            }
        }
        public void SelectedIndexChanged()
        {
            if (guna2TabControl1.SelectedTab.Name == "Script1")
            {
                ScriptBox.Text = settings.MainTab;
            }
            else if (guna2TabControl1.SelectedTab.Name == "Script2")
            {
                ScriptBox.Text = settings.tab1;
            }
            else if (guna2TabControl1.SelectedTab.Name == "Script3")
            {
                ScriptBox.Text = settings.tab2;
            }
            else if (guna2TabControl1.SelectedTab.Name == "Script4")
            {
                ScriptBox.Text = settings.tab3;
            }
            else if (guna2TabControl1.SelectedTab.Name == "Script5")
            {
                ScriptBox.Text = settings.tab4;
            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            try
            {
                AddTab(1);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        public void AddTab(int tabcount)
        {
            for (int i = 1; i < tabcount + 1; i++)
            {
                TabPage newTab = new TabPage();
                newTab.Name = "Script" + (guna2TabControl1.TabCount + 1);
                newTab.Text = "New Tab" + guna2TabControl1.TabCount;
                newTab.Parent = guna2TabControl1;
                newTab.Margin = new System.Windows.Forms.Padding(0);
                newTab.Padding = new System.Windows.Forms.Padding(0);
                newTab.BackgroundImage = Script1.BackgroundImage;
                newTab.BackgroundImageLayout = ImageLayout.Zoom;
                newTab.BackColor = Script1.BackColor;
                

                ScriptBox.Parent = newTab;

                guna2TabControl1.SelectTab(newTab);

                ButtonRemoveTab.Left = ButtonRemoveTab.Left + 90;
                ButtonAddTab.Left = ButtonRemoveTab.Left + 20;

                if (guna2TabControl1.TabCount == 5)
                {
                    ButtonAddTab.Hide();
                }
                if (guna2TabControl1.TabCount > 1)
                {
                    ButtonRemoveTab.Show();
                }
            }
            settings.TabCount = guna2TabControl1.TabCount - 1;
            settings.Save();
        }

        private void ButtonRemoveTab_Click(object sender, EventArgs e)
        {
            RemoveTab();
        }
        public void RemoveTab()
        {
            try
            {
                if (guna2TabControl1.SelectedTab.Name == "Script1")
                {
                    settings.MainTab = "";
                    settings.Save();
                }
                else if (guna2TabControl1.SelectedTab.Name == "Script2")
                {
                    settings.tab1 = "";
                    settings.Save();
                }
                else if (guna2TabControl1.SelectedTab.Name == "Script3")
                {
                    settings.tab2 = "";
                    settings.Save();
                }
                else if (guna2TabControl1.SelectedTab.Name == "Script4")
                {
                    settings.tab3 = "";
                    settings.Save();
                }
                else if (guna2TabControl1.SelectedTab.Name == "Script5")
                {
                    settings.tab4 = "";
                    settings.Save();
                }
                if (guna2TabControl1.TabCount > 1)
                {
                    int i = guna2TabControl1.SelectedIndex;
                    guna2TabControl1.TabPages.Remove(guna2TabControl1.SelectedTab);
                    guna2TabControl1.SelectTab(i - 1);


                    ButtonRemoveTab.Left = ButtonRemoveTab.Left - 90;
                    ButtonAddTab.Left = ButtonRemoveTab.Left + 20;

                }

                if (guna2TabControl1.TabCount == 6)
                {
                    ButtonAddTab.Hide();
                }
                else
                {
                    ButtonAddTab.Show();
                }
                if (guna2TabControl1.TabCount == 1)
                {
                    ButtonRemoveTab.Hide();
                    ButtonAddTab.Location = new System.Drawing.Point(85, 0);
                }
                settings.TabCount = guna2TabControl1.TabCount - 1;
                settings.Save();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void ScriptBox_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            
        }

        private void timerSave_Tick(object sender, EventArgs e)
        {
            if (guna2TabControl1.SelectedTab.Name == "Script1")
            {
                settings.MainTab = ScriptBox.Text;
            }
            else if (guna2TabControl1.SelectedTab.Name == "Script2")
            {
                settings.tab1 = ScriptBox.Text;
            }
            else if (guna2TabControl1.SelectedTab.Name == "Script3")
            {
                settings.tab2 = ScriptBox.Text;
            }
            else if (guna2TabControl1.SelectedTab.Name == "Script4")
            {
                settings.tab3 = ScriptBox.Text;
            }
            else if (guna2TabControl1.SelectedTab.Name == "Script5")
            {
                settings.tab4 = ScriptBox.Text;
            }
            settings.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (settings.scriptboxImage.Trim() != "")
            {
                if (ScriptBox.BackgroundImage != Image.FromFile(settings.scriptboxImage))
                {
                    Script1.BackgroundImage = Image.FromFile(settings.scriptboxImage);
                }
            }
            if (settings.MainColor != Color.White)
            {
                if (this.BackColor != settings.MainColor)
                {
                    this.BackColor = settings.MainColor;
                    //guna2TabControl1.TabMenuBackColor = settings.MainColor;
                    Script1.BackColor = settings.MainColor;
                }
            }
            timer1.Interval = 2000;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            AddTab(settings.TabCount);
            ButtonAddTab.BackColor = guna2TabControl1.TabMenuBackColor;
            timer2.Stop();
        }
    }
}
