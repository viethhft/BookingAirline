namespace GUI.Views
{
    partial class FThemMayBay
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
            dgv_dataPlane = new DataGridView();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            txt_PlaneCode = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            txt_NamePlane = new TextBox();
            cmb_totalSeats = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_dataPlane).BeginInit();
            SuspendLayout();
            // 
            // dgv_dataPlane
            // 
            dgv_dataPlane.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_dataPlane.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_dataPlane.Location = new Point(12, 113);
            dgv_dataPlane.Name = "dgv_dataPlane";
            dgv_dataPlane.RowTemplate.Height = 25;
            dgv_dataPlane.Size = new Size(1031, 358);
            dgv_dataPlane.TabIndex = 0;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.DarkCyan;
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(756, 33);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(126, 45);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "Thêm";
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 10;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.DarkCyan;
            guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(917, 33);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(126, 45);
            guna2Button2.TabIndex = 2;
            guna2Button2.Text = "Sửa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 24);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 3;
            label1.Text = "Mã máy bay";
            // 
            // txt_PlaneCode
            // 
            txt_PlaneCode.Location = new Point(27, 42);
            txt_PlaneCode.Multiline = true;
            txt_PlaneCode.Name = "txt_PlaneCode";
            txt_PlaneCode.Size = new Size(149, 36);
            txt_PlaneCode.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 24);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 5;
            label2.Text = "Tên máy bay";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 24);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 7;
            label3.Text = "Số ghế";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(575, 24);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 9;
            label4.Text = "Trạng thái";
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2ComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Location = new Point(575, 42);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.Size = new Size(161, 36);
            guna2ComboBox1.TabIndex = 10;
            // 
            // txt_NamePlane
            // 
            txt_NamePlane.Location = new Point(391, 42);
            txt_NamePlane.Multiline = true;
            txt_NamePlane.Name = "txt_NamePlane";
            txt_NamePlane.Size = new Size(149, 36);
            txt_NamePlane.TabIndex = 11;
            // 
            // cmb_totalSeats
            // 
            cmb_totalSeats.BackColor = Color.Transparent;
            cmb_totalSeats.DrawMode = DrawMode.OwnerDrawFixed;
            cmb_totalSeats.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_totalSeats.FocusedColor = Color.FromArgb(94, 148, 255);
            cmb_totalSeats.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmb_totalSeats.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_totalSeats.ForeColor = Color.FromArgb(68, 88, 112);
            cmb_totalSeats.ItemHeight = 30;
            cmb_totalSeats.Location = new Point(202, 42);
            cmb_totalSeats.Name = "cmb_totalSeats";
            cmb_totalSeats.Size = new Size(161, 36);
            cmb_totalSeats.TabIndex = 12;
            // 
            // FThemMayBay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 483);
            Controls.Add(cmb_totalSeats);
            Controls.Add(txt_NamePlane);
            Controls.Add(guna2ComboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_PlaneCode);
            Controls.Add(label1);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(dgv_dataPlane);
            Name = "FThemMayBay";
            Text = "FThemMayBay";
            ((System.ComponentModel.ISupportInitialize)dgv_dataPlane).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_dataPlane;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Label label1;
        private TextBox txt_PlaneCode;
        private Label label2;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private TextBox txt_NamePlane;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_totalSeats;
    }
}