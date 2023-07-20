using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _2_BUS.Validate
{
    public class Validate
    {
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
                        lastname = term[i].Trim();
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
            firstname = term1[term1.Length - 1];
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
            Regex regex = new Regex(@"[a-zA-z]{2,10}((\s[a-zA-z]{2,10})){2,10}$");
            Match match = regex.Match(name);
            if (match != Match.Empty)
            {
                return true;
            }
            return false;
        }

    }
}
