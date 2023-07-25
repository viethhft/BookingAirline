namespace DuAn1.Views
{
    partial class FquanlyVe
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
            groupBox1 = new GroupBox();
            btn_Update = new Guna.UI2.WinForms.Guna2Button();
            btn_Delete = new Guna.UI2.WinForms.Guna2Button();
            txt_Search = new TextBox();
            label11 = new Label();
            txt_MaGhe = new TextBox();
            txt_KhuyenMai = new TextBox();
            date_NgayVe = new Guna.UI2.WinForms.Guna2DateTimePicker();
            cbb_DiemDen = new Guna.UI2.WinForms.Guna2ComboBox();
            cbb_DiemDi = new Guna.UI2.WinForms.Guna2ComboBox();
            date_NgayTao = new Guna.UI2.WinForms.Guna2DateTimePicker();
            txt_GiaVe = new TextBox();
            txt_TenVe = new TextBox();
            cbb_LoaiVe = new Guna.UI2.WinForms.Guna2ComboBox();
            date_NgayDi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgv_data = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_data).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Update);
            groupBox1.Controls.Add(btn_Delete);
            groupBox1.Controls.Add(txt_Search);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txt_MaGhe);
            groupBox1.Controls.Add(txt_KhuyenMai);
            groupBox1.Controls.Add(date_NgayVe);
            groupBox1.Controls.Add(cbb_DiemDen);
            groupBox1.Controls.Add(cbb_DiemDi);
            groupBox1.Controls.Add(date_NgayTao);
            groupBox1.Controls.Add(txt_GiaVe);
            groupBox1.Controls.Add(txt_TenVe);
            groupBox1.Controls.Add(cbb_LoaiVe);
            groupBox1.Controls.Add(date_NgayDi);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1031, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btn_Update
            // 
            btn_Update.BorderRadius = 10;
            btn_Update.DisabledState.BorderColor = Color.DarkGray;
            btn_Update.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Update.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Update.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Update.FillColor = Color.DarkCyan;
            btn_Update.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(776, 155);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(92, 45);
            btn_Update.TabIndex = 36;
            btn_Update.Text = "Sửa";
            // 
            // btn_Delete
            // 
            btn_Delete.BorderRadius = 10;
            btn_Delete.DisabledState.BorderColor = Color.DarkGray;
            btn_Delete.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Delete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Delete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Delete.FillColor = Color.DarkCyan;
            btn_Delete.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Delete.ForeColor = Color.White;
            btn_Delete.Location = new Point(886, 155);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(90, 45);
            btn_Delete.TabIndex = 35;
            btn_Delete.Text = "Xóa";
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(776, 95);
            txt_Search.Multiline = true;
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(200, 36);
            txt_Search.TabIndex = 34;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(776, 74);
            label11.Name = "label11";
            label11.Size = new Size(71, 18);
            label11.TabIndex = 33;
            label11.Text = "Tìm kiếm";
            // 
            // txt_MaGhe
            // 
            txt_MaGhe.Location = new Point(776, 33);
            txt_MaGhe.Multiline = true;
            txt_MaGhe.Name = "txt_MaGhe";
            txt_MaGhe.Size = new Size(200, 36);
            txt_MaGhe.TabIndex = 32;
            // 
            // txt_KhuyenMai
            // 
            txt_KhuyenMai.Location = new Point(536, 33);
            txt_KhuyenMai.Multiline = true;
            txt_KhuyenMai.Name = "txt_KhuyenMai";
            txt_KhuyenMai.Size = new Size(200, 36);
            txt_KhuyenMai.TabIndex = 31;
            // 
            // date_NgayVe
            // 
            date_NgayVe.Checked = true;
            date_NgayVe.FillColor = Color.FromArgb(224, 224, 224);
            date_NgayVe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date_NgayVe.Format = DateTimePickerFormat.Long;
            date_NgayVe.Location = new Point(286, 169);
            date_NgayVe.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            date_NgayVe.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            date_NgayVe.Name = "date_NgayVe";
            date_NgayVe.Size = new Size(200, 36);
            date_NgayVe.TabIndex = 30;
            date_NgayVe.Value = new DateTime(2023, 7, 22, 21, 44, 51, 655);
            // 
            // cbb_DiemDen
            // 
            cbb_DiemDen.BackColor = Color.Transparent;
            cbb_DiemDen.DrawMode = DrawMode.OwnerDrawFixed;
            cbb_DiemDen.DropDownHeight = 150;
            cbb_DiemDen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_DiemDen.FocusedColor = Color.FromArgb(94, 148, 255);
            cbb_DiemDen.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbb_DiemDen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_DiemDen.ForeColor = Color.FromArgb(68, 88, 112);
            cbb_DiemDen.IntegralHeight = false;
            cbb_DiemDen.ItemHeight = 30;
            cbb_DiemDen.Location = new Point(536, 97);
            cbb_DiemDen.Name = "cbb_DiemDen";
            cbb_DiemDen.Size = new Size(200, 36);
            cbb_DiemDen.TabIndex = 29;
            // 
            // cbb_DiemDi
            // 
            cbb_DiemDi.BackColor = Color.Transparent;
            cbb_DiemDi.DrawMode = DrawMode.OwnerDrawFixed;
            cbb_DiemDi.DropDownHeight = 150;
            cbb_DiemDi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_DiemDi.FocusedColor = Color.FromArgb(94, 148, 255);
            cbb_DiemDi.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbb_DiemDi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_DiemDi.ForeColor = Color.FromArgb(68, 88, 112);
            cbb_DiemDi.IntegralHeight = false;
            cbb_DiemDi.ItemHeight = 30;
            cbb_DiemDi.Location = new Point(536, 169);
            cbb_DiemDi.Name = "cbb_DiemDi";
            cbb_DiemDi.Size = new Size(200, 36);
            cbb_DiemDi.TabIndex = 28;
            // 
            // date_NgayTao
            // 
            date_NgayTao.Checked = true;
            date_NgayTao.FillColor = Color.FromArgb(224, 224, 224);
            date_NgayTao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date_NgayTao.Format = DateTimePickerFormat.Long;
            date_NgayTao.Location = new Point(286, 97);
            date_NgayTao.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            date_NgayTao.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            date_NgayTao.Name = "date_NgayTao";
            date_NgayTao.Size = new Size(200, 36);
            date_NgayTao.TabIndex = 27;
            date_NgayTao.Value = new DateTime(2023, 7, 22, 21, 44, 51, 655);
            // 
            // txt_GiaVe
            // 
            txt_GiaVe.Location = new Point(286, 33);
            txt_GiaVe.Multiline = true;
            txt_GiaVe.Name = "txt_GiaVe";
            txt_GiaVe.Size = new Size(200, 36);
            txt_GiaVe.TabIndex = 26;
            // 
            // txt_TenVe
            // 
            txt_TenVe.Location = new Point(26, 33);
            txt_TenVe.Multiline = true;
            txt_TenVe.Name = "txt_TenVe";
            txt_TenVe.Size = new Size(200, 36);
            txt_TenVe.TabIndex = 25;
            // 
            // cbb_LoaiVe
            // 
            cbb_LoaiVe.BackColor = Color.Transparent;
            cbb_LoaiVe.DrawMode = DrawMode.OwnerDrawFixed;
            cbb_LoaiVe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_LoaiVe.FocusedColor = Color.FromArgb(94, 148, 255);
            cbb_LoaiVe.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbb_LoaiVe.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_LoaiVe.ForeColor = Color.FromArgb(68, 88, 112);
            cbb_LoaiVe.ItemHeight = 30;
            cbb_LoaiVe.Location = new Point(26, 97);
            cbb_LoaiVe.Name = "cbb_LoaiVe";
            cbb_LoaiVe.Size = new Size(200, 36);
            cbb_LoaiVe.TabIndex = 24;
            // 
            // date_NgayDi
            // 
            date_NgayDi.Checked = true;
            date_NgayDi.FillColor = Color.FromArgb(224, 224, 224);
            date_NgayDi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            date_NgayDi.Format = DateTimePickerFormat.Long;
            date_NgayDi.Location = new Point(26, 169);
            date_NgayDi.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            date_NgayDi.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            date_NgayDi.Name = "date_NgayDi";
            date_NgayDi.Size = new Size(200, 36);
            date_NgayDi.TabIndex = 23;
            date_NgayDi.Value = new DateTime(2023, 7, 22, 21, 44, 51, 655);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(536, 13);
            label10.Name = "label10";
            label10.Size = new Size(89, 18);
            label10.TabIndex = 21;
            label10.Text = "Khuyến mãi";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(536, 146);
            label9.Name = "label9";
            label9.Size = new Size(76, 18);
            label9.TabIndex = 19;
            label9.Text = "Điểm đến";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(286, 146);
            label8.Name = "label8";
            label8.Size = new Size(64, 18);
            label8.TabIndex = 17;
            label8.Text = "Ngày về";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(26, 146);
            label7.Name = "label7";
            label7.Size = new Size(61, 18);
            label7.TabIndex = 15;
            label7.Text = "Ngày đi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(286, 74);
            label6.Name = "label6";
            label6.Size = new Size(90, 18);
            label6.TabIndex = 13;
            label6.Text = "Ngày tạo vé";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(536, 74);
            label5.Name = "label5";
            label5.Size = new Size(63, 18);
            label5.TabIndex = 11;
            label5.Text = "Điểm đi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(286, 13);
            label4.Name = "label4";
            label4.Size = new Size(53, 18);
            label4.TabIndex = 9;
            label4.Text = "Giá vé";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 74);
            label3.Name = "label3";
            label3.Size = new Size(59, 18);
            label3.TabIndex = 2;
            label3.Text = "Loại vé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(776, 13);
            label2.Name = "label2";
            label2.Size = new Size(60, 18);
            label2.TabIndex = 1;
            label2.Text = "Mã ghế";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 13);
            label1.Name = "label1";
            label1.Size = new Size(54, 18);
            label1.TabIndex = 0;
            label1.Text = "Tên vé";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_data);
            groupBox2.Location = new Point(12, 223);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1031, 248);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dgv_data
            // 
            dgv_data.AllowUserToAddRows = false;
            dgv_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_data.Location = new Point(6, 22);
            dgv_data.Name = "dgv_data";
            dgv_data.RowTemplate.Height = 25;
            dgv_data.Size = new Size(1019, 220);
            dgv_data.TabIndex = 0;
            dgv_data.CellClick += dgv_data_CellClick;
            // 
            // FquanlyVe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 483);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FquanlyVe";
            Text = "FquanlyVe";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridView dgv_data;
        private TextBox txt_MaGhe;
        private TextBox txt_KhuyenMai;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_NgayVe;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_DiemDen;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_DiemDi;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_NgayTao;
        private TextBox txt_GiaVe;
        private TextBox txt_TenVe;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_LoaiVe;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_NgayDi;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
        private Guna.UI2.WinForms.Guna2Button btn_Delete;
        private TextBox txt_Search;
        private Label label11;
    }
}