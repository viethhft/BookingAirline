namespace GUI.Views.View_User
{
    partial class FthanhToan
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
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(153, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 211);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(153, 285);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(118, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Tôi đã thanh toán";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.DarkCyan;
            guna2Button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(153, 328);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "Xác nhận";
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 10;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.DarkCyan;
            guna2Button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(153, 393);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(180, 45);
            guna2Button2.TabIndex = 3;
            guna2Button2.Text = "Hủy";
            // 
            // FthanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 450);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Name = "FthanhToan";
            Text = "Thanh Toán";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}