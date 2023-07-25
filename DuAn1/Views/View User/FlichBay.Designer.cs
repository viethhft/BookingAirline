namespace GUI.Views.View_User
{
    partial class FlichBay
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
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbb_From = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbb_To = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.date_nkh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_ErrorTo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_ErrorFrom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(28, 24);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(251, 21);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "NHẬP THÔNG TIN CHUYẾN BAY";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(49, 125);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(33, 20);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Từ *";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(360, 125);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(42, 20);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "Đến *";
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
            this.cbb_From.Location = new System.Drawing.Point(49, 148);
            this.cbb_From.Name = "cbb_From";
            this.cbb_From.Size = new System.Drawing.Size(238, 36);
            this.cbb_From.TabIndex = 3;
            this.cbb_From.SelectedIndexChanged += new System.EventHandler(this.cbb_From_SelectedIndexChanged);
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
            this.cbb_To.Location = new System.Drawing.Point(360, 148);
            this.cbb_To.Name = "cbb_To";
            this.cbb_To.Size = new System.Drawing.Size(238, 36);
            this.cbb_To.TabIndex = 4;
            this.cbb_To.SelectedIndexChanged += new System.EventHandler(this.cbb_To_SelectedIndexChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(49, 226);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(121, 20);
            this.guna2HtmlLabel4.TabIndex = 5;
            this.guna2HtmlLabel4.Text = "Ngày khởi hành *";
            // 
            // date_nkh
            // 
            this.date_nkh.Checked = true;
            this.date_nkh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_nkh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_nkh.Location = new System.Drawing.Point(49, 264);
            this.date_nkh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_nkh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_nkh.Name = "date_nkh";
            this.date_nkh.Size = new System.Drawing.Size(238, 36);
            this.date_nkh.TabIndex = 6;
            this.date_nkh.Value = new System.DateTime(2023, 7, 21, 22, 25, 38, 738);
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
            this.btn_Search.Location = new System.Drawing.Point(48, 339);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(180, 45);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "TÌM KIẾM";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.icons8_exclamation_mark_30;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(36, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 36);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(79, 67);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(273, 20);
            this.guna2HtmlLabel5.TabIndex = 9;
            this.guna2HtmlLabel5.Text = "Lưu ý: *Trường bắt buộc nhập thông tin";
            // 
            // lb_ErrorTo
            // 
            this.lb_ErrorTo.BackColor = System.Drawing.Color.Transparent;
            this.lb_ErrorTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ErrorTo.Location = new System.Drawing.Point(360, 190);
            this.lb_ErrorTo.Name = "lb_ErrorTo";
            this.lb_ErrorTo.Size = new System.Drawing.Size(92, 20);
            this.lb_ErrorTo.TabIndex = 11;
            this.lb_ErrorTo.Text = "thông báo lỗi";
            // 
            // lb_ErrorFrom
            // 
            this.lb_ErrorFrom.BackColor = System.Drawing.Color.Transparent;
            this.lb_ErrorFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ErrorFrom.Location = new System.Drawing.Point(49, 190);
            this.lb_ErrorFrom.Name = "lb_ErrorFrom";
            this.lb_ErrorFrom.Size = new System.Drawing.Size(92, 20);
            this.lb_ErrorFrom.TabIndex = 10;
            this.lb_ErrorFrom.Text = "thông báo lỗi";
            // 
            // FlichBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 429);
            this.Controls.Add(this.lb_ErrorTo);
            this.Controls.Add(this.lb_ErrorFrom);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.date_nkh);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.cbb_To);
            this.Controls.Add(this.cbb_From);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "FlichBay";
            this.Text = "Lịch bay";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_From;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_To;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_nkh;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorTo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorFrom;
    }
}