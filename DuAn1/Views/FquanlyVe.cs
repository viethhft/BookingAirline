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
    public partial class FquanlyVe : Form
    {
        ITicketServices _ticketServices;
        IClassServices _classServices;
        IFlightServices _flightServices;
        ILocationServices _locationServices;
        ICustomerServices _customerServices;
        ISeatDetailServices _seatDetailServices;
        IPlaneTypeServices _planeTypeServices;
        public FquanlyVe()
        {
            _planeTypeServices=new PlantypeServices();
            _seatDetailServices=new SeatDetailServices();
            _customerServices=new CustomerServices();
            _classServices = new ClassServices();
            _ticketServices = new TicketServices();
            _flightServices = new FlightServices();
            _locationServices = new LocationService();
            InitializeComponent();
            


            load();
        }
        void load()
        {
            //Loại vé + hạng vé
            cbb_LoaiVe.Items.Add("Một chiều + Phổ Thông");
            cbb_LoaiVe.Items.Add("Một chiều + Thương Gia");
            cbb_LoaiVe.Items.Add("Khứ hồi + Phổ Thông");
            cbb_LoaiVe.Items.Add("Khứ hồi + Thương Gia");
            cbb_LoaiVe.SelectedIndex = 0;

            cbb_DiemDen.DataSource = _locationServices.get_list();
            cbb_DiemDen.DisplayMember = "displayName";
            cbb_DiemDen.ValueMember = "id";

            cbb_DiemDi.DataSource = _locationServices.get_list();
            cbb_DiemDi.DisplayMember = "displayName";
            cbb_DiemDi.ValueMember = "id";

            dgv_data.Rows.Clear();
            dgv_data.ColumnCount = 11;
            dgv_data.Columns[0].Name = "Tên vé";
            dgv_data.Columns[1].Name = "Người mua";
            dgv_data.Columns[2].Name = "Mã chuyến bay";
            dgv_data.Columns[3].Name = "Ngày tạo vé";
            dgv_data.Columns[4].Name = "Loại vé";
            dgv_data.Columns[5].Name = "Ngày đi";
            dgv_data.Columns[6].Name = "Ngày về";
            dgv_data.Columns[7].Name = "Điểm đi";
            dgv_data.Columns[8].Name = "Điểm đến";
            dgv_data.Columns[9].Name = "Giá vé";
            dgv_data.Columns[10].Name = "Mã ghế";
            foreach (var item in _ticketServices.list_Ticket())
            {
                var cus=_customerServices.GetCustomers().Where(c=>c.Id==item.CustomerId).FirstOrDefault();

                var flight = _flightServices.get_list().Where(c => c.Id == item.FlightId).FirstOrDefault();

                var plane = _planeTypeServices.get_list().Where(c => c.Id==flight.PlaneTypeId).FirstOrDefault();

                int id;
                int tienloai = 0;
                if (cbb_LoaiVe.SelectedIndex==0)
                {
                    id = 2;
                    tienloai = 200000;
                }
                else if (cbb_LoaiVe.SelectedIndex == 1)
                {
                    id = 2;
                    tienloai = 400000;
                }
                else if (cbb_LoaiVe.SelectedIndex == 2)
                {
                    id = 1;
                    tienloai = 600000;
                }
                else
                {
                    id = 1;
                    tienloai = 1200000;
                }

                var cla = _classServices.get_list().Where(c => c.Id == id).FirstOrDefault();


                var seat =_seatDetailServices.list().Where(c=>c.ClassId==id&&c.PlaneTypeId==plane.Id&& c.SeatCode=="").FirstOrDefault();
                int tong = item.TotalPrice + flight.Price + cla.Price + tienloai;
                dgv_data.Rows.Add(item.NameTicket,cus.Email, flight.FlightCode, item.CreateDate,cbb_LoaiVe.SelectedIndex, flight.DateFlight, flight.DateTo, flight.GoFrom, flight.GoTo,tong, item.SeatCode);
            }
            if (dgv_data.RowCount>0)
            {
                txt_TenVe.Text = dgv_data.Rows[0].Cells[0].Value.ToString();
                txt_MaGhe.Text = dgv_data.Rows[0].Cells[10].Value.ToString();
                txt_GiaVe.Text = dgv_data.Rows[0].Cells[9].Value.ToString();
                date_NgayTao.Value = (DateTime)(dgv_data.Rows[0].Cells[3].Value);
                date_NgayDi.Value = (DateTime)(dgv_data.Rows[0].Cells[5].Value);
                date_NgayVe.Value = (DateTime)(dgv_data.Rows[0].Cells[6].Value);
                cbb_DiemDen.Text= dgv_data.Rows[0].Cells[8].Value.ToString();
                cbb_DiemDi.Text= dgv_data.Rows[0].Cells[7].Value.ToString();
            }
        }

        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TenVe.Text = dgv_data.CurrentRow.Cells[0].Value.ToString();
            txt_MaGhe.Text = dgv_data.CurrentRow.Cells[10].Value.ToString();
            txt_GiaVe.Text = dgv_data.CurrentRow.Cells[9].Value.ToString();
            date_NgayTao.Value = (DateTime)(dgv_data.CurrentRow.Cells[3].Value);
            date_NgayDi.Value = (DateTime)(dgv_data.CurrentRow.Cells[5].Value);
            date_NgayVe.Value = (DateTime)(dgv_data.CurrentRow.Cells[6].Value);
            cbb_DiemDen.Text = dgv_data.CurrentRow.Cells[8].Value.ToString();
            cbb_DiemDi.Text = dgv_data.CurrentRow.Cells[7].Value.ToString();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text!="")
            {
                dgv_data.Rows.Clear();
                foreach (var item in _ticketServices.list_Ticket())
                {
                    
                        var cus = _customerServices.GetCustomers().Where(c => c.Id == item.CustomerId).FirstOrDefault();

                        var flight = _flightServices.get_list().Where(c => c.Id == item.FlightId).FirstOrDefault();

                        var plane = _planeTypeServices.get_list().Where(c => c.Id == flight.PlaneTypeId).FirstOrDefault();

                        int id;
                        if (cbb_LoaiVe.SelectedIndex == 0 || cbb_LoaiVe.SelectedIndex == 1)
                        {
                            id = 2;
                        }
                        else
                        {
                            id = 1;
                        }
                        var seat = _seatDetailServices.list().Where(c => c.ClassId == id && c.PlaneTypeId == plane.Id && c.SeatCode == "").FirstOrDefault();
                        if (flight.GoFrom.Contains(txt_Search.Text)||flight.GoTo.Contains(txt_Search.Text))
                        {
                            dgv_data.Rows.Add(item.NameTicket, cus.Email, flight.FlightCode, item.CreateDate, cbb_LoaiVe.SelectedIndex, flight.DateFlight, flight.DateTo, flight.GoFrom, flight.GoTo, item.TotalPrice, item.SeatCode);
                        }
                }
            }
            else
            {
                load();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }
    }
}
