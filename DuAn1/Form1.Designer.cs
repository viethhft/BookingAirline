﻿namespace DuAn1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btn_login = new Button();
            llb_forgot = new LinkLabel();
            llb_dki = new LinkLabel();
            cb_reme = new CheckBox();
            tb_pass = new TextBox();
            tb_user = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(llb_forgot);
            panel1.Controls.Add(llb_dki);
            panel1.Controls.Add(cb_reme);
            panel1.Controls.Add(tb_pass);
            panel1.Controls.Add(tb_user);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(497, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 524);
            panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_password_50;
            pictureBox3.Location = new Point(24, 211);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_email_50;
            pictureBox2.Location = new Point(27, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_airline_50;
            pictureBox1.Location = new Point(260, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.SkyBlue;
            btn_login.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Location = new Point(135, 403);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(133, 40);
            btn_login.TabIndex = 8;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = false;
            // 
            // llb_forgot
            // 
            llb_forgot.AutoSize = true;
            llb_forgot.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            llb_forgot.Location = new Point(274, 337);
            llb_forgot.Name = "llb_forgot";
            llb_forgot.Size = new Size(105, 17);
            llb_forgot.TabIndex = 7;
            llb_forgot.TabStop = true;
            llb_forgot.Text = "Quên mật khẩu?";
            // 
            // llb_dki
            // 
            llb_dki.AutoSize = true;
            llb_dki.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            llb_dki.Location = new Point(210, 338);
            llb_dki.Name = "llb_dki";
            llb_dki.Size = new Size(58, 17);
            llb_dki.TabIndex = 6;
            llb_dki.TabStop = true;
            llb_dki.Text = "Đăng ký";
            // 
            // cb_reme
            // 
            cb_reme.AutoSize = true;
            cb_reme.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cb_reme.Location = new Point(27, 337);
            cb_reme.Name = "cb_reme";
            cb_reme.Size = new Size(141, 21);
            cb_reme.TabIndex = 5;
            cb_reme.Text = "Ghi nhớ đăng nhập";
            cb_reme.UseVisualStyleBackColor = true;
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(27, 276);
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new Size(352, 27);
            tb_pass.TabIndex = 4;
            tb_pass.UseSystemPasswordChar = true;
            // 
            // tb_user
            // 
            tb_user.Location = new Point(27, 173);
            tb_user.Name = "tb_user";
            tb_user.Size = new Size(352, 27);
            tb_user.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(75, 227);
            label3.Name = "label3";
            label3.Size = new Size(82, 22);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(75, 136);
            label2.Name = "label2";
            label2.Size = new Size(116, 22);
            label2.TabIndex = 1;
            label2.Text = "Tên tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(102, 42);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(917, 656);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btn_login;
        private LinkLabel llb_forgot;
        private LinkLabel llb_dki;
        private CheckBox cb_reme;
        private TextBox tb_pass;
        private TextBox tb_user;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}