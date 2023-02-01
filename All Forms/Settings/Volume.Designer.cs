namespace Null
{
    partial class Volume
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
            this.TrackBarFpsLimit = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TrackBar2 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TrackBar3 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TrackBarFpsLimit
            // 
            this.TrackBarFpsLimit.Location = new System.Drawing.Point(17, 37);
            this.TrackBarFpsLimit.Name = "TrackBarFpsLimit";
            this.TrackBarFpsLimit.Size = new System.Drawing.Size(434, 23);
            this.TrackBarFpsLimit.TabIndex = 50;
            this.TrackBarFpsLimit.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.TrackBarFpsLimit.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBarFpsLimit_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Master Volume";
            // 
            // guna2TrackBar1
            // 
            this.guna2TrackBar1.Location = new System.Drawing.Point(17, 124);
            this.guna2TrackBar1.Name = "guna2TrackBar1";
            this.guna2TrackBar1.Size = new System.Drawing.Size(434, 23);
            this.guna2TrackBar1.TabIndex = 52;
            this.guna2TrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Click Sound";
            // 
            // guna2TrackBar2
            // 
            this.guna2TrackBar2.Location = new System.Drawing.Point(17, 178);
            this.guna2TrackBar2.Name = "guna2TrackBar2";
            this.guna2TrackBar2.Size = new System.Drawing.Size(434, 23);
            this.guna2TrackBar2.TabIndex = 54;
            this.guna2TrackBar2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Effect Sounds";
            // 
            // guna2TrackBar3
            // 
            this.guna2TrackBar3.Location = new System.Drawing.Point(17, 232);
            this.guna2TrackBar3.Name = "guna2TrackBar3";
            this.guna2TrackBar3.Size = new System.Drawing.Size(434, 23);
            this.guna2TrackBar3.TabIndex = 56;
            this.guna2TrackBar3.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = "Notification Sound";
            // 
            // Volume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(563, 364);
            this.Controls.Add(this.guna2TrackBar3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2TrackBar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2TrackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrackBarFpsLimit);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Volume";
            this.Text = "Audio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TrackBar TrackBarFpsLimit;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar3;
        private System.Windows.Forms.Label label3;
    }
}