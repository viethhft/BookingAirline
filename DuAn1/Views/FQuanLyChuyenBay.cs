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
        public FQuanLyChuyenBay()
        {
            _flight=new FlightServices();
            _location= new LocationService();
            _plantype = new PlantypeServices();
            InitializeComponent();
            load();
        }
        void load()
        {
            cmb_PlaneType.DataSource = _plantype.get_list();
            cmb_PlaneType.DisplayMember= "displayName";
            cmb_PlaneType.ValueMember = "planeCode";

            cmb_Location.DataSource = _location.get_list();
            cmb_Location.DisplayMember= "displayName";
            cmb_Location.ValueMember = "locaCode";

            cmb_From.DataSource = _location.get_list();
            cmb_From.DisplayMember = "displayName";
            cmb_From.ValueMember = "locaCode";

            cmb_To.DataSource = _location.get_list();
            cmb_To.DisplayMember = "displayName";
            cmb_To.ValueMember = "locaCode";

            dgv_chuyenbay.DataSource = _flight.get_list();
        }
        void ReverseCodePlight()
        {
            //code plight = codeplane+codeloca+codeFrom+codeTo+NgayDi+ngayVe
            
        }
    }
}
