using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using _2_BUS.IService;
using _2_BUS.Service;
using _1_DAL.Models;
using _2_BUS.Validate;

namespace DuAn1.Views
{
    public partial class FforGotPass : Form
    {
        bool _check_info = true;

        ICustomerServices _services;
        Validate _validate;
        string code_otp = "";
        int seconds = 60;
        int minutes = 5;
        public FforGotPass()
        {
            _validate = new Validate();
            _services = new CustomerServices();
            InitializeComponent();
            btn_success.Enabled = false;
        }

        private async void btn_sendCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbx_email.Text != "" && _services.Get(tbx_email.Text).Email == tbx_email.Text)
                {
                    countDown.Interval = 1000;
                    countDown.Start();
                    minutes = 5;
                    seconds = 60;
                    string email = tbx_email.Text;
                    string subject = "Verify to Email";
                    string body = "Your code otp is : ";
                    int role_id = 99;
                    code_otp = _validate.randomCode();
                    if (await _validate.SendEmail(email, subject, body, code_otp,role_id))
                    {
                        time.Visible = true;
                        MessageBox.Show("Email Sent Successfully.");
                        btn_sendCode.Enabled = false;
                        btn_success.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("");
                    }
                }
                else
                {
                    MessageBox.Show("Email chưa được sử dụng để đăng ký");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Email chưa được sử dụng để đăng ký");
            }

        }
            
        
        private void countDown_Tick(object sender, EventArgs e)
        {
            btn_sendCode.Enabled = false;
            if (minutes > -2)
            {
                seconds--;
                lb_Minutes.Text = "0" + minutes.ToString();
                lb_Seconds.Text = seconds.ToString();
                if (minutes == 5)
                {
                    minutes--;
                    lb_Minutes.Text = "0" + minutes.ToString();
                }
                if (seconds == 0)
                {
                    minutes--;
                    if (minutes == -1)
                    {
                        minutes = -2;
                        minutes = 0;
                        seconds = 0;
                        lb_Minutes.Text = "00";
                        lb_Seconds.Text = "00";
                        btn_sendCode.Enabled = true;
                        code_otp = _validate.randomCode();
                        countDown.Stop();
                    }
                    lb_Minutes.Text = "0" + minutes.ToString();
                    seconds = 60;
                }
            }
        }

        private void btn_success_Click(object sender, EventArgs e)
        {
            if (tbx_email.Text != "" && tbx_ma.Text != "" && tbx_pass2.Text != "" && txb_pass1.Text != ""&& tbx_pass2.Text!="")
            {
                if (tbx_ma.Text == code_otp)
                {
                    if (_check_info)
                    {
                        Customer customer = _services.Get(tbx_email.Text);
                        customer.Password = txb_pass1.Text;
                        MessageBox.Show(_services.Update(customer));
                    }
                    else
                    {
                        MessageBox.Show("Thông tin điền đúng thông tin yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                MessageBox.Show("Thông tin điền đúng thông tin yêu cầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbx_email_TextChanged(object sender, EventArgs e)
        {
            if (_validate.checkEmail(tbx_email.Text))
            {
                lb_errorEmail.Text = "";
                lb_errorEmail.Visible = false;
                _check_info = true;
            }
            else
            {
                _check_info = false;
                lb_errorEmail.Text = "Email ko đúng định dạng";
                lb_errorEmail.Visible = true;
                lb_errorEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_errorEmail.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void tbx_ma_TextChanged(object sender, EventArgs e)
        {
            if (tbx_ma.Text == code_otp)
            {
                lb_errorCode.Text = "";
                lb_errorCode.Visible = false;
                _check_info = true;
            }
            else
            {
                _check_info = false;
                lb_errorCode.Text = "Mã otp nhập chưa đúng mã được cấp";
                lb_errorCode.Visible = true;
                lb_errorCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_errorCode.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void tbx_pass2_TextChanged(object sender, EventArgs e)
        {
            if (tbx_pass2.Text == txb_pass1.Text)
            {
                lb_errorPass.Text = "";
                lb_errorPass.Visible = false;
                _check_info = true;
            }
            else
            {
                _check_info = false;
                lb_errorPass.Text = "Mật khẩu nhập lại phải trùng khớp mật khẩu đã nhập!";
                lb_errorPass.Visible = true;
                lb_errorPass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_errorPass.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}
