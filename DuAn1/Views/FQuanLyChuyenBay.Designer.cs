namespace DuAn1.Views
{
    partial class FQuanLyChuyenBay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nbr_Price = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.txb_Search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmb_Location = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_PlaneType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_To = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_From = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgv_chuyenbay = new System.Windows.Forms.DataGridView();
            this.txb_codeflight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuyenbay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nbr_Price);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.txb_Search);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.DateFrom);
            this.groupBox1.Controls.Add(this.cmb_Location);
            this.groupBox1.Controls.Add(this.cmb_PlaneType);
            this.groupBox1.Controls.Add(this.cmb_To);
            this.groupBox1.Controls.Add(this.cmb_From);
            this.groupBox1.Controls.Add(this.dgv_chuyenbay);
            this.groupBox1.Controls.Add(this.txb_codeflight);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1030, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // nbr_Price
            // 
            this.nbr_Price.BackColor = System.Drawing.Color.Transparent;
            this.nbr_Price.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nbr_Price.Location = new System.Drawing.Point(619, 97);
            this.nbr_Price.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nbr_Price.Name = "nbr_Price";
            this.nbr_Price.Size = new System.Drawing.Size(210, 36);
            this.nbr_Price.TabIndex = 30;
            // 
            // btn_Update
            // 
            this.btn_Update.BorderRadius = 10;
            this.btn_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Update.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_Update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(896, 96);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(128, 45);
            this.btn_Update.TabIndex = 29;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BorderRadius = 10;
            this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_Add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(896, 40);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(128, 45);
            this.btn_Add.TabIndex = 28;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txb_Search
            // 
            this.txb_Search.Location = new System.Drawing.Point(619, 152);
            this.txb_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Search.Multiline = true;
            this.txb_Search.Name = "txb_Search";
            this.txb_Search.Size = new System.Drawing.Size(210, 37);
            this.txb_Search.TabIndex = 27;
            this.txb_Search.TextChanged += new System.EventHandler(this.txb_Search_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(619, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tìm kiếm";
            // 
            // dateTo
            // 
            this.dateTo.Checked = true;
            this.dateTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTo.Location = new System.Drawing.Point(325, 96);
            this.dateTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(242, 36);
            this.dateTo.TabIndex = 24;
            this.dateTo.Value = new System.DateTime(2023, 7, 22, 22, 13, 14, 18);
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // DateFrom
            // 
            this.DateFrom.Checked = true;
            this.DateFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DateFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateFrom.Location = new System.Drawing.Point(325, 30);
            this.DateFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(242, 36);
            this.DateFrom.TabIndex = 23;
            this.DateFrom.Value = new System.DateTime(2023, 7, 22, 22, 13, 14, 18);
            this.DateFrom.ValueChanged += new System.EventHandler(this.DateFrom_ValueChanged);
            // 
            // cmb_Location
            // 
            this.cmb_Location.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Location.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Location.DropDownHeight = 175;
            this.cmb_Location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Location.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Location.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_Location.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_Location.IntegralHeight = false;
            this.cmb_Location.ItemHeight = 30;
            this.cmb_Location.Location = new System.Drawing.Point(27, 94);
            this.cmb_Location.MaxDropDownItems = 10;
            this.cmb_Location.Name = "cmb_Location";
            this.cmb_Location.Size = new System.Drawing.Size(241, 36);
            this.cmb_Location.TabIndex = 22;
            this.cmb_Location.SelectedValueChanged += new System.EventHandler(this.cmb_Location_SelectedValueChanged);
            // 
            // cmb_PlaneType
            // 
            this.cmb_PlaneType.BackColor = System.Drawing.Color.Transparent;
            this.cmb_PlaneType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_PlaneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PlaneType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_PlaneType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_PlaneType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_PlaneType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_PlaneType.ItemHeight = 30;
            this.cmb_PlaneType.Location = new System.Drawing.Point(27, 31);
            this.cmb_PlaneType.Name = "cmb_PlaneType";
            this.cmb_PlaneType.Size = new System.Drawing.Size(241, 36);
            this.cmb_PlaneType.TabIndex = 21;
            this.cmb_PlaneType.SelectedValueChanged += new System.EventHandler(this.cmb_PlaneType_SelectedValueChanged);
            // 
            // cmb_To
            // 
            this.cmb_To.BackColor = System.Drawing.Color.Transparent;
            this.cmb_To.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_To.DropDownHeight = 175;
            this.cmb_To.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_To.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_To.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_To.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_To.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_To.IntegralHeight = false;
            this.cmb_To.ItemHeight = 30;
            this.cmb_To.Location = new System.Drawing.Point(325, 153);
            this.cmb_To.Name = "cmb_To";
            this.cmb_To.Size = new System.Drawing.Size(242, 36);
            this.cmb_To.TabIndex = 20;
            this.cmb_To.SelectedValueChanged += new System.EventHandler(this.cmb_To_SelectedValueChanged);
            // 
            // cmb_From
            // 
            this.cmb_From.BackColor = System.Drawing.Color.Transparent;
            this.cmb_From.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_From.DropDownHeight = 175;
            this.cmb_From.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_From.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_From.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_From.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_From.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_From.IntegralHeight = false;
            this.cmb_From.ItemHeight = 30;
            this.cmb_From.Location = new System.Drawing.Point(27, 151);
            this.cmb_From.Name = "cmb_From";
            this.cmb_From.Size = new System.Drawing.Size(241, 36);
            this.cmb_From.TabIndex = 19;
            this.cmb_From.SelectedValueChanged += new System.EventHandler(this.cmb_From_SelectedValueChanged);
            // 
            // dgv_chuyenbay
            // 
            this.dgv_chuyenbay.AllowUserToAddRows = false;
            this.dgv_chuyenbay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_chuyenbay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chuyenbay.Location = new System.Drawing.Point(4, 195);
            this.dgv_chuyenbay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_chuyenbay.Name = "dgv_chuyenbay";
            this.dgv_chuyenbay.RowTemplate.Height = 25;
            this.dgv_chuyenbay.Size = new System.Drawing.Size(1020, 262);
            this.dgv_chuyenbay.TabIndex = 0;
            this.dgv_chuyenbay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chuyenbay_CellClick);
            // 
            // txb_codeflight
            // 
            this.txb_codeflight.Location = new System.Drawing.Point(619, 30);
            this.txb_codeflight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_codeflight.Multiline = true;
            this.txb_codeflight.Name = "txb_codeflight";
            this.txb_codeflight.Size = new System.Drawing.Size(210, 37);
            this.txb_codeflight.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(619, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Giá tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(323, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày về";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(325, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày đi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(325, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Điểm đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Điểm đi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(619, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã chuyến bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa điểm(Tỉnh)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại máy bay";
            // 
            // FQuanLyChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 481);
            this.Controls.Add(this.groupBox1);
            this.Name = "FQuanLyChuyenBay";
            this.Text = "FQuanLyChuyenBay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chuyenbay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgv_chuyenbay;
        private Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_To;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_From;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateFrom;
        private TextBox txb_codeflight;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_Location;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_PlaneType;
        private Label label9;
        private TextBox txb_Search;
        private Guna.UI2.WinForms.Guna2NumericUpDown nbr_Price;
    }
}