namespace GUI.Views
{
    partial class FthongTinKh
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
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_seat = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_phonenumber = new System.Windows.Forms.TextBox();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(57, 24);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(163, 35);
            this.txt_Email.TabIndex = 1;
            this.txt_Email.Text = "Ho ten";
            // 
            // txt_seat
            // 
            this.txt_seat.Location = new System.Drawing.Point(277, 24);
            this.txt_seat.Multiline = true;
            this.txt_seat.Name = "txt_seat";
            this.txt_seat.Size = new System.Drawing.Size(163, 35);
            this.txt_seat.TabIndex = 2;
            this.txt_seat.Text = "Ghe ngoi";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(57, 156);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(163, 83);
            this.txt_address.TabIndex = 3;
            this.txt_address.Text = "dia chi";
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.Location = new System.Drawing.Point(277, 156);
            this.txt_phonenumber.Multiline = true;
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(163, 35);
            this.txt_phonenumber.TabIndex = 4;
            this.txt_phonenumber.Text = "sdt";
            // 
            // txt_gender
            // 
            this.txt_gender.Location = new System.Drawing.Point(493, 38);
            this.txt_gender.Multiline = true;
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(163, 35);
            this.txt_gender.TabIndex = 5;
            this.txt_gender.Text = "gioi tinh";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(57, 81);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(163, 35);
            this.txt_name.TabIndex = 6;
            this.txt_name.Text = "Ho ten";
            // 
            // FthongTinKh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 350);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_phonenumber);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_seat);
            this.Controls.Add(this.txt_Email);
            this.Name = "FthongTinKh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FthongTinKh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txt_Email;
        private TextBox txt_seat;
        private TextBox txt_address;
        private TextBox txt_phonenumber;
        private TextBox txt_gender;
        private TextBox txt_name;
    }
}