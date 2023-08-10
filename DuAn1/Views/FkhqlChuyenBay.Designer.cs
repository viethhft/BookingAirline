namespace GUI.Views
{
    partial class FkhqlChuyenBay
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
            this.dgv_InforCus = new System.Windows.Forms.DataGridView();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Gender = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_SeatCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_FlightCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InforCus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới tính";
            // 
            // dgv_InforCus
            // 
            this.dgv_InforCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InforCus.Location = new System.Drawing.Point(12, 197);
            this.dgv_InforCus.Name = "dgv_InforCus";
            this.dgv_InforCus.RowTemplate.Height = 25;
            this.dgv_InforCus.Size = new System.Drawing.Size(825, 282);
            this.dgv_InforCus.TabIndex = 3;
            this.dgv_InforCus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_InforCus_CellClick);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(38, 42);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(160, 34);
            this.txt_Name.TabIndex = 4;
            // 
            // txt_Gender
            // 
            this.txt_Gender.Location = new System.Drawing.Point(289, 42);
            this.txt_Gender.Multiline = true;
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.Size = new System.Drawing.Size(160, 34);
            this.txt_Gender.TabIndex = 5;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(578, 42);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(160, 110);
            this.txt_Address.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(38, 118);
            this.txt_PhoneNumber.Multiline = true;
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(160, 34);
            this.txt_PhoneNumber.TabIndex = 4;
            // 
            // txt_SeatCode
            // 
            this.txt_SeatCode.Location = new System.Drawing.Point(289, 118);
            this.txt_SeatCode.Multiline = true;
            this.txt_SeatCode.Name = "txt_SeatCode";
            this.txt_SeatCode.Size = new System.Drawing.Size(160, 34);
            this.txt_SeatCode.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ghế ngồi";
            // 
            // txt_FlightCode
            // 
            this.txt_FlightCode.Location = new System.Drawing.Point(461, 157);
            this.txt_FlightCode.Multiline = true;
            this.txt_FlightCode.Name = "txt_FlightCode";
            this.txt_FlightCode.Size = new System.Drawing.Size(160, 34);
            this.txt_FlightCode.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã chuyến bay";
            // 
            // FkhqlChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 491);
            this.Controls.Add(this.txt_FlightCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_SeatCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Gender);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.dgv_InforCus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FkhqlChuyenBay";
            this.Text = "Thông tin khách hàng của chuyến bay";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InforCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgv_InforCus;
        private TextBox txt_Name;
        private TextBox txt_Gender;
        private TextBox txt_Address;
        private Label label4;
        private Label label3;
        private TextBox txt_PhoneNumber;
        private TextBox txt_SeatCode;
        private Label label5;
        private TextBox txt_FlightCode;
        private Label label6;
    }
}