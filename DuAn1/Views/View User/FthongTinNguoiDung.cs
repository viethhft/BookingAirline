using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Service;
using _2_BUS.Validate;
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
    public partial class FthongTinNguoiDung : Form
    {
        private string _message = "";

        ICustomerServices _service;
        Validate _validate;
        bool _check_information = true;
        public FthongTinNguoiDung()
        {
            _service = new CustomerServices();
            InitializeComponent();
            cbx_gt.Items.Add("Nam");
            cbx_gt.Items.Add("Nữ");
            _validate = new Validate();
            load();
            Unelable();

        }


        public FthongTinNguoiDung(string message) : this()
        {
            _message = message;
            _service = new CustomerServices();
            load();
           
        }

        public void load()
        {
            foreach (var item in _service.GetCustomers())
            {

                tbx_email.Text = item.Email;
                tbx_diaChi.Text = item.Address;
                tbx_hoTen.Text = item.FirstName + " " + item.MiddleName + " " + item.LastName;
                if (item.Gender == "Nam")
                {
                    cbx_gt.Text = "Nam";
                }
                else
                {
                    cbx_gt.Text = "Nữ";
                }
                date_bird.Value = (DateTime)(item.Dob);
                tbx_sdt.Text = item.Phone;
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            tbx_email.Enabled = false;
            tbx_diaChi.Enabled = true;
            tbx_hoTen.Enabled = true;
            cbx_gt.Enabled = true;
            date_bird.Enabled = true;
            tbx_sdt.Enabled = true;
            btn_update.Enabled = true;

            btn_sua.Enabled = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tbx_email.Text != "" || tbx_diaChi.Text != "" || tbx_hoTen.Text != "" || cbx_gt.Text != "" || date_bird.Text != "" || tbx_sdt.Text != "")
            {
                Customer custom = _service.GetCustomers().Where(c => c.Email == _message).FirstOrDefault();
                custom.Address = tbx_diaChi.Text;
                string[] name = _validate.cutName(tbx_hoTen.Text);
                custom.FirstName = name[0];
                custom.MiddleName = name[1];
                custom.LastName = name[2];
                custom.Phone = tbx_sdt.Text;
                if (cbx_gt.Text == "Nam")
                {
                    custom.Gender = "Nam";
                }
                else
                {
                    custom.Gender = "Nữ";
                }
                date_bird.Value = (DateTime)(custom.Dob);
                MessageBox.Show(_service.Update(custom));
                Unelable();
                load();
            }
            else
            {
                MessageBox.Show("Không thể sửa!");
            }
        }

        private void Unelable()
        {
            tbx_email.Enabled = false;
            tbx_diaChi.Enabled = false;
            tbx_hoTen.Enabled = false;
            cbx_gt.Enabled = false;
            date_bird.Enabled = false;
            tbx_sdt.Enabled = false;

            btn_sua.Enabled = true;

            btn_update.Enabled = false;
        }

        private void tbx_hoTen_TextChanged(object sender, EventArgs e)
        {
            if (_validate.checkName(tbx_hoTen.Text))
            {
                label1.Text = "";
                label1.Visible = false;
                _check_information = true;
            }
            else
            {
                _check_information = false;
                label1.Text = "Không đúng định dạng tên";
                label1.Visible = true;
                label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                label1.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void tbx_sdt_TextChanged(object sender, EventArgs e)
        {
            if (_validate.checkPhoneNumber(tbx_sdt.Text))
            {
                label3.Text = "";
                label3.Visible = false;
                _check_information = true;
            }
            else
            {
                _check_information = false;
                label3.Text = "Không đúng định dạng số điện thoại";
                label3.Visible = true;
                label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular);
                label3.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void tbx_diaChi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
