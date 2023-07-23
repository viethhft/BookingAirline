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
        public FQuanLyChuyenBay()
        {
            _location= new LocationService();
            _plantype = new PlantypeServices();
            InitializeComponent();
            load();
        }
        void load()
        {
            cmb_PlaneType.DataSource = _plantype.get_list();
            cmb_PlaneType.DisplayMember= "displayName";
            cmb_PlaneType.ValueMember = "id";
            cmb_Location.DataSource = _location.get_list();
            cmb_Location.DisplayMember= "displayName";
        }
    }
}
