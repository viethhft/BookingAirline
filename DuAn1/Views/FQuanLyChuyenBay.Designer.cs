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
            groupBox1 = new GroupBox();
            cmb_status = new Guna.UI2.WinForms.Guna2ComboBox();
            label12 = new Label();
            label14 = new Label();
            timeEnd_minute = new Guna.UI2.WinForms.Guna2NumericUpDown();
            timeEnd_hour = new Guna.UI2.WinForms.Guna2NumericUpDown();
            label11 = new Label();
            timeStart_minute = new Guna.UI2.WinForms.Guna2NumericUpDown();
            timeStart_hour = new Guna.UI2.WinForms.Guna2NumericUpDown();
            label10 = new Label();
            label2 = new Label();
            cmb_To = new Guna.UI2.WinForms.Guna2ComboBox();
            label5 = new Label();
            nbr_Price = new Guna.UI2.WinForms.Guna2NumericUpDown();
            btn_Update = new Guna.UI2.WinForms.Guna2Button();
            btn_Add = new Guna.UI2.WinForms.Guna2Button();
            txb_Search = new TextBox();
            label9 = new Label();
            dateTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            DateFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            cmb_PlaneType = new Guna.UI2.WinForms.Guna2ComboBox();
            cmb_From = new Guna.UI2.WinForms.Guna2ComboBox();
            dgv_chuyenbay = new DataGridView();
            txb_codeflight = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timeEnd_minute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeEnd_hour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeStart_minute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeStart_hour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nbr_Price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_chuyenbay).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmb_status);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(timeEnd_minute);
            groupBox1.Controls.Add(timeEnd_hour);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(timeStart_minute);
            groupBox1.Controls.Add(timeStart_hour);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmb_To);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nbr_Price);
            groupBox1.Controls.Add(btn_Update);
            groupBox1.Controls.Add(btn_Add);
            groupBox1.Controls.Add(txb_Search);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dateTo);
            groupBox1.Controls.Add(DateFrom);
            groupBox1.Controls.Add(cmb_PlaneType);
            groupBox1.Controls.Add(cmb_From);
            groupBox1.Controls.Add(dgv_chuyenbay);
            groupBox1.Controls.Add(txb_codeflight);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1177, 615);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // cmb_status
            // 
            cmb_status.BackColor = Color.Transparent;
            cmb_status.DrawMode = DrawMode.OwnerDrawFixed;
            cmb_status.DropDownHeight = 175;
            cmb_status.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_status.FocusedColor = Color.FromArgb(94, 148, 255);
            cmb_status.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmb_status.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_status.ForeColor = Color.FromArgb(68, 88, 112);
            cmb_status.IntegralHeight = false;
            cmb_status.ItemHeight = 30;
            cmb_status.Location = new Point(661, 205);
            cmb_status.Margin = new Padding(3, 4, 3, 4);
            cmb_status.Name = "cmb_status";
            cmb_status.Size = new Size(241, 36);
            cmb_status.TabIndex = 49;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(661, 180);
            label12.Name = "label12";
            label12.Size = new Size(97, 23);
            label12.TabIndex = 48;
            label12.Text = "Trạng thái";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(833, 43);
            label14.Name = "label14";
            label14.Size = new Size(19, 32);
            label14.TabIndex = 47;
            label14.Text = ":";
            // 
            // timeEnd_minute
            // 
            timeEnd_minute.BackColor = Color.Transparent;
            timeEnd_minute.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            timeEnd_minute.Location = new Point(855, 45);
            timeEnd_minute.Margin = new Padding(3, 4, 3, 4);
            timeEnd_minute.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            timeEnd_minute.Name = "timeEnd_minute";
            timeEnd_minute.Size = new Size(47, 33);
            timeEnd_minute.TabIndex = 45;
            // 
            // timeEnd_hour
            // 
            timeEnd_hour.BackColor = Color.Transparent;
            timeEnd_hour.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            timeEnd_hour.Location = new Point(784, 45);
            timeEnd_hour.Margin = new Padding(3, 4, 3, 4);
            timeEnd_hour.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            timeEnd_hour.Name = "timeEnd_hour";
            timeEnd_hour.Size = new Size(47, 33);
            timeEnd_hour.TabIndex = 44;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(709, 43);
            label11.Name = "label11";
            label11.Size = new Size(19, 32);
            label11.TabIndex = 42;
            label11.Text = ":";
            // 
            // timeStart_minute
            // 
            timeStart_minute.BackColor = Color.Transparent;
            timeStart_minute.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            timeStart_minute.Location = new Point(722, 45);
            timeStart_minute.Margin = new Padding(3, 4, 3, 4);
            timeStart_minute.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            timeStart_minute.Name = "timeStart_minute";
            timeStart_minute.Size = new Size(47, 33);
            timeStart_minute.TabIndex = 37;
            // 
            // timeStart_hour
            // 
            timeStart_hour.BackColor = Color.Transparent;
            timeStart_hour.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            timeStart_hour.Location = new Point(662, 45);
            timeStart_hour.Margin = new Padding(3, 4, 3, 4);
            timeStart_hour.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            timeStart_hour.Name = "timeStart_hour";
            timeStart_hour.Size = new Size(47, 33);
            timeStart_hour.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(784, 16);
            label10.Name = "label10";
            label10.Size = new Size(83, 23);
            label10.TabIndex = 35;
            label10.Text = "Kết thúc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(661, 17);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 33;
            label2.Text = "Khởi hành";
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
            this.cmb_To.Location = new System.Drawing.Point(298, 96);
            this.cmb_To.Name = "cmb_To";
            this.cmb_To.Size = new System.Drawing.Size(242, 36);
            this.cmb_To.TabIndex = 32;
            this.cmb_To.SelectedIndexChanged += new System.EventHandler(this.cmb_To_SelectedValueChanged);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(341, 104);
            label5.Name = "label5";
            label5.Size = new Size(93, 23);
            label5.TabIndex = 31;
            label5.Text = "Điểm đến";
            // 
            // nbr_Price
            // 
            nbr_Price.BackColor = Color.Transparent;
            nbr_Price.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nbr_Price.Increment = new decimal(new int[] { 1000000, 0, 0, 0 });
            nbr_Price.Location = new Point(662, 128);
            nbr_Price.Margin = new Padding(3, 4, 3, 4);
            nbr_Price.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
            nbr_Price.Name = "nbr_Price";
            nbr_Price.Size = new Size(240, 48);
            nbr_Price.TabIndex = 30;
            nbr_Price.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
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
            this.btn_Update.Location = new System.Drawing.Point(896, 87);
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
            this.btn_Add.Location = new System.Drawing.Point(896, 22);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(128, 45);
            this.btn_Add.TabIndex = 28;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txb_Search
            // 
            txb_Search.Location = new Point(930, 205);
            txb_Search.Multiline = true;
            txb_Search.Name = "txb_Search";
            txb_Search.Size = new Size(239, 48);
            txb_Search.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(930, 180);
            label9.Name = "label9";
            label9.Size = new Size(91, 23);
            label9.TabIndex = 26;
            label9.Text = "Tìm kiếm";
            // 
            // dateTo
            // 
            this.dateTo.Checked = true;
            this.dateTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTo.Location = new System.Drawing.Point(298, 154);
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
            this.DateFrom.Location = new System.Drawing.Point(26, 154);
            this.DateFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(242, 36);
            this.DateFrom.TabIndex = 23;
            this.DateFrom.Value = new System.DateTime(2023, 7, 22, 22, 13, 14, 18);
            this.DateFrom.ValueChanged += new System.EventHandler(this.DateFrom_ValueChanged);
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
            this.cmb_PlaneType.SelectedIndexChanged += new System.EventHandler(this.cmb_PlaneType_SelectedValueChanged);
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
            this.cmb_From.Location = new System.Drawing.Point(27, 96);
            this.cmb_From.Name = "cmb_From";
            this.cmb_From.Size = new System.Drawing.Size(241, 36);
            this.cmb_From.TabIndex = 19;
            this.cmb_From.SelectedIndexChanged += new System.EventHandler(this.cmb_From_SelectedValueChanged);
            // 
            // dgv_chuyenbay
            // 
            dgv_chuyenbay.AllowUserToAddRows = false;
            dgv_chuyenbay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_chuyenbay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_chuyenbay.Location = new Point(5, 260);
            dgv_chuyenbay.Name = "dgv_chuyenbay";
            dgv_chuyenbay.RowHeadersWidth = 51;
            dgv_chuyenbay.RowTemplate.Height = 25;
            dgv_chuyenbay.Size = new Size(1166, 349);
            dgv_chuyenbay.TabIndex = 0;
            // 
            // txb_codeflight
            // 
            txb_codeflight.Location = new Point(343, 40);
            txb_codeflight.Multiline = true;
            txb_codeflight.Name = "txb_codeflight";
            txb_codeflight.Size = new Size(274, 48);
            txb_codeflight.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(662, 100);
            label8.Name = "label8";
            label8.Size = new Size(78, 23);
            label8.TabIndex = 18;
            label8.Text = "Giá tiền";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(341, 177);
            label7.Name = "label7";
            label7.Size = new Size(81, 23);
            label7.TabIndex = 15;
            label7.Text = "Ngày về";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 180);
            label6.Name = "label6";
            label6.Size = new Size(76, 23);
            label6.TabIndex = 13;
            label6.Text = "Ngày đi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 104);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 9;
            label4.Text = "Điểm đi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(343, 16);
            label3.Name = "label3";
            label3.Size = new Size(143, 23);
            label3.TabIndex = 7;
            label3.Text = "Mã chuyến bay";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 16);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 1;
            label1.Text = "Loại máy bay";
            // 
            // FQuanLyChuyenBay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 641);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FQuanLyChuyenBay";
            Text = "FQuanLyChuyenBay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)timeEnd_minute).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeEnd_hour).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeStart_minute).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeStart_hour).EndInit();
            ((System.ComponentModel.ISupportInitialize)nbr_Price).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_chuyenbay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private DataGridView dgv_chuyenbay;
        private Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_From;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateFrom;
        private TextBox txb_codeflight;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_PlaneType;
        private Label label9;
        private TextBox txb_Search;
        private Guna.UI2.WinForms.Guna2NumericUpDown nbr_Price;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_To;
        private Label label5;
        private Label label10;
        private Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown timeStart_hour;
        private Label label14;
        private Guna.UI2.WinForms.Guna2NumericUpDown timeEnd_minute;
        private Guna.UI2.WinForms.Guna2NumericUpDown timeEnd_hour;
        private Label label11;
        private Guna.UI2.WinForms.Guna2NumericUpDown timeStart_minute;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_status;
        private Label label12;
    }
}