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

        public FforGotPass()
        {
            _validate = new Validate();
            _services = new CustomerServices();
            InitializeComponent();
            btn_success.Enabled = false;
        }

        private async void btn_sendCode_Click(object sender, EventArgs e)
        {
            string email = tbx_email.Text;
            string subject = "Verify to Email";
            string body = "Your code otp is : ";
            if (await SendEmail(email, subject, body))
            {
                time.Visible = true;
                MessageBox.Show("Email Sent Successfully.");
                btn_sendCode.Enabled = false;
                btn_success.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lỗi rồi");
            }

        }
        private string randomCode()
        {
            int ran = 0;
            string code = "";
            for (int i = 0; i < 6; i++)
            {
                Random random = new Random();
                ran = random.Next(0, 10);
                code += ran.ToString();
            }
            return code;
        }
        string code_otp = "";
        public async Task<bool> SendEmail(string _email, string _subject, string _body)
        {
            try
            {
                if (tbx_email.Text != "" && _services.Get(tbx_email.Text).Email == tbx_email.Text)
                {
                    countDown.Interval = 100;
                    countDown.Start();
                    minutes = 5;
                    seconds = 60;
                    string senderID = "Bookingairline1@gmail.com";
                    string senderPassword = "spvhixkeagfawjqc";
                    string body = _body;
                    MailMessage mail = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    code_otp = randomCode();
                    body += code_otp;
                    try
                    {
                        mail.To.Add(_email);
                        mail.From = new MailAddress(senderID);
                        mail.Subject = _subject;
                        mail.Body = body;
                        mail.IsBodyHtml = true;
                        mail.Priority = MailPriority.High;
                        smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new System.Net.NetworkCredential(senderID, senderPassword);
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        await smtp.SendMailAsync(mail);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        int seconds = 60;
        int minutes = 5;
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
                        code_otp = randomCode();
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
                lb_errorCode.Text = "Email ko đúng định dạng";
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
                lb_errorPass.Text = "Email ko đúng định dạng";
                lb_errorPass.Visible = true;
                lb_errorPass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_errorPass.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}
