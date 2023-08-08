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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.date_NgayVe = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbb_DiemDen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbb_DiemDi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.date_NgayDi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.cbb_DiemDi);
            this.groupBox1.Controls.Add(this.date_NgayVe);
            this.groupBox1.Controls.Add(this.cbb_DiemDen);
            this.groupBox1.Controls.Add(this.date_NgayDi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.BorderRadius = 10;
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(894, 41);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(112, 33);
            this.btn_Search.TabIndex = 31;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // date_NgayVe
            // 
            this.date_NgayVe.Checked = true;
            this.date_NgayVe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.date_NgayVe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_NgayVe.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_NgayVe.Location = new System.Drawing.Point(223, 41);
            this.date_NgayVe.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_NgayVe.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_NgayVe.Name = "date_NgayVe";
            this.date_NgayVe.Size = new System.Drawing.Size(200, 36);
            this.date_NgayVe.TabIndex = 30;
            this.date_NgayVe.Value = new System.DateTime(2023, 7, 22, 21, 44, 51, 655);
            // 
            // cbb_DiemDen
            // 
            this.cbb_DiemDen.BackColor = System.Drawing.Color.Transparent;
            this.cbb_DiemDen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_DiemDen.DropDownHeight = 150;
            this.cbb_DiemDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_DiemDen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_DiemDen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_DiemDen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_DiemDen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_DiemDen.IntegralHeight = false;
            this.cbb_DiemDen.ItemHeight = 30;
            this.cbb_DiemDen.Location = new System.Drawing.Point(669, 41);
            this.cbb_DiemDen.Name = "cbb_DiemDen";
            this.cbb_DiemDen.Size = new System.Drawing.Size(200, 36);
            this.cbb_DiemDen.TabIndex = 29;
            // 
            // cbb_DiemDi
            // 
            this.cbb_DiemDi.BackColor = System.Drawing.Color.Transparent;
            this.cbb_DiemDi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_DiemDi.DropDownHeight = 150;
            this.cbb_DiemDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_DiemDi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_DiemDi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_DiemDi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_DiemDi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_DiemDi.IntegralHeight = false;
            this.cbb_DiemDi.ItemHeight = 30;
            this.cbb_DiemDi.Location = new System.Drawing.Point(444, 39);
            this.cbb_DiemDi.Name = "cbb_DiemDi";
            this.cbb_DiemDi.Size = new System.Drawing.Size(200, 36);
            this.cbb_DiemDi.TabIndex = 28;
            // 
            // date_NgayDi
            // 
            this.date_NgayDi.Checked = true;
            this.date_NgayDi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.date_NgayDi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_NgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_NgayDi.Location = new System.Drawing.Point(6, 41);
            this.date_NgayDi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_NgayDi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_NgayDi.Name = "date_NgayDi";
            this.date_NgayDi.Size = new System.Drawing.Size(200, 36);
            this.date_NgayDi.TabIndex = 23;
            this.date_NgayDi.Value = new System.DateTime(2023, 7, 22, 21, 44, 51, 655);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(669, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Điểm đến";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(223, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ngày về";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày đi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(444, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Điểm đi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_data);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1031, 360);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToAddRows = false;
            this.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(6, 13);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowTemplate.Height = 25;
            this.dgv_data.Size = new System.Drawing.Size(1019, 341);
            this.dgv_data.TabIndex = 0;
            this.dgv_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_CellClick);
            // 
            // FquanlyVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FquanlyVe";
            this.Text = "FquanlyVe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private DataGridView dgv_data;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_NgayVe;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_DiemDen;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_DiemDi;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_NgayDi;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
    }
}