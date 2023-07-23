using GUI.Views.View_User;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class FHomeUser : Form
    {
        public string _message;
        FthongTinNguoiDung _fTinNguoiDung;
        public FHomeUser()
        {
            InitializeComponent();
            _fTinNguoiDung = new FthongTinNguoiDung();
            label1.Visible = false;
        }

        public FHomeUser(string Message):this()
        {
            _message = Message;
            label1.Text = _message;
        }

        private void ChildForm(Form child)
        {
            guna2Panel1.Controls.Clear();
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            guna2Panel1.Controls.Add(child);
            child.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e) //button mua ve truc tuyen
        {
            FbuyTickket child = new();
            ChildForm(child);
            if (guna2Button1.Enabled == true)
            {
                guna2Button1.FillColor = Color.DarkCyan;

                guna2Button2.FillColor = Color.White;//màu background button
                guna2Button2.ForeColor = Color.Black;//thay màu chữ

                guna2Button3.FillColor = Color.White;
                guna2Button3.ForeColor = Color.Black;

                guna2Button4.FillColor = Color.White;
                guna2Button4.ForeColor = Color.Black;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)//button tinh trang chuyen bay
        {
            FtinhTrangChuyenBay child = new();
            ChildForm(child);
            if (guna2Button3.Enabled == true)
            {
                guna2Button3.FillColor = Color.DarkCyan;

                guna2Button1.FillColor = Color.White;
                guna2Button1.ForeColor = Color.Black;

                guna2Button2.FillColor = Color.White;
                guna2Button2.ForeColor = Color.Black;

                guna2Button4.FillColor = Color.White;
                guna2Button4.ForeColor = Color.Black;

            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)//button lich bay
        {
            FlichBay child = new();
            ChildForm(child);
            if (guna2Button4.Enabled == true)
            {
                guna2Button4.FillColor = Color.DarkCyan;

                guna2Button1.FillColor = Color.White;
                guna2Button1.ForeColor = Color.Black;

                guna2Button2.FillColor = Color.White;
                guna2Button2.ForeColor = Color.Black;

                guna2Button3.FillColor = Color.White;
                guna2Button3.ForeColor = Color.Black;

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FQuanLyChuyenBayUser child = new();
            ChildForm(child);
            if (guna2Button2.Enabled == true)
            {
                guna2Button2.FillColor = Color.DarkCyan;

                guna2Button1.FillColor = Color.White;
                guna2Button1.ForeColor = Color.Black;

                guna2Button3.FillColor = Color.White;
                guna2Button3.ForeColor = Color.Black;

                guna2Button4.FillColor = Color.White;
                guna2Button4.ForeColor = Color.Black;

            }
        }

        private void FHomeUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void đổiMặtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FDoimk fdk = new FDoimk(label1.Text);
            fdk.ShowDialog();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fTinNguoiDung.ShowDialog();
        }
    }
}
