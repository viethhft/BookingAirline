namespace DuAn1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.llb_forgot = new System.Windows.Forms.LinkLabel();
            this.llb_dki = new System.Windows.Forms.LinkLabel();
            this.cb_reme = new System.Windows.Forms.CheckBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.llb_forgot);
            this.panel1.Controls.Add(this.llb_dki);
            this.panel1.Controls.Add(this.cb_reme);
            this.panel1.Controls.Add(this.tb_pass);
            this.panel1.Controls.Add(this.tb_user);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(433, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 393);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DuAn1.Properties.Resources.icons8_password_50;
            this.pictureBox3.Location = new System.Drawing.Point(24, 166);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DuAn1.Properties.Resources.icons8_email_50;
            this.pictureBox2.Location = new System.Drawing.Point(24, 90);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DuAn1.Properties.Resources.icons8_airline_50;
            this.pictureBox1.Location = new System.Drawing.Point(228, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_login.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(118, 302);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(116, 30);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // llb_forgot
            // 
            this.llb_forgot.AutoSize = true;
            this.llb_forgot.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llb_forgot.Location = new System.Drawing.Point(247, 256);
            this.llb_forgot.Name = "llb_forgot";
            this.llb_forgot.Size = new System.Drawing.Size(85, 13);
            this.llb_forgot.TabIndex = 7;
            this.llb_forgot.TabStop = true;
            this.llb_forgot.Text = "Quên mật khẩu?";
            this.llb_forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_forgot_LinkClicked);
            this.llb_forgot.MouseLeave += new System.EventHandler(this.llb_forgot_MouseLeave);
            this.llb_forgot.MouseHover += new System.EventHandler(this.llb_forgot_MouseHover);
            this.llb_forgot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.llb_forgot_MouseMove);
            // 
            // llb_dki
            // 
            this.llb_dki.AutoSize = true;
            this.llb_dki.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llb_dki.Location = new System.Drawing.Point(194, 256);
            this.llb_dki.Name = "llb_dki";
            this.llb_dki.Size = new System.Drawing.Size(47, 13);
            this.llb_dki.TabIndex = 6;
            this.llb_dki.TabStop = true;
            this.llb_dki.Text = "Đăng ký";
            this.llb_dki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_dki_LinkClicked);
            this.llb_dki.MouseLeave += new System.EventHandler(this.llb_dki_MouseLeave);
            this.llb_dki.MouseHover += new System.EventHandler(this.llb_dki_MouseHover);
            this.llb_dki.MouseMove += new System.Windows.Forms.MouseEventHandler(this.llb_dki_MouseMove);
            // 
            // cb_reme
            // 
            this.cb_reme.AutoSize = true;
            this.cb_reme.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_reme.Location = new System.Drawing.Point(24, 253);
            this.cb_reme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_reme.Name = "cb_reme";
            this.cb_reme.Size = new System.Drawing.Size(133, 20);
            this.cb_reme.TabIndex = 5;
            this.cb_reme.Text = "Ghi nhớ đăng nhập";
            this.cb_reme.UseVisualStyleBackColor = true;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(24, 207);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(308, 23);
            this.tb_pass.TabIndex = 4;
            this.tb_pass.UseSystemPasswordChar = true;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(24, 130);
            this.tb_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(308, 23);
            this.tb_user.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(66, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(66, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(102, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DuAn1.Properties.Resources.design;
            this.ClientSize = new System.Drawing.Size(802, 492);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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