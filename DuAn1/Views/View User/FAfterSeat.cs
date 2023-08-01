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
        long id;
        List<int> lst;
        long idmb;
        string macb;

        public FAfterSeat()
        {
            _fsm = new FChonGheSmallSize();
            _ser = new SeatFlightSer();
            _f = new();
            _sd = new SeatDetailServices();
            _plane = new PlaneTypeServices();
            InitializeComponent();
        }

        public FAfterSeat(string machuyenbay, List<string> maghe) : this()
        {
            //macb = machuyenbay;
            //id = _f.get_list().FirstOrDefault(c => c.FlightCode == machuyenbay).Id;
            //foreach (var i in _f.get_list().Where(c => c.FlightCode == machuyenbay))
            //{
            //    idmb = i.PlaneTypeId;
            //}
            //lst = new List<int>();
            //for (int i = 0; i < maghe.Count; i++)
            //{
            //    RichTextBox rich = new();
            //    flowLayoutPanel1.Controls.Add(rich);
            //    rich.Width = 150;
            //    rich.Height = 100;
            //    rich.ReadOnly = true;
            //    rich.BackColor = Color.FromArgb(227, 145, 57);
            //    rich.Text = $"Mã chuyến bay của bạn là {machuyenbay} và ghế bạn đặt là {maghe[i]}";
            //    foreach (var item in _sd.list().Where(c => c.SeatCode == maghe[i] && c.PlaneTypeId == idmb))
            //    {
            //        lst.Add(item.Id);
            //    }

            //}
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
