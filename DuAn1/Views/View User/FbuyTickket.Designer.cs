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
            this.btn_OneWay = new Guna.UI2.WinForms.Guna2Button();
            this.btn_TwoWay = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.date_To = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.lb_ErrorTo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_ErrorFrom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.date_From = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbb_To = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbb_From = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_discount = new Guna.UI2.WinForms.Guna2Button();
            this.lb_dateFrom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_dateTo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            txt_Discount.Location = new Point(58, 381);
            txt_Discount.Name = "txt_Discount";
            txt_Discount.Size = new Size(276, 23);
            txt_Discount.TabIndex = 61;
            // 
            // lb_ErrorTo
            // 
            this.lb_ErrorTo.BackColor = System.Drawing.Color.Transparent;
            this.lb_ErrorTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ErrorTo.Location = new System.Drawing.Point(407, 173);
            this.lb_ErrorTo.Name = "lb_ErrorTo";
            this.lb_ErrorTo.Size = new System.Drawing.Size(106, 20);
            this.lb_ErrorTo.TabIndex = 59;
            this.lb_ErrorTo.Text = "không để trống";
            // 
            // lb_ErrorFrom
            // 
            this.lb_ErrorFrom.BackColor = System.Drawing.Color.Transparent;
            this.lb_ErrorFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ErrorFrom.Location = new System.Drawing.Point(58, 173);
            this.lb_ErrorFrom.Name = "lb_ErrorFrom";
            this.lb_ErrorFrom.Size = new System.Drawing.Size(106, 20);
            this.lb_ErrorFrom.TabIndex = 58;
            this.lb_ErrorFrom.Text = "không để trống";
            // 
            // btn_Search
            // 
            this.btn_Search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(90)))), ((int)(((byte)(4)))));
            this.btn_Search.BorderRadius = 10;
            this.btn_Search.BorderThickness = 1;
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.FillColor = System.Drawing.Color.Empty;
            this.btn_Search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(90)))), ((int)(((byte)(4)))));
            this.btn_Search.Location = new System.Drawing.Point(503, 359);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(180, 45);
            this.btn_Search.TabIndex = 50;
            this.btn_Search.Text = "TÌM KIẾM";
            // 
            // date_From
            // 
            this.date_From.Checked = true;
            this.date_From.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_From.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_From.Location = new System.Drawing.Point(58, 230);
            this.date_From.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_From.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_From.Name = "date_From";
            this.date_From.Size = new System.Drawing.Size(276, 36);
            this.date_From.TabIndex = 57;
            this.date_From.Value = new System.DateTime(2023, 7, 2, 22, 1, 45, 0);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(58, 207);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(56, 20);
            this.guna2HtmlLabel5.TabIndex = 56;
            this.guna2HtmlLabel5.Text = "Ngày đi";
            // 
            // cbb_To
            // 
            this.cbb_To.BackColor = System.Drawing.Color.Transparent;
            this.cbb_To.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_To.DropDownHeight = 150;
            this.cbb_To.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_To.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_To.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_To.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_To.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_To.IntegralHeight = false;
            this.cbb_To.ItemHeight = 30;
            this.cbb_To.Location = new System.Drawing.Point(407, 128);
            this.cbb_To.Name = "cbb_To";
            this.cbb_To.Size = new System.Drawing.Size(276, 36);
            this.cbb_To.TabIndex = 51;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(407, 105);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(42, 20);
            this.guna2HtmlLabel2.TabIndex = 49;
            this.guna2HtmlLabel2.Text = "Đến *";
            // 
            // cbb_From
            // 
            this.cbb_From.BackColor = System.Drawing.Color.Transparent;
            this.cbb_From.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_From.DropDownHeight = 150;
            this.cbb_From.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_From.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_From.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_From.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_From.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_From.IntegralHeight = false;
            this.cbb_From.ItemHeight = 30;
            this.cbb_From.Location = new System.Drawing.Point(58, 128);
            this.cbb_From.Name = "cbb_From";
            this.cbb_From.Size = new System.Drawing.Size(276, 36);
            this.cbb_From.TabIndex = 48;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(58, 105);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(33, 20);
            this.guna2HtmlLabel1.TabIndex = 47;
            this.guna2HtmlLabel1.Text = "Từ *";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(58, 73);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(273, 20);
            this.guna2HtmlLabel9.TabIndex = 66;
            this.guna2HtmlLabel9.Text = "Lưu ý: *Trường bắt buộc nhập thông tin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.icons8_exclamation_mark_30;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(15, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 36);
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
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
            btn_discount.Location = new Point(58, 368);
            btn_discount.Name = "btn_discount";
            btn_discount.Size = new Size(157, 36);
            btn_discount.TabIndex = 67;
            btn_discount.Text = "MÃ KHUYẾN MÃI";
            btn_discount.Click += btn_Discount_Click;
            // 
            // lb_dateFrom
            // 
            this.lb_dateFrom.BackColor = System.Drawing.Color.Transparent;
            this.lb_dateFrom.Location = new System.Drawing.Point(58, 272);
            this.lb_dateFrom.Name = "lb_dateFrom";
            this.lb_dateFrom.Size = new System.Drawing.Size(58, 17);
            this.lb_dateFrom.TabIndex = 68;
            this.lb_dateFrom.Text = "thông báo";
            // 
            // lb_dateTo
            // 
            this.lb_dateTo.BackColor = System.Drawing.Color.Transparent;
            this.lb_dateTo.Location = new System.Drawing.Point(407, 272);
            this.lb_dateTo.Name = "lb_dateTo";
            this.lb_dateTo.Size = new System.Drawing.Size(58, 17);
            this.lb_dateTo.TabIndex = 69;
            this.lb_dateTo.Text = "thông báo";
            // 
            // FbuyTickket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 429);
            this.Controls.Add(this.lb_dateTo);
            this.Controls.Add(this.lb_dateFrom);
            this.Controls.Add(this.btn_discount);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.date_To);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.txt_Discount);
            this.Controls.Add(this.lb_ErrorTo);
            this.Controls.Add(this.lb_ErrorFrom);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.date_From);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.cbb_To);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.cbb_From);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btn_TwoWay);
            this.Controls.Add(this.btn_OneWay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FbuyTickket";
            this.Text = "Chọn loại vé";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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