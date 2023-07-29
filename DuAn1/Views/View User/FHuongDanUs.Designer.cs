namespace GUI.Views.View_User
{
    partial class FHuongDanUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHuongDanUs));
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(249, 19);
            label1.Name = "label1";
            label1.Size = new Size(282, 19);
            label1.TabIndex = 0;
            label1.Text = "HƯỚNG DẪN SỬ DỤNG PHẦN MỀM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 49);
            label2.Name = "label2";
            label2.Size = new Size(787, 306);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // FHuongDanUs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 368);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FHuongDanUs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hướng dẫn sử dụng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
    }
}