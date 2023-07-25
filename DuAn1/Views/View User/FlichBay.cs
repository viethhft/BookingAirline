﻿using _2_BUS.IService;
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
    public partial class FlichBay : Form
    {
        IFlightServices _flightServices;
        ILocationServices _locationServices;
        bool check_date = true;
        public FlichBay()
        {
            _locationServices = new LocationService();
            _flightServices = new FlightServices();
            InitializeComponent();
            load();
        }
        void load()
        {
            cbb_From.DataSource = _locationServices.get_list();
            cbb_From.DisplayMember = "locationFly";
            cbb_To.DataSource = _locationServices.get_list();
            cbb_To.DisplayMember = "locationFly";
            lb_ErrorFrom.Visible = false;
            lb_ErrorTo.Visible = false;
            lb_ErrorDate.Visible = false;
        }
        bool check()
        {
            if (cbb_From.Text==cbb_To.Text)
            {
                return false;
            }
            return true;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (check_date)
                {
                    try
                    {
                        var list_search = _flightServices.get_list().Where(c => c.GoFrom == cbb_From.Text && c.GoTo == cbb_To.Text && c.DateFlight >= date_nkh.Value).ToList().Take(7);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không có chuyến bay nào trùng với những thông tin bạn tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ngày bay bạn chọn không phù hợp yêu cầu!");
                }
            }
            else
            {
                MessageBox.Show("Điểm đến điểm đi chọn không phù hợp yêu cầu!");
            }
        }

        private void cbb_From_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check())
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
            if (check())
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

        private void date_nkh_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            if (date_nkh.Value<=date)
            {
                check_date = false;
                lb_ErrorDate.Visible = true;
                lb_ErrorDate.Text = "Vui lòng chọn ngày bay lớn hơn ngày hiện tại!!";
                lb_ErrorDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_ErrorDate.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                check_date = true;
                lb_ErrorDate.Visible = false;
            }
        }
    }
}
