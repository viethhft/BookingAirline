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
    public partial class FlichBay : Form
    {
        IFlightServices _flightServices;
        ILocationServices _locationServices;

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
            cbb_From.DisplayMember = "displayName";
            cbb_To.DataSource = _locationServices.get_list();
            cbb_To.DisplayMember = "displayName";
            lb_ErrorFrom.Visible = false;
            lb_ErrorTo.Visible = false;
        }
        bool check()
        {
            if (cbb_From.Text==cbb_To.Text)
            {
                return true;
            }
            return false;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                var list_search = _flightServices.get_list().Where(c => c.GoFrom == cbb_From.Text && c.GoTo == cbb_To.Text && c.DateFlight == date_nkh.Value).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Không có chuyến bay nào trùng với những thông tin bạn tìm kiếm","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void cbb_From_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check())
            {
                lb_ErrorTo.Visible = true;
                lb_ErrorTo.Text = "Vui lòng thay đổi điểm đến khác!!!";
                lb_ErrorTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_ErrorTo.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lb_ErrorTo.Visible = false;
            }
        }

        private void cbb_To_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check())
            {
                lb_ErrorFrom.Visible = true;
                lb_ErrorFrom.Text = "Vui lòng thay đổi điểm đến khác!!!";
                lb_ErrorFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
                lb_ErrorFrom.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lb_ErrorFrom.Visible = false;
            }
        }
    }
}
