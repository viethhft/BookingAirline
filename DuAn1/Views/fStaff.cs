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
        string _username;
        string _password;
        public fStaff()
        {
            _check = new CheckAccountType();
            _serv = new StaffServices();
            InitializeComponent();
        }
        public fStaff(string username, string password)
        {
            _username = username;
            _password = password;
        }
        private void EnableButton()
        {
            if(_check.CheckType(_username,_password) == 1)
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
        }

        private void btn_dthu_Click(object sender, EventArgs e)
        {
            FquanLyDoanhThu child = new FquanLyDoanhThu();
            ChildForm(child);
        }

        private void btn_qlyve_Click(object sender, EventArgs e)
        {
            FquanlyVe child = new FquanlyVe();
            ChildForm(child);
        }

        private void btn_qlyflight_Click(object sender, EventArgs e)
        {
            FQuanLyChuyenBay child = new();
            ChildForm(child);
        }

        private void btn_qlykh_Click(object sender, EventArgs e)
        {
            QlykhachHang child = new QlykhachHang();
            ChildForm(child);
        }
    }
}
