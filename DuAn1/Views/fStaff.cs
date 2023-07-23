using _2_BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1.Views
{
    public partial class fStaff : Form
    {
        CheckAccountType _check;
        StaffServices _serv;
        public int _role;
        public fStaff()
        {
            _check = new CheckAccountType();
            _serv = new StaffServices();
            InitializeComponent();
        }
        public fStaff(int role) : this()
        {
            _role = role;
            EnableButton();
        }
        private void EnableButton()
        {
            if (_role == 1)
            {
                btn_qlynv.Enabled = false;
            }
            else
            {
                btn_qlynv.Enabled = true;
            }
        }

        private void ChildForm(Form child)
        {
            pn_chil.Controls.Clear();
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pn_chil.Controls.Add(child);
            child.Show();
        }
        private void btn_qlynv_Click(object sender, EventArgs e)
        {
            Fquanlynv child = new();
            ChildForm(child);

            if (btn_qlynv.Enabled == true)
            {
                btn_qlynv.BackColor = Color.DarkCyan;
                btn_qlynv.ForeColor = Color.White;

                btn_dthu.BackColor = Color.White;
                btn_dthu.ForeColor = Color.Black;

                btn_qlyve.BackColor = Color.White;
                btn_qlyve.ForeColor = Color.Black;

                btn_qlykh.BackColor = Color.White;
                btn_qlykh.ForeColor = Color.Black;

                btn_qlyflight.BackColor = Color.White;
                btn_qlyflight.ForeColor = Color.Black;

            }
        }

        private void btn_dthu_Click(object sender, EventArgs e)
        {
            FquanLyDoanhThu child = new FquanLyDoanhThu();
            ChildForm(child);
            if (btn_dthu.Enabled == true)
            {
                btn_dthu.BackColor = Color.DarkCyan;
                btn_dthu.ForeColor = Color.White;

                btn_qlynv.BackColor = Color.White;
                btn_qlynv.ForeColor = Color.Black;

                btn_qlyve.BackColor = Color.White;
                btn_qlyve.ForeColor = Color.Black;

                btn_qlykh.BackColor = Color.White;
                btn_qlykh.ForeColor = Color.Black;

                btn_qlyflight.BackColor = Color.White;
                btn_qlyflight.ForeColor = Color.Black;


            }
        }

        private void btn_qlyve_Click(object sender, EventArgs e)
        {
            FquanlyVe child = new FquanlyVe();
            ChildForm(child);

            if (btn_qlyve.Enabled == true)
            {
                btn_qlyve.BackColor = Color.DarkCyan;
                btn_qlyve.ForeColor = Color.White;

                btn_qlynv.BackColor = Color.White;
                btn_qlynv.ForeColor = Color.Black;

                btn_dthu.BackColor = Color.White;
                btn_dthu.ForeColor = Color.Black;

                btn_qlykh.BackColor = Color.White;
                btn_qlykh.ForeColor = Color.Black;

                btn_qlyflight.BackColor = Color.White;
                btn_qlyflight.ForeColor = Color.Black;
            }
        }

        private void btn_qlyflight_Click(object sender, EventArgs e)
        {
            FQuanLyChuyenBay child = new();
            ChildForm(child);
            if (btn_qlyflight.Enabled == true)
            {
                btn_qlyflight.BackColor = Color.DarkCyan;
                btn_qlyflight.ForeColor = Color.White;

                btn_qlynv.BackColor = Color.White;
                btn_qlynv.ForeColor = Color.Black;

                btn_dthu.BackColor = Color.White;
                btn_dthu.ForeColor = Color.Black;

                btn_qlyve.BackColor = Color.White;
                btn_qlyve.ForeColor = Color.Black;

                btn_qlykh.BackColor = Color.White;
                btn_qlykh.ForeColor = Color.Black;
            }
        }

        private void btn_qlykh_Click(object sender, EventArgs e)
        {
            QlykhachHang child = new QlykhachHang();
            ChildForm(child);
            if (btn_qlykh.Enabled == true)
            {
                btn_qlykh.BackColor = Color.DarkCyan;
                btn_qlykh.ForeColor = Color.White;

                btn_qlynv.BackColor = Color.White;
                btn_qlynv.ForeColor = Color.Black;

                btn_dthu.BackColor = Color.White;
                btn_dthu.ForeColor = Color.Black;

                btn_qlyve.BackColor = Color.White;
                btn_qlyve.ForeColor = Color.Black;

                btn_qlyflight.BackColor = Color.White;
                btn_qlyflight.ForeColor = Color.Black;
            }
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn đăng xuất không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
