﻿using _1_DAL.Models;
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
        public string status;
        IFlightServices _flightServices;
        IPlaneTypeServices _planeTypeServices;
        ISeatDetailServices _seatDetailServices;
        IClassServices _classServices;
        SeatFlightSer _sfServices;
        string _code = "";
        string _loaighe = "";
        int amount = 0;
        int _price = 0;
        int priceFlight = 0;
        int priceClass = 0;
        long _macb;
        List<int> _lstGhe = new();
        List<string> _listcode = new List<string>();
        string _email = "";

        public FChonGheSmallSize()
        {
            _classServices = new ClassServices();
            _flightServices = new FlightServices();
            _planeTypeServices = new PlaneTypeServices();
            _seatDetailServices = new SeatDetailServices();
            _sfServices = new();
            InitializeComponent();
            btn_pay.Enabled = false;
        }
        public FChonGheSmallSize(string code, string loaighe,string email) : this()
        {
            _price = _flightServices.get_list().Where(c => c.FlightCode == code).FirstOrDefault().Price;
            _email = email;
            _loaighe = loaighe;
            _code = code;
            var flight = _flightServices.get_list().Where(c => c.FlightCode == code).FirstOrDefault();
            var plane = _planeTypeServices.get_list().Where(c => c.Id == flight.PlaneTypeId).FirstOrDefault();
            var seatdetail = _seatDetailServices.list().Where(c => c.PlaneTypeId == plane.Id);
            int so = 1;
            int tt = 0;
            Point locaChair = new Point(550, 10);
            Point locaName = new Point(586, 16);
            Point locaSTT = new Point(558, 88);
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
                    Image image = Image.FromFile(@"..\\..\\..\\Resources\\chair.png");
                    chair.Image = image;
                    chair.Size = new Size(34, 30);
                    chair.Location = locaChair;
                    chair.Name = item.SeatCode;
                    chair.CheckedChanged += Chair_CheckedChanged;
                    var check = _sfServices.Get().Where(c => c.Flightid == flight.Id && c.Seatid == item.Id && c.Status == 1).FirstOrDefault();
                    if (check == null)
                    {
                        if (dem < 20)
                        {
                            if (loaighe == "TG")
                            {
                                chair.Enabled = false;
                            }
                            chair.Tag = "PT";
                            chair.BackColor = Color.DarkCyan;
                        }
                        else
                        {
                            if (loaighe == "PT")
                            {
                                chair.Enabled = false;
                            }
                            chair.Tag = "TG";
                            chair.BackColor = Color.Goldenrod;
                        }
                    }
                    else
                    {
                        chair.BackColor = Color.Orange;
                        chair.Enabled = false;
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
        int total = 0;
        private void Chair_CheckedChanged(object? sender, EventArgs e)
        {
            Guna2ImageCheckBox a = (Guna2ImageCheckBox)(sender);
            if (a.Tag == "PT")
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
                total += priceClass + _price;
            }
            else
            {
                _listcode.Remove(a.Name);
                amount--;
                total -= priceClass + _price;
            }
            lb_amount.Text = amount.ToString();
            lb_price.Text = total.ToString();
        }

        public FChonGheSmallSize(string code,string email) : this()
        {
            _price = _flightServices.get_list().Where(c => c.FlightCode == code).FirstOrDefault().Price;
            _email = email;
            _code = code;
            var flight = _flightServices.get_list().Where(c => c.FlightCode == code).FirstOrDefault();
            var plane = _planeTypeServices.get_list().Where(c => c.Id == flight.PlaneTypeId).FirstOrDefault();
            var seatdetail = _seatDetailServices.list().Where(c => c.PlaneTypeId == plane.Id);
            int so = 1;
            int tt = 0;
            Point locaChair = new Point(550, 10);
            Point locaName = new Point(586, 16);
            Point locaSTT = new Point(558, 88);
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
                    Image image = Image.FromFile(@"..\\..\\..\\Resources\\chair.png");
                    chair.Image = image;
                    chair.Size = new Size(34, 30);
                    chair.Location = locaChair;
                    chair.Name = item.SeatCode;
                    chair.CheckedChanged += Chair_CheckedChanged;
                    if (dem < 20)
                    {
                        chair.Tag = "PT";
                        chair.BackColor = Color.DarkCyan;
                    }
                    else
                    {
                        chair.Tag = "TG";
                        chair.BackColor = Color.Goldenrod;
                    }
                    var check = _sfServices.Get().Where(c => c.Flightid == flight.Id && c.Seatid == item.Id&& c.Status==1).FirstOrDefault();
                    if (check == null)
                    {
                        chair.Enabled = true;
                    }
                    else
                    {
                        chair.BackColor = Color.Orange;
                        chair.Enabled = false;
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
            if (amount > 0)
            {
                FAfterSeat af = new FAfterSeat(_code, _listcode, _email,total);
                this.Hide();
                af.ShowDialog();
                this.Show();
                if (af.Status == "True")
                {
                    status = "True";
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ghế!","Thông báo!");
            }
        }
    }
}
