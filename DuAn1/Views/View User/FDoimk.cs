using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Service;
using _2_BUS.Validate;
using DuAn1;
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

    public partial class FDoimk : Form
    {
        public string _message;

        bool _check_info = true;

        ICustomerServices _services;
        Validate _validate;
        public FDoimk()
        {
            InitializeComponent();
            _services = new CustomerServices();
            _validate = new Validate();

        }
        public FDoimk(string messege) : this()
        {
            _message = messege;
            lblWell.Text = "Chào mừng thượng đế: " + _message;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (tbx_passOld.Text != "" && tbx_passNew.Text != "" && tbx_passReNew.Text != "")
            {
                try
                {
                    if (tbx_passOld.Text == _services.GetCustomers().Where(c => c.Email == _message).FirstOrDefault().Password)
                    {
                        Customer customer = _services.Get(lblWell.Text);
                        customer.Password = _validate.ReversePass(tbx_passReNew.Text);
                        MessageBox.Show(_services.Update(customer));
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng xem lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng xem lại thông tin 2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng xem lại thông tin 2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbx_passOld_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_passReNew_TextChanged(object sender, EventArgs e)
        {
            if (tbx_passReNew.Text == tbx_passNew.Text)
            {
                lbl_passReNew.Text = "";
                lbl_passReNew.Visible = false;
                _check_info = true;
            }
            else
            {
                _check_info = false;
                lbl_passReNew.Text = "Mật khẩu nhập lại phải trùng khớp mật khẩu đã nhập!";
                lbl_passReNew.Visible = true;
                lbl_passReNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                lbl_passReNew.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
