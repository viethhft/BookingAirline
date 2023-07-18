using DuAn1.Views;
using _2_BUS.Service;
using _2_BUS.IService;
namespace DuAn1
{
    public partial class Form1 : Form
    {
        CheckAccountType _checkAccountType;
        fStaff _fst;
        form _f;
        fDky _fdky;
        FforGotPass _fForgot;
        public Form1()

        {
            _checkAccountType = new();
            _fst = new fStaff();
            _f = new();
            _fdky = new fDky();
            _fForgot= new FforGotPass();
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (_checkAccountType.CheckType(tb_user.Text, tb_pass.Text) == 1)
            {
                if (cb_reme.Checked == true)
                {
                    MessageBox.Show("ok");
                }
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

        private void llb_forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            _fForgot.ShowDialog();
            this.Show();
        }

        private void llb_dki_MouseHover(object sender, EventArgs e)
        {
            llb_dki.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
        }

        private void llb_dki_MouseMove(object sender, MouseEventArgs e)
        {
            llb_dki.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
        }

        private void llb_dki_MouseLeave(object sender, EventArgs e)
        {
            llb_dki.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
        }

        private void llb_forgot_MouseHover(object sender, EventArgs e)
        {
            llb_forgot.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
        }

        private void llb_forgot_MouseMove(object sender, MouseEventArgs e)
        {
            llb_forgot.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
        }

        private void llb_forgot_MouseLeave(object sender, EventArgs e)
        {
            llb_forgot.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
            if (1 == 1)
            {

            }
        }

    }
}