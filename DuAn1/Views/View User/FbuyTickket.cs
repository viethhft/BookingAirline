using _1_DAL.IRepon;
using _2_BUS.IService;
using _2_BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views.View_User
{
    public partial class FbuyTickket : Form
    {
        bool check_button = true;
        IClassServices _classServices;
        ILocationServices _locationServices;
        IFlightServices _flightServices;
        public FbuyTickket()
        {
            _flightServices = new FlightServices();
            _classServices = new ClassServices();
            _locationServices = new LocationService();
            InitializeComponent();
            load();
            cbb_HanhKhach.Items.Add("Người lớn");
            cbb_HanhKhach.Items.Add("Trẻ em");
            cbb_HanhKhach.SelectedIndex = 0;
            lb_ErrorFrom.Visible = false;
            lb_ErrorTo.Visible = false;

        }
        void load()
        {
            cbb_From.DataSource = _locationServices.get_list();
            cbb_From.DisplayMember = "locationFly";

            cbb_To.DataSource = _locationServices.get_list();
            cbb_To.DisplayMember = "locationFly";

            cbb_LoaiVe.DataSource = _classServices.get_list();
            cbb_LoaiVe.DisplayMember = "displayName";
            txt_Discount.Visible = false;
            date_To.Visible = false;
            guna2HtmlLabel8.Visible = false;
        }
        bool check_place()
        {
            if (cbb_From.Text != cbb_To.Text)
            {
                return true;
            }
            return false;
        }
        bool check_date()
        {
            if (date_From.Value < date_To.Value)
            {
                return true;
            }
            return false;
        }
        bool check_dateFrom()
        {
            DateTime date = DateTime.Now;
            if (date_From.Value >= date)
            {
                return true;
            }
            return false;
        }
        private void btn_Discount_Click(object sender, EventArgs e)
        {
            txt_Discount.Visible = true;
            btn_discount.Visible = false;
        }

        private void FbuyTickket_Click(object sender, EventArgs e)
        {
            if (check_button)
            {
                if (check_place())
                {
                    if (check_dateFrom())
                    {
                        var search = _flightServices.get_list().Where(c => c.GoFrom == cbb_From.Text && c.GoTo == cbb_To.Text && c.DateFlight == date_From.Value);
                    }
                    else
                    {
                        MessageBox.Show("Ngày đi nhỏ hơn ngày hiện tại");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn lại điểm đi hoặc điểm đến");
                }
            }
            else
            {
                if (check_place())
                {
                    if (check_date())
                    {
                        if (check_dateFrom())
                        {
                            var search = _flightServices.get_list().Where(c => c.GoFrom == cbb_From.Text && c.GoTo == cbb_To.Text && c.DateFlight == date_From.Value && c.DateTo == date_To.Value);
                        }
                        else
                        {
                            MessageBox.Show("Ngày đi nhỏ hơn ngày hiện tại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngày đi chọn phải nhỏ hơn ngày đến");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn lại điểm đi hoặc điểm đến");
                }
            }
        }

        private void btn_oneWay_Click(object sender, EventArgs e)
        {
            check_button = true;
            btn_discount.Visible = true;
            txt_Discount.Visible = false;
            date_To.Visible = false;
            guna2HtmlLabel8.Visible = false;
            btn_OneWay.FillColor = Color.DarkCyan;
            btn_TwoWay.FillColor = Color.White;
        }

        private void btn_TwoWay_Click(object sender, EventArgs e)
        {
            check_button = false;
            btn_discount.Visible = true;
            txt_Discount.Visible = false;
            date_To.Visible = true;
            guna2HtmlLabel8.Visible = true;
            btn_TwoWay.FillColor = Color.DarkCyan;
            btn_OneWay.FillColor = Color.White;
        }

        private void cbb_From_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check_place())
            {
                lb_ErrorTo.Visible = false;
                lb_ErrorFrom.Visible = false;
            }
            else
            {
                lb_ErrorTo.Visible = true;
                lb_ErrorTo.Text = "Vui lòng thay đổi điểm đến khác!!!";
                lb_ErrorTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_ErrorTo.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void cbb_To_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check_place())
            {
                lb_ErrorTo.Visible = false;
                lb_ErrorFrom.Visible = false;
            }
            else
            {
                lb_ErrorFrom.Visible = true;
                lb_ErrorFrom.Text = "Vui lòng thay đổi điểm đến khác!!!";
                lb_ErrorFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_ErrorFrom.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void date_From_ValueChanged(object sender, EventArgs e)
        {
            if (check_dateFrom())
            {
                lb_dateFrom.Visible = false;
            }
            else
            {
                lb_dateFrom.Visible = true;
                lb_dateFrom.Text = "Vui lòng chọn ngày đi lớn hơn hoặc bằng ngày hiện tại!!!";
                lb_dateFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_dateFrom.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void date_To_ValueChanged(object sender, EventArgs e)
        {
            if (check_date())
            {
                lb_dateTo.Visible = false;
            }
            else
            {
                lb_dateTo.Visible = true;
                lb_dateTo.Text = "Vui lòng chọn ngày về lớn hơn ngày đi!!!";
                lb_dateTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_dateTo.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
