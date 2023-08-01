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
            this.dgv_dataPlane = new System.Windows.Forms.DataGridView();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PlaneCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NamePlane = new System.Windows.Forms.TextBox();
            this.cmb_totalSeats = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_dataPlane
            // 
            this.dgv_dataPlane.AllowUserToAddRows = false;
            this.dgv_dataPlane.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dataPlane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dataPlane.Location = new System.Drawing.Point(12, 113);
            this.dgv_dataPlane.Name = "dgv_dataPlane";
            this.dgv_dataPlane.RowTemplate.Height = 25;
            this.dgv_dataPlane.Size = new System.Drawing.Size(1031, 358);
            this.dgv_dataPlane.TabIndex = 0;
            this.dgv_dataPlane.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dataPlane_CellClick);
            // 
            // btn_add
            // 
            this.btn_add.BorderRadius = 10;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(756, 33);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(126, 45);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Thêm";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.BorderRadius = 10;
            this.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(917, 33);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(126, 45);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Sửa";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã máy bay";
            // 
            // txt_PlaneCode
            // 
            this.txt_PlaneCode.Location = new System.Drawing.Point(94, 42);
            this.txt_PlaneCode.Multiline = true;
            this.txt_PlaneCode.Name = "txt_PlaneCode";
            this.txt_PlaneCode.Size = new System.Drawing.Size(149, 36);
            this.txt_PlaneCode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên máy bay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số ghế";
            // 
            // txt_NamePlane
            // 
            this.txt_NamePlane.Location = new System.Drawing.Point(458, 42);
            this.txt_NamePlane.Multiline = true;
            this.txt_NamePlane.Name = "txt_NamePlane";
            this.txt_NamePlane.Size = new System.Drawing.Size(149, 36);
            this.txt_NamePlane.TabIndex = 11;
            // 
            // cmb_totalSeats
            // 
            this.cmb_totalSeats.BackColor = System.Drawing.Color.Transparent;
            this.cmb_totalSeats.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_totalSeats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_totalSeats.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_totalSeats.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_totalSeats.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_totalSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_totalSeats.ItemHeight = 30;
            this.cmb_totalSeats.Location = new System.Drawing.Point(269, 42);
            this.cmb_totalSeats.Name = "cmb_totalSeats";
            this.cmb_totalSeats.Size = new System.Drawing.Size(161, 36);
            this.cmb_totalSeats.TabIndex = 12;
            // 
            // FThemMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 483);
            this.Controls.Add(this.cmb_totalSeats);
            this.Controls.Add(this.txt_NamePlane);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PlaneCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_dataPlane);
            this.Name = "FThemMayBay";
            this.Text = "FThemMayBay";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataPlane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_dataPlane;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Label label1;
        private TextBox txt_PlaneCode;
        private Label label2;
        private Label label3;
        private TextBox txt_NamePlane;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_totalSeats;
    }
}