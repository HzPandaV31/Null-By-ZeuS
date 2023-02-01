
namespace Null
{
    partial class MainMenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelExit = new System.Windows.Forms.Panel();
            this.BtnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelSide = new System.Windows.Forms.Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximize)).BeginInit();
            this.panelSide.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Black;
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.panelExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 36);
            this.panelTop.TabIndex = 2;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panelExit
            // 
            this.panelExit.Controls.Add(this.BtnExit);
            this.panelExit.Controls.Add(this.BtnMinimize);
            this.panelExit.Controls.Add(this.BtnMaximize);
            this.panelExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelExit.Location = new System.Drawing.Point(717, 0);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(83, 36);
            this.panelExit.TabIndex = 12;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageActive = null;
            this.BtnExit.Location = new System.Drawing.Point(56, 7);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(20, 21);
            this.BtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnExit.TabIndex = 7;
            this.BtnExit.TabStop = false;
            this.BtnExit.Zoom = 15;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.Image")));
            this.BtnMinimize.ImageActive = null;
            this.BtnMinimize.Location = new System.Drawing.Point(10, 7);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(20, 21);
            this.BtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimize.TabIndex = 9;
            this.BtnMinimize.TabStop = false;
            this.BtnMinimize.Zoom = 15;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.BtnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximize.Image")));
            this.BtnMaximize.ImageActive = null;
            this.BtnMaximize.Location = new System.Drawing.Point(33, 7);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(20, 21);
            this.BtnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMaximize.TabIndex = 8;
            this.BtnMaximize.TabStop = false;
            this.BtnMaximize.Zoom = 15;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Black;
            this.panelSide.Controls.Add(this.guna2Panel3);
            this.panelSide.Controls.Add(this.guna2Panel2);
            this.panelSide.Controls.Add(this.guna2Panel1);
            this.panelSide.Controls.Add(this.guna2GradientButton2);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 36);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(60, 364);
            this.panelSide.TabIndex = 4;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.Controls.Add(this.guna2GradientButton4);
            this.guna2Panel3.Location = new System.Drawing.Point(0, 120);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(60, 45);
            this.guna2Panel3.TabIndex = 8;
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.Animated = true;
            this.guna2GradientButton4.AnimatedGIF = true;
            this.guna2GradientButton4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2GradientButton4.BorderRadius = 5;
            this.guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton4.Image")));
            this.guna2GradientButton4.ImageSize = new System.Drawing.Size(37, 37);
            this.guna2GradientButton4.Location = new System.Drawing.Point(8, 0);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.Size = new System.Drawing.Size(45, 45);
            this.guna2GradientButton4.TabIndex = 5;
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.guna2GradientButton3);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 65);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(60, 45);
            this.guna2Panel2.TabIndex = 7;
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Animated = true;
            this.guna2GradientButton3.AnimatedGIF = true;
            this.guna2GradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2GradientButton3.BorderRadius = 5;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton3.Image")));
            this.guna2GradientButton3.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2GradientButton3.Location = new System.Drawing.Point(8, 0);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(45, 45);
            this.guna2GradientButton3.TabIndex = 4;
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.guna2GradientButton1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(60, 45);
            this.guna2Panel1.TabIndex = 6;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AnimatedGIF = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2GradientButton1.BorderRadius = 5;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.Image")));
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2GradientButton1.Location = new System.Drawing.Point(8, 0);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(45, 45);
            this.guna2GradientButton1.TabIndex = 2;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.AnimatedGIF = true;
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2GradientButton2.BorderRadius = 5;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton2.Image")));
            this.guna2GradientButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2GradientButton2.Location = new System.Drawing.Point(8, 308);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(45, 45);
            this.guna2GradientButton2.TabIndex = 3;
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(60, 36);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(740, 364);
            this.panelMain.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximize)).EndInit();
            this.panelSide.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelExit;
        private Bunifu.Framework.UI.BunifuImageButton BtnExit;
        private Bunifu.Framework.UI.BunifuImageButton BtnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton BtnMaximize;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
    }
}

