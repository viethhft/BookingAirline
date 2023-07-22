using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views.View_User
{
    public partial class FbuyTickket : Form
    {
        public FbuyTickket()
        {
            InitializeComponent();
        }

        private void FbuyTickket_Load(object sender, EventArgs e)
        {
            textBox1.Hide();
            guna2DateTimePicker2.Hide();
            guna2HtmlLabel8.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            guna2Button5.Hide();
        }

        private void FbuyTickket_Click(object sender, EventArgs e)
        {
            guna2Button5.Show();
            textBox1.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Button5.Show();
            textBox1.Hide();
            guna2DateTimePicker2.Show();
            guna2HtmlLabel8.Show();
            if (guna2Button2.Enabled == true)
            {
                guna2Button2.FillColor = Color.DarkCyan;
                guna2Button1.FillColor = Color.White;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Button5.Show();
            textBox1.Hide();
            guna2DateTimePicker2.Hide();
            guna2HtmlLabel8.Hide();
            if (guna2Button1.Enabled == true)
            {
                guna2Button1.FillColor = Color.FromArgb(222, 180, 135);
                guna2Button2.FillColor = Color.White;
            }
        }
    }
}
