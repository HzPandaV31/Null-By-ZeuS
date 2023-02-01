namespace Null
{
    partial class register
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnShow = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxDc = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ButtonRegister = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TextBoxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnShow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.BtnShow);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TextBoxDc);
            this.panel2.Controls.Add(this.ButtonLogin);
            this.panel2.Controls.Add(this.ButtonRegister);
            this.panel2.Controls.Add(this.TextBoxPass);
            this.panel2.Controls.Add(this.TextBoxUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 317);
            this.panel2.TabIndex = 37;
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BtnShow.Image = global::Null.Properties.Resources.hide1_30px;
            this.BtnShow.ImageActive = null;
            this.BtnShow.Location = new System.Drawing.Point(208, 102);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(36, 23);
            this.BtnShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnShow.TabIndex = 53;
            this.BtnShow.TabStop = false;
            this.BtnShow.Zoom = 0;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "Discord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Username";
            // 
            // TextBoxDc
            // 
            this.TextBoxDc.Animated = true;
            this.TextBoxDc.AutoRoundedCorners = true;
            this.TextBoxDc.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxDc.BorderColor = System.Drawing.Color.Black;
            this.TextBoxDc.BorderRadius = 16;
            this.TextBoxDc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDc.DefaultText = "";
            this.TextBoxDc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxDc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxDc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.TextBoxDc.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.TextBoxDc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.TextBoxDc.ForeColor = System.Drawing.Color.White;
            this.TextBoxDc.HoverState.BorderColor = System.Drawing.Color.White;
            this.TextBoxDc.Location = new System.Drawing.Point(66, 158);
            this.TextBoxDc.Name = "TextBoxDc";
            this.TextBoxDc.PasswordChar = '\0';
            this.TextBoxDc.PlaceholderText = "Discord Nick (optional)";
            this.TextBoxDc.SelectedText = "";
            this.TextBoxDc.Size = new System.Drawing.Size(186, 35);
            this.TextBoxDc.TabIndex = 43;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Animated = true;
            this.ButtonLogin.AnimatedGIF = true;
            this.ButtonLogin.AutoRoundedCorners = true;
            this.ButtonLogin.BorderColor = System.Drawing.Color.White;
            this.ButtonLogin.BorderRadius = 15;
            this.ButtonLogin.BorderThickness = 2;
            this.ButtonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.ButtonLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.ButtonLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.ButtonLogin.Location = new System.Drawing.Point(90, 257);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(136, 32);
            this.ButtonLogin.TabIndex = 42;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonReg_Click);
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.Animated = true;
            this.ButtonRegister.AnimatedGIF = true;
            this.ButtonRegister.AutoRoundedCorners = true;
            this.ButtonRegister.BorderColor = System.Drawing.Color.White;
            this.ButtonRegister.BorderRadius = 17;
            this.ButtonRegister.BorderThickness = 2;
            this.ButtonRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonRegister.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonRegister.Enabled = false;
            this.ButtonRegister.FillColor = System.Drawing.Color.Empty;
            this.ButtonRegister.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.ButtonRegister.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.ButtonRegister.ForeColor = System.Drawing.Color.White;
            this.ButtonRegister.Location = new System.Drawing.Point(66, 210);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(186, 36);
            this.ButtonRegister.TabIndex = 41;
            this.ButtonRegister.Text = "Register";
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonLogin_Click);
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
            this.TextBoxPass.Location = new System.Drawing.Point(66, 96);
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
            this.TextBoxUser.Location = new System.Drawing.Point(66, 34);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.PasswordChar = '\0';
            this.TextBoxUser.PlaceholderText = "Username";
            this.TextBoxUser.SelectedText = "";
            this.TextBoxUser.Size = new System.Drawing.Size(186, 35);
            this.TextBoxUser.TabIndex = 35;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this.BtnShow;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 317);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPass;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUser;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonLogin;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonRegister;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton BtnShow;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}