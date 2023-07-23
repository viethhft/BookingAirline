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

namespace DuAn1.Views
{
    public partial class FQuanLyChuyenBay : Form
    {
        IPlaneTypeServices _plantype;
        ILocationServices _location;
        IFlightServices _flight;
        string plancode = "";
        string locacode = "";
        string codefrom = "";
        string codeto = "";
        string ngaydi = "";
        string ngayve = "";
        public FQuanLyChuyenBay()
        {
            _flight = new FlightServices();
            _location = new LocationService();
            _plantype = new PlantypeServices();
            InitializeComponent();
            load();
        }
        void load()
        {
            cmb_PlaneType.DataSource = _plantype.get_list();
            cmb_PlaneType.DisplayMember = "displayName";
            cmb_PlaneType.ValueMember = "planeCode";

            cmb_Location.DataSource = _location.get_list();
            cmb_Location.DisplayMember = "displayName";
            cmb_Location.ValueMember = "locaCode";

            cmb_From.DataSource = _location.get_list();
            cmb_From.DisplayMember = "displayName";
            cmb_From.ValueMember = "locaCode";

            cmb_To.DataSource = _location.get_list();
            cmb_To.DisplayMember = "displayName";
            cmb_To.ValueMember = "locaCode";

            dgv_chuyenbay.DataSource = _flight.get_list();

            plancode = cmb_PlaneType.SelectedValue.ToString();
            locacode = cmb_Location.SelectedValue.ToString();
            codefrom = cmb_From.SelectedValue.ToString();
            codeto = cmb_To.SelectedValue.ToString();
            ngaydi = DateFrom.Value.ToString("dd-MM-yyyy");
            ngayve = dateTo.Value.ToString("dd-MM-yyyy");
            ReverseCodePlight(plancode, locacode, codefrom, codeto, ngaydi, ngayve);
        }
        void ReverseCodePlight(string planeCode, string locaCode, string codeFrom, string codeTo, string ngaydi, string ngayve)
        {
            //code plight = codeplane+codeloca+codeFrom+codeTo+NgayDi+ngayVe
            txb_codeflight.Text = planeCode + "_" + locaCode + "_" + codeFrom + "_" + codeTo + "_" + ngaydi + "_" + ngayve;
        }

        private void cmb_PlaneType_SelectedValueChanged(object sender, EventArgs e)
        {
            plancode = cmb_PlaneType.SelectedValue.ToString();
            ReverseCodePlight(plancode, locacode, codefrom, codeto, ngaydi, ngayve);
        }

        private void cmb_Location_SelectedValueChanged(object sender, EventArgs e)
        {
            locacode = cmb_Location.SelectedValue.ToString();
            ReverseCodePlight(plancode, locacode, codefrom, codeto, ngaydi, ngayve);
        }

        private void cmb_From_SelectedValueChanged(object sender, EventArgs e)
        {
             codefrom = cmb_From.SelectedValue.ToString();
            ReverseCodePlight(plancode, locacode, codefrom, codeto, ngaydi, ngayve);
        }

        private void cmb_To_SelectedValueChanged(object sender, EventArgs e)
        {
             codeto = cmb_To.SelectedValue.ToString();
            ReverseCodePlight(plancode, locacode, codefrom, codeto, ngaydi, ngayve);
        }

        private void DateFrom_ValueChanged(object sender, EventArgs e)
        {
             ngaydi = DateFrom.Value.ToString("dd-MM-yyyy");
            ReverseCodePlight(plancode, locacode, codefrom, codeto, ngaydi, ngayve);
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
             ngayve = dateTo.Value.ToString("dd-MM-yyyy");
            ReverseCodePlight(plancode, locacode, codefrom, codeto, ngaydi, ngayve);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

       
    }
}
