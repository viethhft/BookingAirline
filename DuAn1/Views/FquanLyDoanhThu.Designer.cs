namespace DuAn1.Views
{
    partial class FquanLyDoanhThu
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
            this.dgv_Revenue = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.date_To = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.date_From = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_Export = new Guna.UI2.WinForms.Guna2Button();
            this.btn_fill = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Revenue)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Revenue);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgv_Revenue
            // 
            this.dgv_Revenue.AllowUserToAddRows = false;
            this.dgv_Revenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Revenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Revenue.Location = new System.Drawing.Point(6, 22);
            this.dgv_Revenue.Name = "dgv_Revenue";
            this.dgv_Revenue.RowTemplate.Height = 25;
            this.dgv_Revenue.Size = new System.Drawing.Size(1019, 366);
            this.dgv_Revenue.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.date_To);
            this.groupBox2.Controls.Add(this.date_From);
            this.groupBox2.Controls.Add(this.btn_Export);
            this.groupBox2.Controls.Add(this.btn_fill);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1025, 59);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // date_To
            // 
            this.date_To.Checked = true;
            this.date_To.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_To.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_To.Location = new System.Drawing.Point(424, 17);
            this.date_To.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_To.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_To.Name = "date_To";
            this.date_To.Size = new System.Drawing.Size(200, 36);
            this.date_To.TabIndex = 41;
            this.date_To.Value = new System.DateTime(2023, 7, 22, 21, 54, 15, 137);
            this.date_To.ValueChanged += new System.EventHandler(this.date_To_ValueChanged);
            // 
            // date_From
            // 
            this.date_From.Checked = true;
            this.date_From.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_From.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_From.Location = new System.Drawing.Point(100, 17);
            this.date_From.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_From.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_From.Name = "date_From";
            this.date_From.Size = new System.Drawing.Size(200, 36);
            this.date_From.TabIndex = 40;
            this.date_From.Value = new System.DateTime(2023, 7, 22, 21, 54, 15, 137);
            // 
            // btn_Export
            // 
            this.btn_Export.BorderRadius = 2;
            this.btn_Export.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Export.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Export.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Export.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Export.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_Export.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Export.ForeColor = System.Drawing.Color.White;
            this.btn_Export.Location = new System.Drawing.Point(927, 17);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(92, 36);
            this.btn_Export.TabIndex = 39;
            this.btn_Export.Text = "Xuất";
            // 
            // btn_fill
            // 
            this.btn_fill.BorderRadius = 2;
            this.btn_fill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_fill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_fill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_fill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_fill.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_fill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_fill.ForeColor = System.Drawing.Color.White;
            this.btn_fill.Location = new System.Drawing.Point(668, 17);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(92, 36);
            this.btn_fill.TabIndex = 38;
            this.btn_fill.Text = "Lọc";
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(344, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày";
            // 
            // FquanLyDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FquanLyDoanhThu";
            this.Text = "FquanLyDoanhThu";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Revenue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgv_Revenue;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_fill;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_To;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_From;
        private Guna.UI2.WinForms.Guna2Button btn_Export;
    }
}