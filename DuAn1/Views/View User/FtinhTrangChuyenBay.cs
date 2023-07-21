using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views.View_User
{
    public partial class FtinhTrangChuyenBay : Form
    {
        public FtinhTrangChuyenBay()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2ComboBox1.Enabled = true;
            guna2ComboBox2.Enabled = true;
            guna2DateTimePicker1.Enabled = true;
            richTextBox1.Enabled = false;
            if (guna2Button1.Enabled = true)
            {
                guna2Button2.FillColor = Color.White;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2ComboBox1.Enabled = false;
            guna2ComboBox2.Enabled = false;
            guna2DateTimePicker1.Enabled = true;
            richTextBox1.Enabled = true;
            if (guna2Button2.Enabled = true)
            {
                guna2Button1.FillColor = Color.White;   
            }
        }

        private void FtinhTrangChuyenBay_Load(object sender, EventArgs e)
        {
            guna2ComboBox1.Enabled = false;
            guna2ComboBox2.Enabled = false;
            guna2DateTimePicker1.Enabled = false;
            richTextBox1.Enabled = false;
        }
    }
}
