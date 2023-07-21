using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Mail;
using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Service;
using System.Security.Cryptography;

namespace _2_BUS.Validate
{
    public class Validate
    {
        IStaffServices _staffServices;
        public Validate()
        {
            _staffServices = new StaffServices();
        }
        public bool checkEmail(string email)
        {
            Regex regex = new Regex(@"([a-z0-9]{5})+@[a-z]+\.([a-z]{2,3}|[a-z]{2,3}.[a-z]{2,3})$");
            Match match = regex.Match(email);
            if (match != Match.Empty)
            {
                return true;
            }
            return false;
        }
        public string[] cutName(string name)
        {
            string[] term = name.Split(' ');
            int number = 0;
            string firstname = "";
            string middlename = "";
            string lastname = "";
            for (int i = 0; i < term.Length; i++)
            {
                if (term[i] != " ")
                {
                    number++;
                    if (number == 1)
                    {
                        firstname = term[i].Trim();
                    }
                    else
                    {
                        middlename += term[i] + " ";
                    }
                }
            }
            string[] term1 = middlename.Trim().Split(' ');
            middlename = "";
            for (int i = 0; i < term1.Length - 1; i++)
            {
                middlename += term1[i] + " ";
            }
            lastname = term1[term1.Length - 1];
            string[] name1 = { firstname, middlename, lastname };
            return name1;
        }

        public bool checkPhoneNumber(string phone)
        {
            Regex regex = new Regex(@"(0|\+84)([3|9|8|7|5])(\d{8})$");
            Match match = regex.Match(phone);
            if (match != Match.Empty)
            {
                return true;
            }
            return false;
        }
        public bool checkName(string name)
        {
            Regex regex = new Regex(@"[a-zỳọáầảấờễàạằệếýộậốũứĩõúữịỗìềểẩớặòùồợãụủíỹắẫựỉỏừỷởóéửỵẳẹèẽổẵẻỡơôưăêâđ'A-ZỲỌÁẦẢẤỜỄÀẠẰỆẾÝỘẬỐŨỨĨÕÚỮỊỖÌỀỂẨỚẶÒÙỒỢÃỤỦÍỸẮẪỰỈỎỪỶỞÓÉỬỴẲẸÈẼỔẴẺỠƠÔƯĂÊÂĐ']{2,10}((\s[a-zỳọáầảấờễàạằệếýộậốũứĩõúữịỗìềểẩớặòùồợãụủíỹắẫựỉỏừỷởóéửỵẳẹèẽổẵẻỡơôưăêâđ'A-ZỲỌÁẦẢẤỜỄÀẠẰỆẾÝỘẬỐŨỨĨÕÚỮỊỖÌỀỂẨỚẶÒÙỒỢÃỤỦÍỸẮẪỰỈỎỪỶỞÓÉỬỴẲẸÈẼỔẴẺỠƠÔƯĂÊÂĐ']{2,10})){2,10}$");
            Match match = regex.Match(name);
            if (match != Match.Empty)
            {
                return true;
            }
            return false;
        }
        public async Task<bool> SendEmail(string _email, string _subject, string _body, string code_otp,int role)
        {
            try
            {
                staff staff = _staffServices.get(role);
                string senderID =staff.Email;
                string senderPassword =staff.Password;
                string body = _body;
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient();
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
            catch (Exception)
            {
                return false;
            }
        }
        public string randomCode()
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
        public string ReversePass(string password)
        {
            byte[] pass_byte = ASCIIEncoding.ASCII.GetBytes(password);
            MD5 mD5 = MD5.Create();

            var haspass = mD5.ComputeHash(pass_byte);
            string savehas = "";

            foreach (var item in haspass)
            {
                savehas += item;
            }

            char[] term = savehas.ToCharArray();
            Array.Reverse(term);
            string new_haspasscode = new string(term);

            pass_byte = ASCIIEncoding.ASCII.GetBytes(new_haspasscode);
            haspass = mD5.ComputeHash(pass_byte);
            savehas = "";
            foreach (var item in haspass)
            {
                savehas += item;
            }

            char[] chars = savehas.ToCharArray();
            var char_reverse = chars.Select((value, index) => new { value, index }).ToArray();
            var finish = char_reverse.Select(c => c.value + c.index + (char_reverse.Length > c.index + 1 ? char_reverse[c.index + 1].value % 2 : char_reverse[c.index / 2].value % 2)).Select(c => (char)c).ToArray();
            string new_char = new string(finish);
            foreach (var item in char_reverse)
            {
                new_char += item.value;
            }

            return new_char;
        }
    }
}
