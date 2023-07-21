namespace GUI.Views
{
    partial class FwatchFlight
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
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.Controls.Add(guna2Button1);
            guna2GroupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2GroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
            guna2GroupBox1.Location = new Point(12, 7);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.Size = new Size(1040, 114);
            guna2GroupBox1.TabIndex = 1;
            guna2GroupBox1.Text = "Chuyến bay chiều đi";
            // 
            // guna2Panel1
            // 
            guna2Panel1.Location = new Point(12, 127);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(1040, 542);
            guna2Panel1.TabIndex = 2;
            // 
            // guna2Button1
            // 
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(14, 55);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(106, 45);
            guna2Button1.TabIndex = 0;
            guna2Button1.Text = "21 Thg7 1,724,000 VNĐ";
            guna2Button1.Tile = true;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // FwatchFlight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2GroupBox1);
            Name = "FwatchFlight";
            Text = "FwatchFlight";
            guna2GroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}