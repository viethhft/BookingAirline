namespace GUI.Views.View_User
{
    partial class FBuyTicketChild
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
            groupBox6 = new GroupBox();
            menuStrip1 = new MenuStrip();
            lọcToolStripMenuItem = new ToolStripMenuItem();
            hIỂNTHỊBỘLỌCToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox6.SuspendLayout();
            menuStrip1.SuspendLayout();
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
            guna2Button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(616, 22);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(217, 45);
            guna2Button1.TabIndex = 3;
            guna2Button1.Text = "PHỔ THÔNG";
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 10;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Goldenrod;
            guna2Button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(836, 22);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(217, 45);
            guna2Button2.TabIndex = 4;
            guna2Button2.Text = "THƯƠNG GIA";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(guna2Button2);
            groupBox6.Controls.Add(guna2Button1);
            groupBox6.Controls.Add(menuStrip1);
            groupBox6.Location = new Point(21, 12);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1064, 90);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { lọcToolStripMenuItem, hIỂNTHỊBỘLỌCToolStripMenuItem });
            menuStrip1.Location = new Point(18, 35);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(216, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // lọcToolStripMenuItem
            // 
            lọcToolStripMenuItem.Name = "lọcToolStripMenuItem";
            lọcToolStripMenuItem.Size = new Size(96, 20);
            lọcToolStripMenuItem.Text = "SẮP XẾP THEO";
            // 
            // hIỂNTHỊBỘLỌCToolStripMenuItem
            // 
            hIỂNTHỊBỘLỌCToolStripMenuItem.Name = "hIỂNTHỊBỘLỌCToolStripMenuItem";
            hIỂNTHỊBỘLỌCToolStripMenuItem.Size = new Size(112, 20);
            hIỂNTHỊBỘLỌCToolStripMenuItem.Text = "HIỂN THỊ BỘ LỌC";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(21, 108);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1088, 470);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // FBuyTicketChild
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 590);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox6);
            MainMenuStrip = menuStrip1;
            Name = "FBuyTicketChild";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FBuyTicketChild";
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private GroupBox groupBox6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem lọcToolStripMenuItem;
        private ToolStripMenuItem hIỂNTHỊBỘLỌCToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}