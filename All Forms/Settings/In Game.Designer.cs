namespace Null
{
    partial class In_Game
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
            this.label4 = new System.Windows.Forms.Label();
            this.TrackBarFpsLimit = new Guna.UI2.WinForms.Guna2TrackBar();
            this.labelFps = new System.Windows.Forms.Label();
            this.SwitchFpsUnlocker = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch2 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch4 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch5 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Fps Limit";
            // 
            // TrackBarFpsLimit
            // 
            this.TrackBarFpsLimit.Enabled = false;
            this.TrackBarFpsLimit.Location = new System.Drawing.Point(28, 95);
            this.TrackBarFpsLimit.Minimum = 1;
            this.TrackBarFpsLimit.Name = "TrackBarFpsLimit";
            this.TrackBarFpsLimit.Size = new System.Drawing.Size(209, 23);
            this.TrackBarFpsLimit.TabIndex = 48;
            this.TrackBarFpsLimit.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.TrackBarFpsLimit.Value = 60;
            this.TrackBarFpsLimit.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBarFpsLimit_Scroll);
            // 
            // labelFps
            // 
            this.labelFps.AutoSize = true;
            this.labelFps.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFps.ForeColor = System.Drawing.Color.White;
            this.labelFps.Location = new System.Drawing.Point(205, 67);
            this.labelFps.Name = "labelFps";
            this.labelFps.Size = new System.Drawing.Size(32, 25);
            this.labelFps.TabIndex = 49;
            this.labelFps.Text = "60";
            // 
            // SwitchFpsUnlocker
            // 
            this.SwitchFpsUnlocker.Animated = true;
            this.SwitchFpsUnlocker.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.SwitchFpsUnlocker.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.SwitchFpsUnlocker.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SwitchFpsUnlocker.CheckedState.InnerColor = System.Drawing.Color.White;
            this.SwitchFpsUnlocker.Location = new System.Drawing.Point(151, 26);
            this.SwitchFpsUnlocker.Name = "SwitchFpsUnlocker";
            this.SwitchFpsUnlocker.Size = new System.Drawing.Size(35, 20);
            this.SwitchFpsUnlocker.TabIndex = 54;
            this.SwitchFpsUnlocker.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SwitchFpsUnlocker.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SwitchFpsUnlocker.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SwitchFpsUnlocker.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.SwitchFpsUnlocker.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Fps Unlocker";
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.Animated = true;
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(107, 170);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch1.TabIndex = 56;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Anti Afk";
            // 
            // guna2ToggleSwitch2
            // 
            this.guna2ToggleSwitch2.Animated = true;
            this.guna2ToggleSwitch2.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.guna2ToggleSwitch2.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.guna2ToggleSwitch2.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.Location = new System.Drawing.Point(139, 257);
            this.guna2ToggleSwitch2.Name = "guna2ToggleSwitch2";
            this.guna2ToggleSwitch2.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch2.TabIndex = 58;
            this.guna2ToggleSwitch2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch2.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch2.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch2_CheckedChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "Anti Logger";
            // 
            // guna2ToggleSwitch4
            // 
            this.guna2ToggleSwitch4.Animated = true;
            this.guna2ToggleSwitch4.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.guna2ToggleSwitch4.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.guna2ToggleSwitch4.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch4.Location = new System.Drawing.Point(64, 214);
            this.guna2ToggleSwitch4.Name = "guna2ToggleSwitch4";
            this.guna2ToggleSwitch4.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch4.TabIndex = 62;
            this.guna2ToggleSwitch4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch4.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch4.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch4.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch4_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 25);
            this.label6.TabIndex = 61;
            this.label6.Text = "Fly";
            // 
            // guna2ToggleSwitch5
            // 
            this.guna2ToggleSwitch5.Animated = true;
            this.guna2ToggleSwitch5.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.guna2ToggleSwitch5.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.guna2ToggleSwitch5.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch5.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch5.Location = new System.Drawing.Point(99, 301);
            this.guna2ToggleSwitch5.Name = "guna2ToggleSwitch5";
            this.guna2ToggleSwitch5.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch5.TabIndex = 64;
            this.guna2ToggleSwitch5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch5.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch5.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch5.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch5_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 63;
            this.label7.Text = "NoClip";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // In_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(563, 364);
            this.Controls.Add(this.guna2ToggleSwitch5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2ToggleSwitch4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2ToggleSwitch2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2ToggleSwitch1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SwitchFpsUnlocker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelFps);
            this.Controls.Add(this.TrackBarFpsLimit);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "In_Game";
            this.Text = "In_Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBarFpsLimit;
        private System.Windows.Forms.Label labelFps;
        private Guna.UI2.WinForms.Guna2ToggleSwitch SwitchFpsUnlocker;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch4;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}