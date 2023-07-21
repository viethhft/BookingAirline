namespace GUI.Views
{
    partial class FwatchFilght_2
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
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.AutoSize = false;
            guna2HtmlLabel2.BackColor = Color.FromArgb(230, 180, 65);
            guna2HtmlLabel2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(0, 95, 110);
            guna2HtmlLabel2.Location = new Point(820, 12);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(192, 42);
            guna2HtmlLabel2.TabIndex = 1;
            guna2HtmlLabel2.Text = "THƯƠNG GIA";
            guna2HtmlLabel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.BackColor = Color.FromArgb(0, 95, 110);
            guna2HtmlLabel1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(590, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(192, 42);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "PHỔ THÔNG";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.MiddleCenter;
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // FwatchFilght_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 503);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2HtmlLabel2);
            Name = "FwatchFilght_2";
            Text = "FwatchFilght_2";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}