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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views.View_User
{
    public partial class FLichBayChild : Form
    {
        IFlightServices _flightServices;
        IPlaneTypeServices _planeTypeServices;
        ISeatDetailServices _seatDetailServices;
        public FLichBayChild()
        {
            InitializeComponent();
        }
        public FLichBayChild(List<Flight> list, DateTime date) : this()
        {
            _flightServices = new FlightServices();
            _planeTypeServices = new PlaneTypeServices();
            _seatDetailServices = new SeatDetailServices();
            int count = 0;
            int daycount = list.FirstOrDefault().DateFlight.Day;
            label3.Text =$"{daycount++}/{date.Month}";
            label4.Text =$"{daycount++}/{date.Month}";
            label5.Text =$"{daycount++}/{date.Month}";
            label6.Text =$"{daycount++}/{date.Month}";
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in _planeTypeServices.get_list())
            {
                Point loca_timeStart = new Point(25, 35);
                Point loca_timeEnd = new Point(147, 35);
                Point loca_code = new Point(25, 63);
                Point loca_StopPoint = new Point(453, 45);
                Point loca_pic = new Point(635, 22);
                Point loca_textPic = new Point(650, 72);
                GroupBox group = new GroupBox();
                group.Size = new Size(1140, 105);
                foreach (var item1 in list)
                {
                    if (item1.PlaneTypeId == item.Id)
                    {
                        if (count == 0)
                        {
                            Label lb_timeStart = new Label();
                            lb_timeStart.Text = item1.TimeStart.ToString();
                            lb_timeStart.Location = loca_timeStart;
                            Label lb_timeEnd = new Label();
                            lb_timeEnd.Text = item1.TimeEnd.ToString();
                            lb_timeEnd.Location = loca_timeEnd;
                            Label lb_code = new Label();
                            lb_code.Text = item.PlaneCode;
                            lb_code.Location = loca_code;
                            Label lb_stopPoint = new Label();
                            lb_stopPoint.Text = "Bay thẳng";
                            lb_stopPoint.Location = loca_StopPoint;
                            group.Controls.Add(lb_timeStart);
                            group.Controls.Add(lb_timeEnd);
                            group.Controls.Add(lb_code);
                            group.Controls.Add(lb_stopPoint);
                            PictureBox pic = new PictureBox();
                            Image image = Image.FromFile(@"..\\..\\..\\Resources\\icons8-plane-30 (2).png");
                            pic.Image = image;
                            pic.Size = new Size(64, 47);
                            pic.Location = loca_pic;
                            pic.Click += Pic_Click;
                            pic.BackColor = Color.White;
                            pic.SizeMode = PictureBoxSizeMode.CenterImage;
                            //pic.MouseHover += Pic_MouseHover;
                            //pic.MouseLeave += Pic_MouseLeave;
                            pic.Name = item1.FlightCode;
                            Label lb_select = new Label();
                            lb_select.Text = "Chọn";
                            lb_select.ForeColor = Color.DarkCyan;
                            lb_select.Location = loca_textPic;
                            group.Controls.Add(pic);
                            group.Controls.Add(lb_select);
                            loca_pic.X += 135;
                            loca_textPic.X += 135;
                        }
                        else
                        {
                            PictureBox pic = new PictureBox();
                            Image image = Image.FromFile(@"..\\..\\..\\Resources\\icons8-plane-30 (2).png");
                            pic.Image = image;
                            pic.Size = new Size(64, 47);
                            pic.Location = loca_pic;
                            pic.Click += Pic_Click;
                            pic.Name = item1.FlightCode;
                            pic.BackColor = Color.White;
                            pic.SizeMode = PictureBoxSizeMode.CenterImage;
                            Label lb_select = new Label();
                            lb_select.Text = "Chọn";
                            lb_select.ForeColor = Color.DarkCyan;
                            lb_select.Location = loca_textPic;
                            group.Controls.Add(pic);
                            group.Controls.Add(lb_select);
                            loca_pic.X += 135;
                            loca_textPic.X += 135;
                        }
                        flowLayoutPanel1.Controls.Add(group);
                    }
                }
            }
        }

        private void Pic_MouseLeave(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Pic_MouseHover(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Pic_Click(object? sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)(sender);
            var flight = _flightServices.get_list().Where(c => c.FlightCode == pic.Name).FirstOrDefault();
            var plane = _planeTypeServices.get_list().Where(c => c.Id == flight.PlaneTypeId).FirstOrDefault();
            var seatdetail = _seatDetailServices.list().Where(c => c.PlaneTypeId == plane.Id);
            if (seatdetail.Count() == 50)
            {
                FChonGheBigSize fChonGhe = new FChonGheBigSize(pic.Name);
                this.Hide();
                fChonGhe.ShowDialog();
                this.Show();
            }
            else
            {
                FChonGheSmallSize fChonGhe = new FChonGheSmallSize(pic.Name);
                this.Hide();
                fChonGhe.ShowDialog();
                this.Show();
            }
        }
    }
}
