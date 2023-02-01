
namespace Null
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelExit = new System.Windows.Forms.Panel();
            this.BtnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnShow = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxRemember = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.ButtonReg = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ButtonLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TextBoxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximize)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnShow)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(315, 36);
            this.panelTop.TabIndex = 3;
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
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panelExit
            // 
            this.panelExit.Controls.Add(this.BtnExit);
            this.panelExit.Controls.Add(this.BtnMinimize);
            this.panelExit.Controls.Add(this.BtnMaximize);
            this.panelExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelExit.Location = new System.Drawing.Point(232, 0);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.BtnShow);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CheckBoxRemember);
            this.panel1.Controls.Add(this.ButtonReg);
            this.panel1.Controls.Add(this.ButtonLogin);
            this.panel1.Controls.Add(this.TextBoxPass);
            this.panel1.Controls.Add(this.TextBoxUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 317);
            this.panel1.TabIndex = 35;
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BtnShow.Image = global::Null.Properties.Resources.hide1_30px;
            this.BtnShow.ImageActive = null;
            this.BtnShow.Location = new System.Drawing.Point(208, 117);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(36, 23);
            this.BtnShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnShow.TabIndex = 54;
            this.BtnShow.TabStop = false;
            this.BtnShow.Zoom = 0;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Remember me";
            // 
            // CheckBoxRemember
            // 
            this.CheckBoxRemember.Animated = true;
            this.CheckBoxRemember.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxRemember.CheckedState.BorderRadius = 2;
            this.CheckBoxRemember.CheckedState.BorderThickness = 0;
            this.CheckBoxRemember.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBoxRemember.Location = new System.Drawing.Point(77, 162);
            this.CheckBoxRemember.Name = "CheckBoxRemember";
            this.CheckBoxRemember.Size = new System.Drawing.Size(20, 20);
            this.CheckBoxRemember.TabIndex = 39;
            this.CheckBoxRemember.Text = "guna2CustomCheckBox2";
            this.CheckBoxRemember.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBoxRemember.UncheckedState.BorderRadius = 2;
            this.CheckBoxRemember.UncheckedState.BorderThickness = 0;
            this.CheckBoxRemember.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // ButtonReg
            // 
            this.ButtonReg.Animated = true;
            this.ButtonReg.AnimatedGIF = true;
            this.ButtonReg.AutoRoundedCorners = true;
            this.ButtonReg.BorderColor = System.Drawing.Color.White;
            this.ButtonReg.BorderRadius = 15;
            this.ButtonReg.BorderThickness = 2;
            this.ButtonReg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonReg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonReg.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonReg.Enabled = false;
            this.ButtonReg.FillColor = System.Drawing.Color.Black;
            this.ButtonReg.FillColor2 = System.Drawing.Color.Black;
            this.ButtonReg.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonReg.ForeColor = System.Drawing.Color.White;
            this.ButtonReg.Location = new System.Drawing.Point(90, 257);
            this.ButtonReg.Name = "ButtonReg";
            this.ButtonReg.Size = new System.Drawing.Size(136, 32);
            this.ButtonReg.TabIndex = 38;
            this.ButtonReg.Text = "Register";
            this.ButtonReg.Click += new System.EventHandler(this.ButtonReg_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Animated = true;
            this.ButtonLogin.AnimatedGIF = true;
            this.ButtonLogin.AutoRoundedCorners = true;
            this.ButtonLogin.BorderColor = System.Drawing.Color.White;
            this.ButtonLogin.BorderRadius = 17;
            this.ButtonLogin.BorderThickness = 2;
            this.ButtonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonLogin.FillColor = System.Drawing.Color.Black;
            this.ButtonLogin.FillColor2 = System.Drawing.Color.Black;
            this.ButtonLogin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(66, 210);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(186, 36);
            this.ButtonLogin.TabIndex = 37;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Animated = true;
            this.TextBoxPass.AutoRoundedCorners = true;
            this.TextBoxPass.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxPass.BorderColor = System.Drawing.Color.Black;
            this.TextBoxPass.BorderRadius = 16;
            this.TextBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPass.DefaultText = "";
            this.TextBoxPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.TextBoxPass.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.TextBoxPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.TextBoxPass.ForeColor = System.Drawing.Color.White;
            this.TextBoxPass.HoverState.BorderColor = System.Drawing.Color.White;
            this.TextBoxPass.Location = new System.Drawing.Point(65, 111);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '*';
            this.TextBoxPass.PlaceholderText = "Password";
            this.TextBoxPass.SelectedText = "";
            this.TextBoxPass.Size = new System.Drawing.Size(186, 35);
            this.TextBoxPass.TabIndex = 36;
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.Animated = true;
            this.TextBoxUser.AutoRoundedCorners = true;
            this.TextBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxUser.BorderColor = System.Drawing.Color.Black;
            this.TextBoxUser.BorderRadius = 16;
            this.TextBoxUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUser.DefaultText = "";
            this.TextBoxUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.TextBoxUser.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.TextBoxUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.TextBoxUser.ForeColor = System.Drawing.Color.White;
            this.TextBoxUser.HoverState.BorderColor = System.Drawing.Color.White;
            this.TextBoxUser.Location = new System.Drawing.Point(65, 43);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.PasswordChar = '\0';
            this.TextBoxUser.PlaceholderText = "Username";
            this.TextBoxUser.SelectedText = "";
            this.TextBoxUser.Size = new System.Drawing.Size(186, 35);
            this.TextBoxUser.TabIndex = 35;
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.AnimateWindow = true;
            this.guna2BorderlessForm2.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_POSITIVE;
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.ResizeForm = false;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(315, 353);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.login_MouseMove);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelExit;
        private Bunifu.Framework.UI.BunifuImageButton BtnExit;
        private Bunifu.Framework.UI.BunifuImageButton BtnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton BtnMaximize;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox CheckBoxRemember;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonReg;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonLogin;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPass;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUser;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton BtnShow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}