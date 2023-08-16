namespace GUI.Views.View_User
{
    partial class FtaikhoanNh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_BankNumber = new System.Windows.Forms.TextBox();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.cbb_BankName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_ErrorName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN TÀI KHOẢN NGÂN HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tài khoản";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(148, 121);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(191, 23);
            this.txt_Name.TabIndex = 3;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // txt_BankNumber
            // 
            this.txt_BankNumber.Location = new System.Drawing.Point(148, 216);
            this.txt_BankNumber.Name = "txt_BankNumber";
            this.txt_BankNumber.Size = new System.Drawing.Size(191, 23);
            this.txt_BankNumber.TabIndex = 4;
            this.txt_BankNumber.TextChanged += new System.EventHandler(this.txt_BankNumber_TextChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.BorderRadius = 10;
            this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(247, 262);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(92, 39);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cbb_BankName
            // 
            this.cbb_BankName.FormattingEnabled = true;
            this.cbb_BankName.Location = new System.Drawing.Point(148, 167);
            this.cbb_BankName.Name = "cbb_BankName";
            this.cbb_BankName.Size = new System.Drawing.Size(191, 23);
            this.cbb_BankName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên ngân hàng";
            // 
            // lb_ErrorName
            // 
            this.lb_ErrorName.BackColor = System.Drawing.Color.Transparent;
            this.lb_ErrorName.Location = new System.Drawing.Point(148, 144);
            this.lb_ErrorName.Name = "lb_ErrorName";
            this.lb_ErrorName.Size = new System.Drawing.Size(97, 17);
            this.lb_ErrorName.TabIndex = 8;
            this.lb_ErrorName.Text = "guna2HtmlLabel1";
            // 
            // FtaikhoanNh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 329);
            this.Controls.Add(this.lb_ErrorName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbb_BankName);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_BankNumber);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FtaikhoanNh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FtaikhoanNh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_Name;
        private TextBox txt_BankNumber;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private ComboBox cbb_BankName;
        private Label label4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ErrorName;
    }
}