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
        bool _check_information = true;
        ICustomerServices _dangKyService;
        public fDky()
        {
            _dangKyService = new CustomerServices();
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
        private bool checkEmail(string email)
        {
            Regex regex = new Regex(@"([a-z0-9]{5})+@[a-z]+\.([a-z]{2,3}|[a-z]{2,3}.[a-z]{2,3})$");
            Match match = regex.Match(email);
            if (match != Match.Empty)
            {
                return true;
            }
                return false;
        }
        private bool checkPhoneNumber(string phone)
        {
            Regex regex = new Regex(@"(0|\+84)([3|9|8|7|5])(\d{8})$");
            Match match = regex.Match(phone);
            if (match != Match.Empty)
            {
                return true;
            }
                return false;
        }
        private bool checkName(string name)
        {
            Regex regex = new Regex(@"[a-zA-z]{2,10}((\s[a-zA-z]{2,10})){2,10}$");
            Match match=regex.Match(name);
            if (match!=Match.Empty)
            {
                return true;
            }
            return false;
        }

        void reset() // clean oo nhaap
        {
           
            txb_address.Text = "";
            txb_email.Text = "";
            txb_name.Text = "";
            tbx_pass1.Text = "";
            tbx_pass2.Text = "";
            tbx_phone.Text = "";
            cbx_gender.Text = "";
            lb_ErrorEmail.Visible = false;
            lb_ErrorName.Visible = false;
            lb_ErrorPhoneNumber.Visible = false;
            lb_ErrorPassAgain.Visible = false;
        }
        private void btn_sign_Click(object sender, EventArgs e)
        {
            if (txb_name.Text == "" || txb_address.Text == "" || txb_email.Text == "" || tbx_phone.Text == "" || tbx_pass1.Text == ""||tbx_pass2.Text=="") _check_information = false;
            if (_check_information)
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
                reset();
            }
            else
            {
                MessageBox.Show("Thông tin điền chưa hợp lệ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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

        private void txb_email_TextChanged(object sender, EventArgs e)
        {
            if (checkEmail(txb_email.Text))
            {
                lb_ErrorEmail.Text = "";
                lb_ErrorEmail.Visible = false;
                _check_information = true;
            }
            else
            {
                _check_information = false;
                lb_ErrorEmail.Text = "Không đúng định dạng email";
                lb_ErrorEmail.Visible = true;
                lb_ErrorEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_ErrorEmail.ForeColor= System.Drawing.Color.Red;
            }
        }

        private void tbx_phone_TextChanged(object sender, EventArgs e)
        {
            if (checkPhoneNumber(tbx_phone.Text))
            {
                lb_ErrorPhoneNumber.Text = "";
                lb_ErrorPhoneNumber.Visible = false;
                _check_information = true;
            }
            else
            {
                _check_information = false;
                lb_ErrorPhoneNumber.Text = "Không đúng định dạng số điện thoại";
                lb_ErrorPhoneNumber.Visible = true;
                lb_ErrorPhoneNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_ErrorPhoneNumber.ForeColor = System.Drawing.Color.Red;
            }
        }
        
        private void tbx_pass2_TextChanged(object sender, EventArgs e)
        {
            string pass1 = tbx_pass1.Text;
            string pass2 = tbx_pass2.Text;
            if (pass1==pass2)
            {
                lb_ErrorPassAgain.Text = "";
                lb_ErrorPassAgain.Visible = false;
                _check_information = true;
            }
            else
            {
                _check_information = false;
                lb_ErrorPassAgain.Text = "Mật khẩu phải trùng mật khẩu đã nhập";
                lb_ErrorPassAgain.Visible = true;
                lb_ErrorPassAgain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_ErrorPassAgain.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txb_name_TextChanged(object sender, EventArgs e)
        {
            if (checkName(txb_name.Text))
            {
                lb_ErrorName.Text = "";
                lb_ErrorName.Visible = false;
                _check_information = true;
            }
            else
            {
                _check_information = false;
                lb_ErrorName.Text = "Không đúng định dạng tên";
                lb_ErrorName.Visible = true;
                lb_ErrorName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lb_ErrorName.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
