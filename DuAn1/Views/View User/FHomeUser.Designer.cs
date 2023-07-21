namespace GUI.Views
{
    partial class FHomeUser
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
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            SuspendLayout();
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.DarkCyan;
            guna2Button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = Properties.Resources.icons8_plane_30__3_1;
            guna2Button1.Location = new Point(12, 12);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(192, 45);
            guna2Button1.TabIndex = 0;
            guna2Button1.Text = "MUA VÉ TRỰC TUYẾN";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 10;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.DarkCyan;
            guna2Button2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Image = Properties.Resources.icons8_menu_301;
            guna2Button2.Location = new Point(209, 12);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(193, 45);
            guna2Button2.TabIndex = 1;
            guna2Button2.Text = "QUẢN LÝ CHUYẾN BAY";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2Button3
            // 
            guna2Button3.BorderRadius = 10;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.DarkCyan;
            guna2Button3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Image = Properties.Resources.icons8_clock_30__1_2;
            guna2Button3.Location = new Point(408, 12);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.Size = new Size(211, 45);
            guna2Button3.TabIndex = 2;
            guna2Button3.Text = "TÌNH TRẠNG CHUYẾN BAY";
            guna2Button3.Click += guna2Button3_Click;
            // 
            // guna2Button4
            // 
            guna2Button4.BorderRadius = 10;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.DarkCyan;
            guna2Button4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button4.ForeColor = Color.White;
            guna2Button4.Image = Properties.Resources.icons8_date_30__1_2;
            guna2Button4.Location = new Point(625, 12);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.Size = new Size(189, 45);
            guna2Button4.TabIndex = 3;
            guna2Button4.Text = "LỊCH BAY";
            guna2Button4.Click += guna2Button4_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Location = new Point(12, 63);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(802, 468);
            guna2Panel1.TabIndex = 4;
            // 
            // FHomeUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 545);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2Button4);
            Controls.Add(guna2Button3);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            MaximizeBox = false;
            Name = "FHomeUser";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}