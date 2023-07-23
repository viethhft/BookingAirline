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
    public partial class FthongTinNguoiDung : Form
    {
        private string _message = "";

        ICustomerServices _service;

        public FthongTinNguoiDung()
        {
            _service = new CustomerServices();
            InitializeComponent();
        }


        public FthongTinNguoiDung(string message) : this()
        {
            _message = message;
            cbx_gt.Items.Add("Nam");
            cbx_gt.Items.Add("Nữ");
            _service = new CustomerServices();
            load();
           
        }

        public void load()
        {
            Customer item = _service.GetCustomers().Where(c => c.Email == _message).FirstOrDefault();

            tbx_email.Text = item.Email;
            tbx_diaChi.Text = item.Address;
            tbx_hoTen.Text = item.FirstName + " " + item.MiddleName + " " + item.LastName;
            cbx_gt.Text = item.Gender;
            date_bird.Value = (DateTime)(item.Dob);
            tbx_sdt.Text = item.Phone;
        }


    }
}
