namespace DuAn1.Views
{
    partial class fStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStaff));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pn_chil = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1277, 179);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 522);
            panel1.TabIndex = 1;
            // 
            // button6
            // 
            button6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(3, 461);
            button6.Name = "button6";
            button6.Size = new Size(194, 48);
            button6.TabIndex = 5;
            button6.Text = "Hệ thống";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(3, 377);
            button5.Name = "button5";
            button5.Size = new Size(194, 48);
            button5.TabIndex = 4;
            button5.Text = "Quản lý khách hàng";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(3, 289);
            button4.Name = "button4";
            button4.Size = new Size(194, 48);
            button4.TabIndex = 3;
            button4.Text = "Quản lý chuyến bay";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(3, 193);
            button3.Name = "button3";
            button3.Size = new Size(194, 48);
            button3.TabIndex = 2;
            button3.Text = "Quản lý vé";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(3, 107);
            button2.Name = "button2";
            button2.Size = new Size(194, 48);
            button2.TabIndex = 1;
            button2.Text = "Quản lý doanh thu";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 19);
            button1.Name = "button1";
            button1.Size = new Size(194, 48);
            button1.TabIndex = 0;
            button1.Text = "Quản lý nhân viên";
            button1.UseVisualStyleBackColor = true;
            // 
            // pn_chil
            // 
            pn_chil.Location = new Point(209, 186);
            pn_chil.Name = "pn_chil";
            pn_chil.Size = new Size(1071, 522);
            pn_chil.TabIndex = 2;
            // 
            // fStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 720);
            Controls.Add(pn_chil);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fStaff";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel pn_chil;
    }
}