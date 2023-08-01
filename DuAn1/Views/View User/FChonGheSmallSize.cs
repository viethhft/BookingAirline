using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Service;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views.View_User
{
    public partial class FChonGheSmallSize : Form
    {
        IFlightServices _flightServices;
        IPlaneTypeServices _planeTypeServices;
        ISeatDetailServices _seatDetailServices;
        IClassServices _classServices;
        SeatFlightSer _sfServices;
        string _code = "";
        string _loaighe = "";
        int amount = 0;
        int price = 0;
        int priceFlight = 0;
        int priceClass = 0;
        long _macb;
        List<int> _lstGhe = new();
        List<string> _listcode = new List<string>();
        List<Guna2ImageCheckBox> _lstCb = new();

        public FChonGheSmallSize()
        {
            _classServices = new ClassServices();
            _flightServices = new FlightServices();
            _planeTypeServices = new PlaneTypeServices();
            _seatDetailServices = new SeatDetailServices();
            _sfServices = new();
            InitializeComponent();
            btn_pay.Enabled = false;
            lb_value.Visible = true;
        }
        public FChonGheSmallSize(string code, string loaighe) : this()
        {
            _loaighe = loaighe;
            _code = code;
            var flight = _flightServices.get_list().Where(c => c.FlightCode == code).FirstOrDefault();
            var plane = _planeTypeServices.get_list().Where(c => c.Id == flight.PlaneTypeId).FirstOrDefault();
            var seatdetail = _seatDetailServices.list().Where(c => c.PlaneTypeId == plane.Id);
            int so = 1;
            int tt = 0;
            Point locaChair = new Point(600, 10);
            Point locaName = new Point(586, 16);
            Point locaSTT = new Point(550, 88);
            string[] hang = { "A", "B", "C", "D" };
            int dem = 0;
            foreach (var item in seatdetail)
            {
                if (tt == 4)
                {
                    locaChair.X -= 75;
                    locaName.X -= 75;
                    locaSTT.X -= 75;
                    locaChair.Y = 10;
                    locaName.Y = 16;
                    locaSTT.Y = 88;
                    tt = 0;
                    so++;
                }
                if (tt >= 0 && tt < 4)
                {
                    Guna2ImageCheckBox chair = new Guna2ImageCheckBox();
                    Image image = Image.FromFile(@"..//..//..//Resources//chair.png");
                    chair.Image = image;
                    chair.Size = new Size(34, 30);
                    chair.Location = locaChair;
                    chair.Name = item.Id.ToString();
                    var fl = _flightServices.get_list().Where(c => c.FlightCode == code).FirstOrDefault();
                    var check = _sfServices.Get().Where(c => (int)c.Flightid == fl.Id && c.Seatid == item.Id).FirstOrDefault();
                    if (check.Status == 1)
                    {
                        chair.Enabled = true;
                    }
                    else
                    {
                        chair.Enabled = false;
                    }
                    //chair.Enabled = true;
                    ////}
                    ////else
                    ////{
                    ////    chair.Enabled = false;
                    ////}
                    chair.CheckedChanged += Chair_CheckedChanged;
                    if (dem < 20)
                    {
                        if (loaighe == "TG")
                        {
                            chair.Enabled = false;
                        }
                        chair.BackColor = Color.DarkCyan;
                    }
                    else
                    {
                        if (loaighe == "PT")
                        {
                            chair.Enabled = false;
                        }
                        chair.BackColor = Color.Goldenrod;
                    }
                    Label lb = new Label();
                    lb.Text = $"{so}{hang[tt]}";
                    lb.Location = locaName;
                    panel1.Controls.Add(chair);
                    panel1.Controls.Add(lb);
                    locaChair.Y += 36;
                    locaName.Y += 36;
                    tt++;
                    if (tt == 2)
                    {
                        Label lb_tt = new Label();
                        lb_tt.Text = $"{so}";
                        lb_tt.Location = locaSTT;
                        panel1.Controls.Add(lb_tt);
                        locaChair.Y += 36;
                        locaName.Y += 36;
                        panel1.Controls.Add(lb_tt);
                    }
                }
                dem++;
            }
        }

        //private void ChangeCB(List<Guna2ImageCheckBox> lstCb)
        //{
        //    long idcb = _flightServices.get_list().FirstOrDefault(c => c.FlightCode == _code).Id;
        //    List<int> idseat = new List<int>();
        //    for (int i = 0; i < lstCb.Count; i++)
        //    {
        //        foreach (var j in _seatDetailServices.list().Where(c => c.SeatCode == lstCb[i].Name))
        //        {
        //            idseat.Add(j.Id);
        //        }
        //        foreach (var item in _sfServices.Get())
        //        {
        //            if (item.Flightid == idcb)
        //            {
        //                for (int a = 0; a < idseat.Count; a++)
        //                {
        //                    if (item.Seatid == idseat[i])
        //                    {
        //                        lstCb[i].Enabled = false;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
        private void Chair_CheckedChanged(object? sender, EventArgs e)
        {
            Guna2ImageCheckBox a = (Guna2ImageCheckBox)(sender);
            if (_loaighe == "PT")
            {
                priceClass = _classServices.get_list().Where(c => c.Id == 2).FirstOrDefault().Price;
            }
            else
            {
                priceClass = _classServices.get_list().Where(c => c.Id == 1).FirstOrDefault().Price;
            }
            if (a.Checked)
            {
                _listcode.Add(a.Name);
                amount++;
                price += priceClass;
            }
            else
            {
                _listcode.Remove(a.Name);
                amount--;
                price -= priceClass;
            }
            lb_amount.Text = amount.ToString();
            lb_price.Text = price.ToString();
        }

        public FChonGheSmallSize(string code) : this()
        {
            var flight = _flightServices.get_list().Where(c => c.FlightCode == code).FirstOrDefault();
            var plane = _planeTypeServices.get_list().Where(c => c.Id == flight.PlaneTypeId).FirstOrDefault();
            var seatdetail = _seatDetailServices.list().Where(c => c.PlaneTypeId == plane.Id);
            int so = 1;
            int tt = 0;
            Point locaChair = new Point(540, 10);
            Point locaName = new Point(576, 16);
            Point locaSTT = new Point(548, 88);
            string[] hang = { "A", "B", "C", "D" };
            int dem = 0;
            foreach (var item in seatdetail)
            {
                if (tt == 4)
                {
                    locaChair.X -= 75;
                    locaName.X -= 75;
                    locaSTT.X -= 75;
                    locaChair.Y = 10;
                    locaName.Y = 16;
                    locaSTT.Y = 88;
                    tt = 0;
                    so++;
                }
                if (tt >= 0 && tt < 4)
                {
                    Guna2ImageCheckBox chair = new Guna2ImageCheckBox();
                    Image image = Image.FromFile(@"..//..//..//Resources//chair.png");
                    chair.Image = image;
                    chair.Name = item.Id.ToString();
                    chair.Size = new Size(34, 30);
                    chair.Location = locaChair;
                    var fl = _flightServices.get_list().Where(c => c.FlightCode == code).FirstOrDefault();
                    var check = _sfServices.Get().Where(c => c.Flightid == fl.Id && c.Seatid == item.Id).FirstOrDefault();
                    if (check.Status == 1)
                    {
                        chair.Enabled = true;
                    }
                    else
                    {
                        chair.Enabled = false;
                    }
                    chair.CheckedChanged += Chair_CheckedChanged;
                    if (dem < 20)
                    {
                        chair.BackColor = Color.DarkCyan;
                    }
                    else
                    {
                        chair.BackColor = Color.Goldenrod;
                    }
                    Label lb = new Label();
                    lb.Text = $"{so}{hang[tt]}";
                    lb.Location = locaName;
                    panel1.Controls.Add(chair);
                    panel1.Controls.Add(lb);
                    locaChair.Y += 36;
                    locaName.Y += 36;
                    tt++;
                    if (tt == 2)
                    {
                        Label lb_tt = new Label();
                        lb_tt.Text = $"{so}";
                        lb_tt.Location = locaSTT;
                        panel1.Controls.Add(lb_tt);
                        locaChair.Y += 36;
                        locaName.Y += 36;
                        panel1.Controls.Add(lb_tt);
                    }
                }
                dem++;
            }

        }
        private void cb_checkacp_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_checkacp.Checked)
            {
                btn_pay.Enabled = true;
            }
            else
            {
                btn_pay.Enabled = false;
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            var flight = _flightServices.get_list().Where(c => c.FlightCode == _code).FirstOrDefault();
            var plane = _planeTypeServices.get_list().Where(c => c.Id == flight.PlaneTypeId).FirstOrDefault();
            var seat = _seatDetailServices.list().Where(c => c.PlaneTypeId == plane.Id).ToList();
            foreach (var item in seat)
            {
                foreach (var item1 in _listcode)
                {
                    if (item.SeatCode == item1)
                    {

                    }
                }
            }
            AfterSeat af = new AfterSeat(_code, _listcode);
            this.Hide();
            af.ShowDialog();
            this.Show();
        }
    }
}
