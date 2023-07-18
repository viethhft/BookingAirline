using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1.Views
{
    public partial class fDky : Form
    {
        IDangKyService _dangKyService;
        public fDky()
        {
            _dangKyService = new DangKyService();
            InitializeComponent();
            cbx_gender.Items.Add("Nam");
            cbx_gender.Items.Add("Nữ");
            cbx_gender.SelectedIndex = 0;
            this.MaximizeBox = false;
        }
        private string[] cutName(string name)
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
        private void txb_email_TextChanged(object sender, EventArgs e)
        {

        }
        private bool checkEmail(string email)
        {
            Regex regex = new Regex(@"([a-z0-9]{5})+@[a-z]+\.([a-z]{2,3}|[a-z]{2,3}.[a-z]{2,3})$");
            Match match = regex.Match(email);
            if (match != Match.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checkPhoneNumber(string phone)
        {
            Regex regex = new Regex(@"(0|\+84)([3|9|8|7|5])(\d{8})$");
            Match match = regex.Match(phone);
            if (match != Match.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btn_sign_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            string[] fullname = cutName(txb_name.Text);
            customer.FirstName = fullname[0].Trim();
            customer.MiddleName = fullname[1].Trim();
            customer.LastName = fullname[2].Trim();
            customer.Email = txb_email.Text;
            customer.Address = txb_address.Text;
            customer.Dob = Date.Value;
            customer.Phone = tbx_phone.Text;
            customer.Gender = cbx_gender.Text;
            customer.Password = tbx_pass1.Text;
            MessageBox.Show(_dangKyService.Create(customer));
        }

        private void btn_sign_MouseHover(object sender, EventArgs e)
        {
            btn_sign.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        }

        private void btn_sign_MouseLeave(object sender, EventArgs e)
        {
            btn_sign.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
        }

        private void btn_sign_MouseMove(object sender, MouseEventArgs e)
        {
            btn_sign.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        }
    }
}
