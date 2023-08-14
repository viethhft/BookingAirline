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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views.View_User
{
    public partial class FtaikhoanNh : Form
    {
        IBankServices _bankServices;
        ICustomerServices _customerServices;
        public FtaikhoanNh()
        {
            _customerServices = new CustomerServices();
            _bankServices = new BankServices();
            InitializeComponent();
        }
        long _id = 0;
        public FtaikhoanNh(int id) : this()
        {
            _id = id;
        }
        bool checkDup()
        {
            foreach (var item in _bankServices.List_bank())
            {
                if (item.BankAccountNum == Convert.ToInt32(txt_BankNumber.Text))
                {
                    return false;
                }
            }
            return true;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (checkDup())
            {
                var cus = _customerServices.GetCustomers().Where(c => c.Id == _id).FirstOrDefault();
                if (cus != null)
                {
                    Bank bank = new Bank();
                    bank.DisplayName = txt_Name.Text;
                    bank.CustomerId = cus.Id;
                    bank.BankAccountNum = Convert.ToInt32(txt_BankNumber.Text);
                    MessageBox.Show(_bankServices.create(bank));
                }
            }
            else
            {
                MessageBox.Show("Số tài khoản đã được sử dụng");
            }
            }

            private void txt_BankNumber_TextChanged(object sender, EventArgs e)
            {
                if (txt_BankNumber.Text != "")
                {
                    char[] number = txt_BankNumber.Text.ToCharArray();
                    int index = 0;
                    try
                    {
                        for (int i = 0; i < number.Length; i++)
                        {
                            index = i;
                            Convert.ToInt32(number[i].ToString());
                        }
                    }
                    catch (Exception)
                    {
                        string term = "";
                        for (int i = 0; i < number.Length; i++)
                        {
                            if (i != index)
                            {
                                term += number[i].ToString();
                            }
                        }
                        txt_BankNumber.Text = term;
                    }
                }

            }
        }
    }
