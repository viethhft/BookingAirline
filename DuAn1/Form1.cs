using DuAn1.Controllers.Controller;
using DuAn1.Views;

namespace DuAn1
{
    public partial class Form1 : Form
    {
        CheckAccountType _checkAccountType;
        fStaff _fst;
        form _f;
        fDky _fdky;
        public Form1()
        {
            _checkAccountType = new();
            _fst = new fStaff();
            _f = new();
            _fdky = new fDky();
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (_checkAccountType.CheckType(tb_user.Text, tb_pass.Text) == 1)
            {
                this.Hide();
                MessageBox.Show("Dang nhap admin thanh cong");
                _fst.ShowDialog();
                this.Show();
            }
            else if (_checkAccountType.CheckType(tb_user.Text, tb_pass.Text) == 2)
            {
                this.Hide();
                MessageBox.Show("Dang nhap nhan vien thanh cong");
                _fst.ShowDialog();
                this.Show();
            }
            else
            {
                this.Hide();
                MessageBox.Show("Dang nhap thanh cong");
                _f.ShowDialog();
                this.Show();
            }
        }

        private void llb_dki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            _fdky.ShowDialog();
            this.Show();
        }
    }
}