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

namespace DuAn1.Views
{
    public partial class QlykhachHang : Form
    {
        CustomerServices _cusServices;
        public QlykhachHang()
        {
            _cusServices = new CustomerServices();
            InitializeComponent();
        }

        private void QlykhachHang_Load(object sender, EventArgs e)
        {
            dtgv_kh.ColumnCount = 7;
            dtgv_kh.Columns[0].Name = "STT";
            dtgv_kh.Columns[1].Name = "Tên khách hàng";
            dtgv_kh.Columns[2].Name = "Email";
            dtgv_kh.Columns[3].Name = "Ngày sinh";
            dtgv_kh.Columns[4].Name = "SĐT";
            dtgv_kh.Columns[5].Name = "Địa chỉ";
            dtgv_kh.Columns[6].Name = "Giới tính";

            foreach (var i in _cusServices.GetCustomers())
            {
                dtgv_kh.Rows.Add(i.Id, i.FirstName + " " + i.MiddleName + " " + i.LastName, i.Email, i.Dob.ToString(), i.Phone, i.Address, i.Gender);
            }
        }
    }
}
