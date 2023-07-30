using _2_BUS.IService;
using _2_BUS.Service;
using Guna.UI2.WinForms;
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
    public partial class FChonGheBigSize : Form
    {
        IFlightServices _flightServices;
        IPlaneTypeServices _planeTypeServices;
        ISeatDetailServices _seatDetailServices;
        IClassServices _classServices;
        public FChonGheBigSize()
        {
            _classServices= new ClassServices();
            _flightServices = new FlightServices();
            _planeTypeServices = new PlaneTypeServices();
            _seatDetailServices = new SeatDetailServices();
            InitializeComponent();
        }
        string _code = "";
        string _loaighe = "";
        int amount = 0;
        int price = 0;
        int priceFlight = 0;
        int priceClass = 0;
        public FChonGheBigSize(string code, string loaighe) : this()
        {
            _code = code;
            _loaighe = loaighe;
            var flight = _flightServices.get_list().Where(c => c.FlightCode == code).FirstOrDefault();
            var plane = _planeTypeServices.get_list().Where(c => c.Id == flight.PlaneTypeId).FirstOrDefault();
            var seatdetail = _seatDetailServices.list().Where(c => c.PlaneTypeId == plane.Id);
            int so = 1;
            int tt = 0;
            Point locaChair = new Point(730, 17);
            Point locaName = new Point(766, 23);
            Point locaSTT = new Point(738, 95);
            string[] hang = { "A", "B", "C", "D" };
            int dem = 0;
            foreach (var item in seatdetail)
            {
                if (tt == 4)
                {
                    locaChair.X -= 60;
                    locaName.X -= 60;
                    locaSTT.X -= 60;
                    locaChair.Y = 17;
                    locaName.Y = 23;
                    locaSTT.Y = 95;
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
                    chair.Name = item.SeatCode;
                    chair.CheckedChanged += Chair_CheckedChanged;
                    if (dem < 35)
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
        public FChonGheBigSize(string code) : this()
        {
            _code = code;
            var flight = _flightServices.get_list().Where(c => c.FlightCode == code).FirstOrDefault();
            var plane = _planeTypeServices.get_list().Where(c => c.Id == flight.PlaneTypeId).FirstOrDefault();
            var seatdetail = _seatDetailServices.list().Where(c => c.PlaneTypeId == plane.Id);
            int so = 1;
            int tt = 0;
            Point locaChair = new Point(730, 17);
            Point locaName = new Point(766, 23);
            Point locaSTT = new Point(738, 95);
            string[] hang = { "A", "B", "C", "D" };
            int dem = 0;
            foreach (var item in seatdetail)
            {
                if (tt == 4)
                {
                    locaChair.X -= 60;
                    locaName.X -= 60;
                    locaSTT.X -= 60;
                    locaChair.Y = 17;
                    locaName.Y = 23;
                    locaSTT.Y = 95;
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
                    chair.Name = item.SeatCode;
                    chair.CheckedChanged += Chair_CheckedChanged;
                    if (dem < 35)
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
        
        private void Chair_CheckedChanged(object? sender, EventArgs e)
        {
            Guna2ImageCheckBox a = (Guna2ImageCheckBox)(sender);
            if (_loaighe=="PT")
            {
                priceClass = _classServices.get_list().Where(c => c.Id == 2).FirstOrDefault().Price;
            }
            else
            {
                priceClass = _classServices.get_list().Where(c => c.Id == 1).FirstOrDefault().Price;
            }
            if (a.Checked)
            {
                amount++;
                price += priceClass;
            }
            else
            {
                amount--;
                price -= priceClass;
            }
            lb_amount.Text = amount.ToString();
            lb_price.Text=price.ToString();
        }

        
    }
}
