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

        private void guna2Button1_Click(object sender, EventArgs e) // dđây là button hành trình
        {
            HienThiHanhTrinh();
            richTextBox1.Hide();
            guna2HtmlLabel10.Hide();
            guna2HtmlLabel9.Hide();
            if (guna2Button1.Enabled == true)
            {
                guna2Button2.FillColor = Color.White;
                guna2Button1.FillColor = Color.DarkCyan;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)//đây là button số hiệu chuyến bay
        {
            guna2HtmlLabel2.Hide();
            guna2HtmlLabel6.Hide();
            guna2HtmlLabel3.Hide();
            guna2HtmlLabel7.Hide();
            guna2ComboBox1.Hide();
            guna2ComboBox2.Hide();
            HienThiSoHieuChuyenBay();
            if (guna2Button2.Enabled == true)
            {
                guna2Button1.FillColor = Color.White;
                guna2Button2.FillColor = Color.DarkCyan;
            }
        }

        private void FtinhTrangChuyenBay_Load(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.DarkCyan;
            richTextBox1.Hide();
            guna2HtmlLabel10.Hide();
            guna2HtmlLabel9.Hide();
        }

        private void HienThiSoHieuChuyenBay() // HIỂN THỊ các nút trong số hiệu chuuyến bay
        {
            richTextBox1.Show();
            guna2HtmlLabel10.Show();
            guna2HtmlLabel9.Show();
        }

        private void HienThiHanhTrinh() //Hiển thị các nút trong hành trình
        {
            guna2HtmlLabel2.Show();
            guna2HtmlLabel6.Show();
            guna2HtmlLabel3.Show();
            guna2HtmlLabel7.Show();
            guna2ComboBox1.Show();
            guna2ComboBox2.Show();
        }
    }
}
