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
        long id;
        List<int> lst;
        long idmb;
        string macb;
        string _email = "";

        public FAfterSeat()
        {
            _cus=new CustomerServices();
            _fsm = new FChonGheSmallSize();
            _ser = new SeatFlightSer();
            _f = new();
            _sd = new SeatDetailServices();
            _plane = new PlaneTypeServices();
            InitializeComponent();
        }

        public FAfterSeat(string machuyenbay, List<string> maghe,string email) : this()
        {
            _email = email;
            lb_CodeFlight.Text = machuyenbay;
            var fl=_f.get_list().Where(c=>c.FlightCode== machuyenbay).FirstOrDefault();
            var cus = _cus.GetCustomers().Where(c => c.Email == email).FirstOrDefault();
            lb_name.Text = $"{cus.FirstName} {cus.MiddleName} {cus.LastName}";
            lb_date.Text = fl.DateFlight.ToShortDateString();
            lb_from.Text = fl.GoFrom;
            lb_tom.Text = fl.GoTom;
            lb_seat.Text = maghe[0];
            for (int i = 1; i < maghe.Count; i++)
            {
                lb_seat.Text += ", "+maghe[i];
            }
            lb_totalSeats.Text = maghe.Count.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FthanhToan f = new FthanhToan();
            SeatFlight sf;
            for (int i = 0; i < lst.Count; i++)
            {
                sf = new SeatFlight()
                {
                    Flightid = id,
                    Seatid = lst[i],
                    Status = 1
                };
                _ser.Create(sf);
            }
            if (MessageBox.Show("Thanh toán nhé", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                f.ShowDialog();
                this.Hide();
            }

        }
    }
}
