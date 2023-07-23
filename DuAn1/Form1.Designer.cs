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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
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
            panel1.Location = new Point(433, 56);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 393);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(109, 25);
            label5.Name = "label5";
            label5.Size = new Size(132, 24);
            label5.TabIndex = 12;
            label5.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = GUI.Properties.Resources.icons8_password_50;
            pictureBox3.Location = new Point(24, 166);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = GUI.Properties.Resources.icons8_email_50;
            pictureBox2.Location = new Point(24, 90);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GUI.Properties.Resources.icons8_airline_50;
            pictureBox1.Location = new Point(247, 21);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
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
            llb_forgot.AutoSize = true;
            llb_forgot.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            llb_forgot.Location = new Point(247, 256);
            llb_forgot.Name = "llb_forgot";
            llb_forgot.Size = new Size(85, 13);
            llb_forgot.TabIndex = 7;
            llb_forgot.TabStop = true;
            llb_forgot.Text = "Quên mật khẩu?";
            llb_forgot.LinkClicked += llb_forgot_LinkClicked;
            // 
            // llb_dki
            // 
            llb_dki.AutoSize = true;
            llb_dki.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            llb_dki.Location = new Point(200, 256);
            llb_dki.Name = "llb_dki";
            llb_dki.Size = new Size(47, 13);
            llb_dki.TabIndex = 6;
            llb_dki.TabStop = true;
            llb_dki.Text = "Đăng ký";
            llb_dki.LinkClicked += llb_dki_LinkClicked;
            // 
            // cb_reme
            // 
            cb_reme.AutoSize = true;
            cb_reme.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cb_reme.Location = new Point(24, 253);
            cb_reme.Margin = new Padding(3, 2, 3, 2);
            cb_reme.Name = "cb_reme";
            cb_reme.Size = new Size(133, 20);
            cb_reme.TabIndex = 5;
            cb_reme.Text = "Ghi nhớ đăng nhập";
            cb_reme.UseVisualStyleBackColor = true;
            cb_reme.CheckedChanged += cb_reme_CheckedChanged;
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(24, 207);
            tb_pass.Margin = new Padding(3, 2, 3, 2);
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new Size(308, 23);
            tb_pass.TabIndex = 4;
            tb_pass.UseSystemPasswordChar = true;
            // 
            // tb_user
            // 
            tb_user.Location = new Point(24, 130);
            tb_user.Margin = new Padding(3, 2, 3, 2);
            tb_user.Name = "tb_user";
            tb_user.Size = new Size(308, 23);
            tb_user.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(66, 167);
            label3.Name = "label3";
            label3.Size = new Size(92, 24);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(66, 91);
            label2.Name = "label2";
            label2.Size = new Size(59, 24);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Image = GUI.Properties.Resources.Untitled_13;
            label1.Location = new Point(14, 179);
            label1.Name = "label1";
            label1.Size = new Size(379, 145);
            label1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(798, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chào mừng bạn đến với hãng hàng không Quốc gia Việt Nam Airline";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GUI.Properties.Resources.design;
            this.ClientSize = new System.Drawing.Size(802, 452);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
    }
    //<<<<<<< HEAD

}