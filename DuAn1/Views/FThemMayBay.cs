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

namespace GUI.Views
{
    public partial class FThemMayBay : Form
    {
        IPlaneTypeServices _planeTypeServices;
        public FThemMayBay()
        {
            _planeTypeServices = new PlaneTypeServices();
            InitializeComponent();
            load();
        }
        void load()
        {
            dgv_dataPlane.Rows.Clear();
            dgv_dataPlane.ColumnCount= 3;
            dgv_dataPlane.Columns[0].Name = "Mã máy bay";
            dgv_dataPlane.Columns[1].Name = "Tên máy bay";
            dgv_dataPlane.Columns[0].Name = "Tổng số ghế";
            foreach (var item in _planeTypeServices.get_list())
            {
                dgv_dataPlane.Rows.Add(item.PlaneCode,item.DisplayName,item.TotalSeat);
            }
        }
    }
}
