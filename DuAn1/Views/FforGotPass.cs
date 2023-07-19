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

namespace DuAn1.Views
{
    public partial class FforGotPass : Form
    {
        public FforGotPass()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btn_sendCode_Click(object sender, EventArgs e)
        {
            string email = tbx_email.Text;
            string subject = " ";
            string body = "";
            if (await SendEmail(email, subject, body))
            {
                MessageBox.Show("Email Sent Successfully.");
                btn_sendCode.Enabled = false;
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
        public async Task<bool> SendEmail(string _email, string _subject, string _body)
        {
            if (tbx_email.Text!="")
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
                body += randomCode();
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

        private void CountDown()
        {
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
                        countDown.Stop();
                        btn_sendCode.Enabled = true;
                    }
                    lb_Minutes.Text = "0" + minutes.ToString();
                    seconds = 60;
                }
            }
        }

        private void btn_success_Click(object sender, EventArgs e)
        {
        }

        private void lb_Seconds_Click(object sender, EventArgs e)
        {

        }
    }
}
