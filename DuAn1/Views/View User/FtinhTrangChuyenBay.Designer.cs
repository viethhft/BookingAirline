namespace GUI.Views.View_User
{
    partial class FtinhTrangChuyenBay
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbb_From = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbb_To = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.date_Start = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lb_ErrorNum = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_ErrorTo1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_ErrorDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_ErrorFrom1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_CodeFlight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(25, 23);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(251, 21);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "NHẬP THÔNG TIN CHUYẾN BAY";
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel5.Location = new Point(63, 60);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(216, 17);
            guna2HtmlLabel5.TabIndex = 11;
            guna2HtmlLabel5.Text = "Lưu ý: *Trường bắt buộc nhập thông tin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icons8_exclamation_mark_30;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(20, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 36);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(0, 95, 110);
            guna2Button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(167, 83);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 12;
            guna2Button1.Text = "HÀNH TRÌNH";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BackColor = SystemColors.Control;
            guna2Button2.BorderRadius = 3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.White;
            guna2Button2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Location = new Point(345, 83);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(188, 45);
            guna2Button2.TabIndex = 13;
            guna2Button2.Text = "SỐ HIỆU CHUYẾN BAY";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Location = new Point(33, 138);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(24, 17);
            guna2HtmlLabel2.TabIndex = 14;
            guna2HtmlLabel2.Text = "Từ *";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel3.Location = new Point(391, 136);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(34, 17);
            guna2HtmlLabel3.TabIndex = 15;
            guna2HtmlLabel3.Text = "Đến *";
            // 
            // cbb_From
            // 
            cbb_From.BackColor = Color.Transparent;
            cbb_From.DrawMode = DrawMode.OwnerDrawFixed;
            cbb_From.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_From.FocusedColor = Color.FromArgb(94, 148, 255);
            cbb_From.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbb_From.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_From.ForeColor = Color.FromArgb(68, 88, 112);
            cbb_From.ItemHeight = 30;
            cbb_From.Location = new Point(33, 161);
            cbb_From.Name = "cbb_From";
            cbb_From.Size = new Size(314, 36);
            cbb_From.TabIndex = 16;
            cbb_From.SelectedIndexChanged += cbb_From_SelectedIndexChanged;
            // 
            // cbb_To
            // 
            this.cbb_To.BackColor = System.Drawing.Color.Transparent;
            this.cbb_To.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_To.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_To.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_To.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_To.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_To.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_To.ItemHeight = 30;
            this.cbb_To.Location = new System.Drawing.Point(391, 161);
            this.cbb_To.Name = "cbb_To";
            this.cbb_To.Size = new System.Drawing.Size(314, 36);
            this.cbb_To.TabIndex = 17;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel4.Location = new Point(33, 232);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(97, 17);
            guna2HtmlLabel4.TabIndex = 18;
            guna2HtmlLabel4.Text = "Ngày khởi hành *";
            // 
            // date_Start
            // 
            this.date_Start.Checked = true;
            this.date_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.date_Start.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Start.Location = new System.Drawing.Point(33, 255);
            this.date_Start.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_Start.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_Start.Name = "date_Start";
            this.date_Start.Size = new System.Drawing.Size(314, 34);
            this.date_Start.TabIndex = 19;
            this.date_Start.Value = new System.DateTime(2023, 7, 21, 22, 43, 43, 189);
            this.date_Start.ValueChanged += new System.EventHandler(this.date_Start_ValueChanged);
            // 
            // lb_ErrorNum
            // 
            lb_ErrorNum.BackColor = Color.Transparent;
            lb_ErrorNum.Location = new Point(33, 204);
            lb_ErrorNum.Name = "lb_ErrorNum";
            lb_ErrorNum.Size = new Size(71, 17);
            lb_ErrorNum.TabIndex = 20;
            lb_ErrorNum.Text = "THÔNG BÁO";
            // 
            // lb_ErrorTo1
            // 
            this.lb_ErrorTo1.BackColor = System.Drawing.Color.Transparent;
            this.lb_ErrorTo1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ErrorTo1.Location = new System.Drawing.Point(391, 203);
            this.lb_ErrorTo1.Name = "lb_ErrorTo1";
            this.lb_ErrorTo1.Size = new System.Drawing.Size(73, 17);
            this.lb_ErrorTo1.TabIndex = 21;
            this.lb_ErrorTo1.Text = "THÔNG BÁO";
            // 
            // lb_ErrorDate
            // 
            lb_ErrorDate.BackColor = Color.Transparent;
            lb_ErrorDate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ErrorDate.Location = new Point(33, 295);
            lb_ErrorDate.Name = "lb_ErrorDate";
            lb_ErrorDate.Size = new Size(73, 17);
            lb_ErrorDate.TabIndex = 22;
            lb_ErrorDate.Text = "THÔNG BÁO";
            // 
            // guna2HtmlLabel9
            // 
            guna2HtmlLabel9.BackColor = Color.Transparent;
            guna2HtmlLabel9.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel9.Location = new Point(33, 138);
            guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            guna2HtmlLabel9.Size = new Size(114, 17);
            guna2HtmlLabel9.TabIndex = 24;
            guna2HtmlLabel9.Text = "Số hiệu chuyến bay*";
            // 
            // lb_ErrorFrom1
            // 
            this.lb_ErrorFrom1.BackColor = System.Drawing.Color.Transparent;
            this.lb_ErrorFrom1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ErrorFrom1.Location = new System.Drawing.Point(110, 204);
            this.lb_ErrorFrom1.Name = "lb_ErrorFrom1";
            this.lb_ErrorFrom1.Size = new System.Drawing.Size(73, 17);
            this.lb_ErrorFrom1.TabIndex = 25;
            this.lb_ErrorFrom1.Text = "THÔNG BÁO";
            // 
            // btn_Search
            // 
            btn_Search.BorderColor = Color.FromArgb(123, 90, 4);
            btn_Search.BorderRadius = 10;
            btn_Search.BorderThickness = 1;
            btn_Search.Cursor = Cursors.Hand;
            btn_Search.DisabledState.BorderColor = Color.DarkGray;
            btn_Search.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Search.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Search.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Search.FillColor = Color.Empty;
            btn_Search.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Search.ForeColor = Color.FromArgb(123, 90, 4);
            btn_Search.Location = new Point(481, 346);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(180, 45);
            btn_Search.TabIndex = 26;
            btn_Search.Text = "TÌM KIẾM";
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_CodeFlight
            // 
            this.txt_CodeFlight.Location = new System.Drawing.Point(391, 255);
            this.txt_CodeFlight.Multiline = true;
            this.txt_CodeFlight.Name = "txt_CodeFlight";
            this.txt_CodeFlight.Size = new System.Drawing.Size(314, 36);
            this.txt_CodeFlight.TabIndex = 27;
            // 
            // FtinhTrangChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.txt_CodeFlight);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lb_ErrorFrom1);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.lb_ErrorDate);
            this.Controls.Add(this.lb_ErrorTo1);
            this.Controls.Add(this.lb_ErrorNum);
            this.Controls.Add(this.date_Start);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.cbb_To);
            this.Controls.Add(this.cbb_From);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "FtinhTrangChuyenBay";
            this.Text = "FtinhTrangChuyenBay";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_From;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_To;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_Start;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorNum;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorTo1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorFrom1;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private TextBox txt_CodeFlight;
    }
}