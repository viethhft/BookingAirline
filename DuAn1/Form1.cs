﻿using DuAn1.Views;
using _2_BUS.Service;
using _2_BUS.IService;
using GUI.Views;

namespace DuAn1
{
    public partial class Form1 : Form
    {
        CheckAccountType _checkAccountType;
        fStaff _fst;
        QlykhachHang _f;
        fDky _fdky;
        FforGotPass _fForgot;
        fuser _fnguoidung;
        public Form1()

        {
            _checkAccountType = new();
            _fst = new fStaff();
            _f = new();
            _fdky = new fDky();
            _fForgot = new FforGotPass();
            _fnguoidung = new();
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (_checkAccountType.CheckType(tb_user.Text, tb_pass.Text) == 1)
            {
                this.Hide();
                MessageBox.Show("Đăng nhập admin thành công");
                _fst.ShowDialog();
                this.Show();
            }
            else if (_checkAccountType.CheckType(tb_user.Text, tb_pass.Text) == 2)
            {
                this.Hide();
                MessageBox.Show("Đăng nhập nhân viên thành công");
                _fst.ShowDialog();
                this.Show();
            }
            else if (_checkAccountType.CheckType(tb_user.Text, tb_pass.Text) == 3)
            {
                this.Hide();
                MessageBox.Show("Đăng nhập thành công");
                _fnguoidung.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
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
        }

        private void btn_login_MouseHover(object sender, EventArgs e)
        {
            btn_login.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
        }

        private void btn_login_MouseMove(object sender, MouseEventArgs e)
        {
            btn_login.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Bán vé máy bay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}