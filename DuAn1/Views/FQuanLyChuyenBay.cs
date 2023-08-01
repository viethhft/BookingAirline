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
        bool checkDuplicate = true;
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
            _plantype = new PlaneTypeServices();
            InitializeComponent();
            cmb_status.Items.Add("Delay");
            cmb_status.Items.Add("Đúng giờ");
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
            dgv_chuyenbay.ColumnCount = 12;
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
            dgv_chuyenbay.Columns[9].Name = "Giờ khởi hành";
            dgv_chuyenbay.Columns[10].Name = "Giờ kết thúc";
            dgv_chuyenbay.Columns[11].Name = "Trạng thái";

            foreach (var item in _flight.get_list())
            {
                string namePlane = _plantype.get_list().Where(c => c.Id == item.PlaneTypeId).FirstOrDefault().DisplayName;
                string nameLoca = _location.get_list().Where(c => c.Id == item.LocationId).FirstOrDefault().LocationFly;
                dgv_chuyenbay.Rows.Add(namePlane, nameLoca, item.FlightCode, item.GoTo, item.GoFrom, item.DateFlight, item.DateTo, item.Price, item.Id, item.TimeStart, item.TimeEnd, item.Status);
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
                cmb_status.SelectedIndex = Convert.ToInt32(dgv_chuyenbay.Rows[0].Cells[11].Value.ToString());
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
        void checkName()
        {
            checkDuplicate = true;
            foreach (var item in _flight.get_list())
            {
                if (item.FlightCode == txb_codeflight.Text)
                {
                    checkDuplicate = false;
                    break;
                }
            }
        }
        bool checklocation()
        {
            if (cmb_From.Text == cmb_To.Text)
            {
                return false;
            }
            return true;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            check();
            checkName();
            if (checkDuplicate)
            {
                if (checklocation())
                {
                    if (checkInfo)
                    {
                        Flight flight = new Flight();
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
                        flight.GoTom = cmb_To.Text;
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

                        int hours_st = Convert.ToInt32(timeStart_hour.Value.ToString());
                        int minute_st = Convert.ToInt32(timeStart_minute.Value.ToString());
                       
                        int hours_e = Convert.ToInt32(timeEnd_hour.Value);
                        int minute_e = Convert.ToInt32(timeEnd_minute.Value);
                        TimeSpan timeend = new TimeSpan(hours_e, minute_e, 0);
                        TimeSpan timestart = new TimeSpan(hours_st, minute_st, 0);
                        flight.TimeStart = timestart;
                        flight.TimeEnd = timeend;
                        flight.Status = cmb_status.SelectedIndex;//trạng thái của chuyến bay
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
                    MessageBox.Show("Hãy chọn điểm đi và điểm đến khác nhau!");
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
            if (checklocation())
            {
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
                    flight.GoTom = cmb_To.Text;
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
                    int hours_st = Convert.ToInt32(timeStart_hour.Value);
                    int minute_st = Convert.ToInt32(timeStart_hour.Value);
                    int hours_e = Convert.ToInt32(timeEnd_hour.Value);
                    int minute_e = Convert.ToInt32(timeEnd_hour.Value);
                    TimeSpan timestart = new TimeSpan(hours_st, minute_st, 0);
                    TimeSpan timeend = new TimeSpan(hours_e, minute_e, 0);
                    flight.TimeStart = timestart;
                    flight.TimeEnd = timeend;
                    flight.Status = cmb_status.SelectedIndex; // trạng thái của chuyến bay
                    MessageBox.Show(_flight.update(flight));
                    load();
                }
                else
                {
                    MessageBox.Show("Hãy nhập đúng giá!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn điểm đi và điểm đến khác nhau!");
            }
        }

        private void txb_Search_TextChanged(object sender, EventArgs e)
        {
            if (txb_Search.Text != "")
            {
                dgv_chuyenbay.Rows.Clear();
                foreach (var item in _flight.get_list().Where(c => c.GoFrom.Contains(txb_Search.Text) || c.GoTom.Contains(txb_Search.Text)))
                {
                    string namePlane = _plantype.get_list().Where(c => c.Id == item.PlaneTypeId).FirstOrDefault().DisplayName;
                    string nameLoca = _location.get_list().Where(c => c.Id == item.LocationId).FirstOrDefault().LocationFly;
                    dgv_chuyenbay.Rows.Add(namePlane, nameLoca, item.FlightCode, item.GoTo, item.GoFrom, item.DateFlight, item.DateTo, item.Price, item.Id, item.Status);
                }
            }
            else
            {
                dgv_chuyenbay.Rows.Clear();
                foreach (var item in _flight.get_list())
                {
                    string namePlane = _plantype.get_list().Where(c => c.Id == item.PlaneTypeId).FirstOrDefault().DisplayName;
                    string nameLoca = _location.get_list().Where(c => c.Id == item.LocationId).FirstOrDefault().LocationFly;
                    dgv_chuyenbay.Rows.Add(namePlane, nameLoca, item.FlightCode, item.GoTo, item.GoFrom, item.DateFlight, item.DateTo, item.Price, item.Id, item.TimeStart, item.TimeEnd, item.Status);
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
            cmb_status.SelectedIndex = Convert.ToInt32(dgv_chuyenbay.CurrentRow.Cells[11].Value.ToString());
        }
    }
}
