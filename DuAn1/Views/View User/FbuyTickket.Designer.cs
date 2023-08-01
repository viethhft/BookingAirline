namespace GUI.Views.View_User
{
    partial class FbuyTickket
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
            btn_OneWay = new Guna.UI2.WinForms.Guna2Button();
            btn_TwoWay = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            date_To = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txt_Discount = new TextBox();
            lb_ErrorTo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lb_ErrorFrom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btn_Search = new Guna.UI2.WinForms.Guna2Button();
            date_From = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbb_To = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbb_From = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pictureBox2 = new PictureBox();
            btn_discount = new Guna.UI2.WinForms.Guna2Button();
            lb_dateFrom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lb_dateTo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_OneWay
            // 
            this.btn_OneWay.BorderRadius = 10;
            this.btn_OneWay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_OneWay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_OneWay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_OneWay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_OneWay.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_OneWay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_OneWay.ForeColor = System.Drawing.Color.Black;
            this.btn_OneWay.Location = new System.Drawing.Point(12, 12);
            this.btn_OneWay.Name = "btn_OneWay";
            this.btn_OneWay.Size = new System.Drawing.Size(180, 45);
            this.btn_OneWay.TabIndex = 0;
            this.btn_OneWay.Text = "MỘT CHIỀU";
            // 
            // btn_TwoWay
            // 
            this.btn_TwoWay.BorderRadius = 10;
            this.btn_TwoWay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TwoWay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TwoWay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TwoWay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TwoWay.FillColor = System.Drawing.Color.White;
            this.btn_TwoWay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TwoWay.ForeColor = System.Drawing.Color.Black;
            this.btn_TwoWay.Location = new System.Drawing.Point(186, 12);
            this.btn_TwoWay.Name = "btn_TwoWay";
            this.btn_TwoWay.Size = new System.Drawing.Size(180, 45);
            this.btn_TwoWay.TabIndex = 1;
            this.btn_TwoWay.Text = "KHỨ HỒI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.icons8_left_and_right_arrows_30;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(339, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 36);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // date_To
            // 
            this.date_To.Checked = true;
            this.date_To.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_To.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_To.Location = new System.Drawing.Point(407, 230);
            this.date_To.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_To.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_To.Name = "date_To";
            this.date_To.Size = new System.Drawing.Size(276, 36);
            this.date_To.TabIndex = 63;
            this.date_To.Value = new System.DateTime(2023, 7, 21, 22, 1, 45, 674);
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(407, 207);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(59, 20);
            this.guna2HtmlLabel8.TabIndex = 62;
            this.guna2HtmlLabel8.Text = "Ngày về";
            // 
            // txt_Discount
            // 
            txt_Discount.Location = new Point(66, 508);
            txt_Discount.Margin = new Padding(3, 4, 3, 4);
            txt_Discount.Name = "txt_Discount";
            txt_Discount.Size = new Size(315, 27);
            txt_Discount.TabIndex = 61;
            // 
            // lb_ErrorTo
            // 
            lb_ErrorTo.BackColor = Color.Transparent;
            lb_ErrorTo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ErrorTo.Location = new Point(465, 231);
            lb_ErrorTo.Margin = new Padding(3, 4, 3, 4);
            lb_ErrorTo.Name = "lb_ErrorTo";
            lb_ErrorTo.Size = new Size(134, 25);
            lb_ErrorTo.TabIndex = 59;
            lb_ErrorTo.Text = "không để trống";
            // 
            // lb_ErrorFrom
            // 
            lb_ErrorFrom.BackColor = Color.Transparent;
            lb_ErrorFrom.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ErrorFrom.Location = new Point(66, 231);
            lb_ErrorFrom.Margin = new Padding(3, 4, 3, 4);
            lb_ErrorFrom.Name = "lb_ErrorFrom";
            lb_ErrorFrom.Size = new Size(134, 25);
            lb_ErrorFrom.TabIndex = 58;
            lb_ErrorFrom.Text = "không để trống";
            // 
            // btn_Search
            // 
            btn_Search.BorderColor = Color.FromArgb(123, 90, 4);
            btn_Search.BorderRadius = 10;
            btn_Search.BorderThickness = 1;
            btn_Search.DisabledState.BorderColor = Color.DarkGray;
            btn_Search.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Search.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Search.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Search.FillColor = Color.Empty;
            btn_Search.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Search.ForeColor = Color.FromArgb(123, 90, 4);
            btn_Search.Location = new Point(575, 479);
            btn_Search.Margin = new Padding(3, 4, 3, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(206, 60);
            btn_Search.TabIndex = 50;
            btn_Search.Text = "TÌM KIẾM";
            btn_Search.Click += btn_Search_Click;
            // 
            // date_From
            // 
            date_From.Checked = true;
            date_From.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date_From.Format = DateTimePickerFormat.Long;
            date_From.Location = new Point(66, 307);
            date_From.Margin = new Padding(3, 4, 3, 4);
            date_From.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            date_From.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            date_From.Name = "date_From";
            date_From.Size = new Size(315, 48);
            date_From.TabIndex = 57;
            date_From.Value = new DateTime(2023, 7, 2, 22, 1, 45, 0);
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel5.Location = new Point(66, 276);
            guna2HtmlLabel5.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(69, 25);
            guna2HtmlLabel5.TabIndex = 56;
            guna2HtmlLabel5.Text = "Ngày đi";
            // 
            // cbb_To
            // 
            cbb_To.BackColor = Color.Transparent;
            cbb_To.DrawMode = DrawMode.OwnerDrawFixed;
            cbb_To.DropDownHeight = 150;
            cbb_To.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_To.FocusedColor = Color.FromArgb(94, 148, 255);
            cbb_To.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbb_To.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_To.ForeColor = Color.FromArgb(68, 88, 112);
            cbb_To.IntegralHeight = false;
            cbb_To.ItemHeight = 30;
            cbb_To.Location = new Point(465, 171);
            cbb_To.Margin = new Padding(3, 4, 3, 4);
            cbb_To.Name = "cbb_To";
            cbb_To.Size = new Size(315, 36);
            cbb_To.TabIndex = 51;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel2.Location = new Point(465, 140);
            guna2HtmlLabel2.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(52, 25);
            guna2HtmlLabel2.TabIndex = 49;
            guna2HtmlLabel2.Text = "Đến *";
            // 
            // cbb_From
            // 
            cbb_From.BackColor = Color.Transparent;
            cbb_From.DrawMode = DrawMode.OwnerDrawFixed;
            cbb_From.DropDownHeight = 150;
            cbb_From.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_From.FocusedColor = Color.FromArgb(94, 148, 255);
            cbb_From.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbb_From.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_From.ForeColor = Color.FromArgb(68, 88, 112);
            cbb_From.IntegralHeight = false;
            cbb_From.ItemHeight = 30;
            cbb_From.Location = new Point(66, 171);
            cbb_From.Margin = new Padding(3, 4, 3, 4);
            cbb_From.Name = "cbb_From";
            cbb_From.Size = new Size(315, 36);
            cbb_From.TabIndex = 48;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(66, 140);
            guna2HtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(42, 25);
            guna2HtmlLabel1.TabIndex = 47;
            guna2HtmlLabel1.Text = "Từ *";
            // 
            // guna2HtmlLabel9
            // 
            guna2HtmlLabel9.BackColor = Color.Transparent;
            guna2HtmlLabel9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel9.Location = new Point(66, 97);
            guna2HtmlLabel9.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            guna2HtmlLabel9.Size = new Size(349, 25);
            guna2HtmlLabel9.TabIndex = 66;
            guna2HtmlLabel9.Text = "Lưu ý: *Trường bắt buộc nhập thông tin";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.icons8_exclamation_mark_30;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(17, 84);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 48);
            pictureBox2.TabIndex = 65;
            pictureBox2.TabStop = false;
            // 
            // btn_discount
            // 
            btn_discount.BorderColor = Color.FromArgb(0, 95, 110);
            btn_discount.BorderRadius = 10;
            btn_discount.BorderThickness = 1;
            btn_discount.DisabledState.BorderColor = Color.DarkGray;
            btn_discount.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_discount.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_discount.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_discount.FillColor = Color.Empty;
            btn_discount.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_discount.ForeColor = Color.FromArgb(0, 95, 110);
            btn_discount.Image = Properties.Resources.icons8_gift_box_401;
            btn_discount.Location = new Point(66, 491);
            btn_discount.Margin = new Padding(3, 4, 3, 4);
            btn_discount.Name = "btn_discount";
            btn_discount.Size = new Size(179, 48);
            btn_discount.TabIndex = 67;
            btn_discount.Text = "MÃ KHUYẾN MÃI";
            btn_discount.Click += btn_Discount_Click;
            // 
            // lb_dateFrom
            // 
            lb_dateFrom.BackColor = Color.Transparent;
            lb_dateFrom.Location = new Point(66, 363);
            lb_dateFrom.Margin = new Padding(3, 4, 3, 4);
            lb_dateFrom.Name = "lb_dateFrom";
            lb_dateFrom.Size = new Size(72, 22);
            lb_dateFrom.TabIndex = 68;
            lb_dateFrom.Text = "thông báo";
            // 
            // lb_dateTo
            // 
            lb_dateTo.BackColor = Color.Transparent;
            lb_dateTo.Location = new Point(465, 363);
            lb_dateTo.Margin = new Padding(3, 4, 3, 4);
            lb_dateTo.Name = "lb_dateTo";
            lb_dateTo.Size = new Size(72, 22);
            lb_dateTo.TabIndex = 69;
            lb_dateTo.Text = "thông báo";
            // 
            // FbuyTickket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 572);
            Controls.Add(lb_dateTo);
            Controls.Add(lb_dateFrom);
            Controls.Add(btn_discount);
            Controls.Add(guna2HtmlLabel9);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(date_To);
            Controls.Add(guna2HtmlLabel8);
            Controls.Add(txt_Discount);
            Controls.Add(lb_ErrorTo);
            Controls.Add(lb_ErrorFrom);
            Controls.Add(btn_Search);
            Controls.Add(date_From);
            Controls.Add(guna2HtmlLabel5);
            Controls.Add(cbb_To);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(cbb_From);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(btn_TwoWay);
            Controls.Add(btn_OneWay);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FbuyTickket";
            Text = "Chọn loại vé";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_OneWay;
        private Guna.UI2.WinForms.Guna2Button btn_TwoWay;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_To;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private TextBox txt_Discount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorTo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorFrom;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_From;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_To;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_From;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button btn_discount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_dateFrom;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_dateTo;
    }
}