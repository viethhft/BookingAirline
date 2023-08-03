using _1_DAL.Models;
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
    public partial class FAfterSeat : Form
    {
        FChonGheSmallSize _fsm;
        SeatFlightSer _ser;
        FlightServices _f;
        SeatDetailServices _sd;
        PlaneTypeServices _plane;
        CustomerServices _cus;
        TicketServices _ticketServices;
        ClassServices _classServices;
        long id;
        List<int> lst;
        List<string> lst_ma;
        long idmb;
        string macb;
        string _email = "";
        int _price = 0;
        public string Status;
        public FAfterSeat()
        {
            _classServices = new ClassServices();
            _ticketServices = new TicketServices();
            _cus = new CustomerServices();
            _fsm = new FChonGheSmallSize();
            _ser = new SeatFlightSer();
            _f = new();
            _sd = new SeatDetailServices();
            _plane = new PlaneTypeServices();
            InitializeComponent();
        }

        public FAfterSeat(string machuyenbay, List<string> maghe, string email,int price) : this()
        {
            lst = new List<int>();
            lst_ma = new List<string>();
            lst_ma = maghe;
            _email = email;
            _price = price;
            lb_CodeFlight.Text = machuyenbay;
            var fl = _f.get_list().Where(c => c.FlightCode == machuyenbay).FirstOrDefault();
            id = fl.Id;
            var cus = _cus.GetCustomers().Where(c => c.Email == email).FirstOrDefault();
            lb_name.Text = $"{cus.FirstName} {cus.MiddleName} {cus.LastName}";
            DateTime datetime = new DateTime(fl.DateTo.Value.Year, fl.DateTo.Value.Month, fl.DateTo.Value.Day);
            lb_date.Text = fl.DateFlight==fl.DateTo?fl.DateFlight.ToShortDateString() :fl.DateFlight.ToShortDateString()+" - "+datetime.ToShortDateString();
            lb_from.Text = fl.GoFrom;
            lb_tom.Text = fl.GoTom;
            lb_seat.Text = maghe[0];
            for (int i = 1; i < maghe.Count; i++)
            {
                lb_seat.Text += ", " + maghe[i];
            }
            lb_totalSeats.Text = maghe.Count.ToString();
            foreach (var item in maghe)
            {
                var seatfl = _sd.list().Where(c => c.PlaneTypeId == fl.PlaneTypeId && c.SeatCode == item).FirstOrDefault();
                if (seatfl != null)
                {
                    lst.Add(seatfl.Id);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FthanhToan f = new FthanhToan(_price);
            SeatFlight sf;
            if (MessageBox.Show("Xác nhận mua vé?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Hide();
                f.ShowDialog();
                this.Show();
                if (f.status == "Thanh toán")
                {
                    foreach (var item in lst_ma)
                    {
                        Ticket creatticket = new Ticket();
                        creatticket.CustomerId = _cus.GetCustomers().Where(c => c.Email == _email).FirstOrDefault().Id;
                        creatticket.FlightId = id;
                        creatticket.CreateDate = DateTime.Now;
                        creatticket.TwoWay = 1;
                        creatticket.TotalTicket = 1;
                        var seat_book = _sd.list().Where(c => c.PlaneTypeId == _f.get_list().Where(c => c.Id == id).FirstOrDefault().PlaneTypeId && c.SeatCode == item).FirstOrDefault();
                        int price = seat_book.ClassId == 1 ? 1000000 : 500000;
                        creatticket.TotalPrice = _f.get_list().Where(c => c.Id == id).FirstOrDefault().Price+price;
                        creatticket.SeatCode = item;
                        creatticket.NameTicket = _f.get_list().Where(c => c.Id == id).FirstOrDefault().FlightCode+"_"+item;
                        creatticket.Status = 1;
                        _ticketServices.add(creatticket);
                    }
                    foreach (var item in lst)
                    {
                        sf = new SeatFlight()
                        {
                            Flightid = id,
                            Seatid = item,
                            Status = 1
                        };
                        _ser.Create(sf);
                    }
                }
                Status = "True";
                this.Close();
            }
            else
            {
                MessageBox.Show("Mua vé thất bại");
            }
            
        }
    }
}
