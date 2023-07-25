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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1.Views
{
    public partial class FQuanLyChuyenBay : Form
    {
        bool checkInfo = true;
        bool checkDuplicate = true;
        IPlaneTypeServices _plantype;
        ILocationServices _location;
        IFlightServices _flight;
        string plancode = "";
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
        void check()
        {
            if (nbr_Price.Value < 500000)
            {
                checkInfo = false;
            }
            else
            {
                checkInfo = true;
            }
        }
        void load()
        {
            cmb_PlaneType.DataSource = _plantype.get_list();
            cmb_PlaneType.DisplayMember = "displayName";
            cmb_PlaneType.ValueMember = "planeCode";

            cmb_From.DataSource = _location.get_list();
            cmb_From.DisplayMember = "locationFly";
            cmb_From.ValueMember = "airportCode";

            cmb_To.DataSource = _location.get_list();
            cmb_To.DisplayMember = "locationFly";
            cmb_To.ValueMember = "airportCode";

            loaddata();

            plancode = cmb_PlaneType.SelectedValue.ToString();
            codefrom = cmb_From.SelectedValue.ToString();
            codeto = cmb_To.SelectedValue.ToString();
            ngaydi = DateFrom.Value.ToString("dd-MM-yyyy");
            ngayve = dateTo.Value.ToString("dd-MM-yyyy");
            ReverseCodeFlight(plancode, codefrom, codeto, ngaydi, ngayve);
        }
        void loaddata()
        {
            dgv_chuyenbay.Rows.Clear();
            dgv_chuyenbay.ColumnCount = 9;
            dgv_chuyenbay.Columns[0].Name = "Tên máy bay";
            dgv_chuyenbay.Columns[1].Name = "Địa điểm bay";
            dgv_chuyenbay.Columns[2].Name = "Mã chuyến bay";
            dgv_chuyenbay.Columns[3].Name = "Điểm đến";
            dgv_chuyenbay.Columns[4].Name = "Điểm đi";
            dgv_chuyenbay.Columns[5].Name = "Thời gian đi";
            dgv_chuyenbay.Columns[6].Name = "Thời gian về";
            dgv_chuyenbay.Columns[7].Name = "Giá";
            dgv_chuyenbay.Columns[8].Name = "id";
            dgv_chuyenbay.Columns[8].Visible = false;
            foreach (var item in _flight.get_list())
            {
                string namePlane = _plantype.get_list().Where(c => c.Id == item.PlaneTypeId).FirstOrDefault().DisplayName;
                string nameLoca = _location.get_list().Where(c => c.Id == item.LocationId).FirstOrDefault().LocationFly;
                dgv_chuyenbay.Rows.Add(namePlane, nameLoca, item.FlightCode, item.GoTo, item.GoFrom, item.DateFlight, item.DateTo, item.Price, item.Id);
            }
            if (dgv_chuyenbay.RowCount > 0)
            {
                txb_codeflight.Text = dgv_chuyenbay.Rows[0].Cells[2].Value.ToString();
                nbr_Price.Value = Convert.ToInt32(dgv_chuyenbay.Rows[0].Cells[7].Value.ToString());
                cmb_PlaneType.Text = dgv_chuyenbay.Rows[0].Cells[0].Value.ToString();
                cmb_To.Text = dgv_chuyenbay.Rows[0].Cells[3].Value.ToString();
                cmb_From.Text = dgv_chuyenbay.Rows[0].Cells[4].Value.ToString();
                DateFrom.Value = (DateTime)(dgv_chuyenbay.Rows[0].Cells[5].Value);
                dateTo.Value = (DateTime)(dgv_chuyenbay.Rows[0].Cells[6].Value);
            }
        }
        void ReverseCodeFlight(string planeCode, string codeFrom, string codeTo, string ngaydi, string ngayve)
        {
            //code plight = codeplane+codeloca+codeFrom+codeTo+NgayDi+ngayVe
            txb_codeflight.Text = planeCode + "_" + codeFrom + "_" + codeTo + "_" + ngaydi + "_" + ngayve;
        }

        private void cmb_PlaneType_SelectedValueChanged(object sender, EventArgs e)
        {
            plancode = cmb_PlaneType.SelectedValue.ToString();
            ReverseCodeFlight(plancode, codefrom, codeto, ngaydi, ngayve);
        }

        private void cmb_From_SelectedValueChanged(object sender, EventArgs e)
        {
            codefrom = cmb_From.SelectedValue.ToString();
            ReverseCodeFlight(plancode, codefrom, codeto, ngaydi, ngayve);
        }

        private void cmb_To_SelectedValueChanged(object sender, EventArgs e)
        {
            codeto = cmb_To.SelectedValue.ToString();
            ReverseCodeFlight(plancode, codefrom, codeto, ngaydi, ngayve);
        }

        private void DateFrom_ValueChanged(object sender, EventArgs e)
        {
            ngaydi = DateFrom.Value.ToString("dd-MM-yyyy");
            ReverseCodeFlight(plancode, codefrom, codeto, ngaydi, ngayve);
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            ngayve = dateTo.Value.ToString("dd-MM-yyyy");
            ReverseCodeFlight(plancode, codefrom, codeto, ngaydi, ngayve);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            check();
            foreach (var item in _flight.get_list())
            {
                if (item.FlightCode == txb_codeflight.Text)
                {
                    checkDuplicate = false;
                    break;
                }
            }
            if (checkDuplicate)
            {
                if (checkInfo)
                {
                    Flight flight = new Flight();
                    flight.FlightCode = txb_codeflight.Text;
                    foreach (var item in _plantype.get_list())
                    {
                        if (item.DisplayName == cmb_PlaneType.Text)
                        {
                            flight.PlaneTypeId = item.Id;
                            break;
                        }
                    }
                    flight.GoFrom = cmb_From.Text;
                    flight.GoTo = cmb_To.Text;
                    foreach (var item in _location.get_list())
                    {
                        if (item.LocationFly == cmb_From.Text)
                        {
                            flight.LocationId = item.Id;
                            break;
                        }
                    }
                    flight.DateFlight = DateFrom.Value;
                    flight.DateTo = dateTo.Value;
                    flight.Price = Convert.ToInt32(nbr_Price.Value);

                    MessageBox.Show(_flight.create(flight));
                    load();
                }
                else
                {
                    MessageBox.Show("Hãy nhập đúng giá!");
                }
            }
            else
            {
                MessageBox.Show("Mã chuyến bay đã có hãy thử đổi ngày bay hoặc máy bay khác!");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            check();
            if (checkInfo)
            {
                Flight flight = _flight.get_list().Where(c => c.Id == Convert.ToInt32(dgv_chuyenbay.CurrentRow.Cells[8].Value.ToString())).FirstOrDefault();
                foreach (var item in _plantype.get_list())
                {
                    if (item.DisplayName == cmb_PlaneType.Text)
                    {
                        flight.PlaneTypeId = item.Id;
                        break;
                    }
                }
                flight.FlightCode = txb_codeflight.Text;
                flight.GoFrom = cmb_From.Text;
                flight.GoTo = cmb_To.Text;
                foreach (var item in _location.get_list())
                {
                    if (item.LocationFly == cmb_From.Text)
                    {
                        flight.LocationId = item.Id;
                        break;
                    }
                }
                flight.DateFlight = DateFrom.Value;
                flight.DateTo = dateTo.Value;
                flight.Price = Convert.ToInt32(nbr_Price.Value);
                int hours = Convert.ToInt32(guna2NumericUpDown1.Value);
                TimeSpan time = new TimeSpan(hours, 0, 0);
                MessageBox.Show(time.ToString());
                load();
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng giá!");
            }
        }

    private void txb_Search_TextChanged(object sender, EventArgs e)
    {
        if (txb_Search.Text != "")
        {
            dgv_chuyenbay.Rows.Clear();
            foreach (var item in _flight.get_list().Where(c => c.GoFrom.Contains(txb_Search.Text) || c.GoTo.Contains(txb_Search.Text)))
            {
                string namePlane = _plantype.get_list().Where(c => c.Id == item.PlaneTypeId).FirstOrDefault().DisplayName;
                string nameLoca = _location.get_list().Where(c => c.Id == item.LocationId).FirstOrDefault().LocationFly;
                dgv_chuyenbay.Rows.Add(namePlane, nameLoca, item.FlightCode, item.GoTo, item.GoFrom, item.DateFlight, item.DateTo, item.Price, item.Id);
            }
        }
        else
        {
            dgv_chuyenbay.Rows.Clear();
            foreach (var item in _flight.get_list())
            {
                string namePlane = _plantype.get_list().Where(c => c.Id == item.PlaneTypeId).FirstOrDefault().DisplayName;
                string nameLoca = _location.get_list().Where(c => c.Id == item.LocationId).FirstOrDefault().LocationFly;
                dgv_chuyenbay.Rows.Add(namePlane, nameLoca, item.FlightCode, item.GoTo, item.GoFrom, item.DateFlight, item.DateTo, item.Price, item.Id);
            }
        }
    }

    private void dgv_chuyenbay_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        txb_codeflight.Text = dgv_chuyenbay.CurrentRow.Cells[2].Value.ToString();
        nbr_Price.Value = Convert.ToInt32(dgv_chuyenbay.CurrentRow.Cells[7].Value.ToString());
        cmb_PlaneType.Text = dgv_chuyenbay.CurrentRow.Cells[0].Value.ToString();
        cmb_To.Text = dgv_chuyenbay.CurrentRow.Cells[3].Value.ToString();
        cmb_From.Text = dgv_chuyenbay.CurrentRow.Cells[4].Value.ToString();
        DateFrom.Value = (DateTime)(dgv_chuyenbay.CurrentRow.Cells[5].Value);
        dateTo.Value = (DateTime)(dgv_chuyenbay.CurrentRow.Cells[6].Value);
    }
}
}
