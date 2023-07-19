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
            string name = "a";
            string phone = "a";
            string email = tbx_email.Text;
            string description = "a";
            if (SendEmail(name, phone, email, description))
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("đéo");
            }
        }
        private string randomCode()
        {
            int ran = 0;
            string code = "";
            for (int i = 0; i < 6; i++)
            {
                Random random=new Random();
                ran = random.Next(0,10);
                code += ran.ToString();
            }
            return code;
        }
        public bool SendEmail(string _name, string _phone, string _email, string _description)
        {
            string senderID = "Bookingairline1@gmail.com";
            string senderPassword = "spvhixkeagfawjqc";
            string body = "Your code verify is ";
            body += randomCode();
            MailMessage mail = new MailMessage();
            mail.To.Add(_email);
            mail.From = new MailAddress(senderID);
            mail.Subject = "Verify To Email!";
            mail.Body = body;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential(senderID, senderPassword);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(mail);
            return true;
        }
    }
}
