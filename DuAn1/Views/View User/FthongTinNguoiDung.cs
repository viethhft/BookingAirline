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
        private string _message="";

        ICustomerServices _service;

        public FthongTinNguoiDung()
        {
            _service = new CustomerServices();
            InitializeComponent();
            cbx_gt.Items.Add("Nam");
            cbx_gt.Items.Add("Nữ");
            load();

        }


        public FthongTinNguoiDung(string message) : this()
        {
            _message = message;
        }

        public void load()
        {
            foreach (var item in _service.GetCustomers())
            {
                
                    tbx_email.Text = item.Email;
                    tbx_diaChi.Text = item.Address;
                    tbx_hoTen.Text = item.FirstName+ item.MiddleName+ item.LastName;
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


    }
}
