namespace GUI.Views.View_User
{
    partial class FAfterSeat
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(10, 9);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1041, 487);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BorderRadius = 10;
            button1.DisabledState.BorderColor = Color.DarkGray;
            button1.DisabledState.CustomBorderColor = Color.DarkGray;
            button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button1.FillColor = Color.DarkCyan;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(348, 508);
            button1.Name = "button1";
            button1.Size = new Size(180, 45);
            button1.TabIndex = 2;
            button1.Text = "Thanh toán";
            button1.Click += button1_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 10;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(230, 67, 55);
            guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(548, 508);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(180, 45);
            guna2Button2.TabIndex = 3;
            guna2Button2.Text = "Hủy";
            // 
            // FAfterSeat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 557);
            Controls.Add(guna2Button2);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FAfterSeat";
            Text = "Thông tin vé đặt";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}