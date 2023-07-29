using _1_DAL.Models;
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
    public partial class FBuyTicketChild : Form
    {
        IPlaneTypeServices _PlaneTypeServices;
        List<Flight> _test;
        public FBuyTicketChild()
        {
            InitializeComponent();
        }
        public FBuyTicketChild(List<Flight> list) : this()
        {
            _test = list;
            _PlaneTypeServices = new PlaneTypeServices();
            foreach (var item in list)
            {
                Panel form = new Panel();
                form.Name = item.FlightCode;
                form.Width = 1059;
                form.Height = 111;
                form.BorderStyle = BorderStyle.FixedSingle;
                Label time1 = new Label();
                time1.Text = item.TimeStart.ToString();
                time1.Location = new Point(18, 30);
                Label time2 = new Label();
                time2.Text = item.TimeEnd.ToString();
                time2.Location = new Point(149, 30);
                Label code = new Label();
                code.Text = item.FlightCode;
                code.Location = new Point(18, 62);
                Label name = new Label();
                var plane = _PlaneTypeServices.get_list().Where(c => c.Id == item.PlaneTypeId).FirstOrDefault();
                name.Text = plane.DisplayName;
                name.Location = new Point(149, 62);
                Guna2Button pt = new Guna2Button();
                pt.Text = "GIÁ";
                pt.BorderRadius = 10;
                pt.BorderThickness = 1;
                pt.FillColor = Color.White;
                pt.ForeColor = Color.DarkCyan;
                pt.BorderColor = Color.DarkCyan;
                pt.Width = 217;
                pt.Height = 76;
                pt.Location = new Point(613, 22);
                pt.Name = item.FlightCode;
                pt.Tag = "PT";
                pt.Click += Pt_Click;
                Guna2Button tg = new Guna2Button();
                tg.Text = "GIÁ";
                tg.BorderRadius = 10;
                tg.BorderThickness = 1;
                tg.FillColor = Color.White;
                tg.ForeColor = Color.Goldenrod;
                tg.BorderColor = Color.Goldenrod;
                tg.Width = 217;
                tg.Height = 76;
                tg.Name = item.FlightCode;
                tg.Click += Tg_Click;
                tg.Tag = "TG";
                tg.Location = new Point(836, 22);
                form.Controls.Add(time1);
                form.Controls.Add(time2);
                form.Controls.Add(code);
                form.Controls.Add(name);
                form.Controls.Add(pt);
                form.Controls.Add(tg);
                flowLayoutPanel1.Controls.Add(form);
            }
        }

        private void Tg_Click(object? sender, EventArgs e)
        {
            Guna2Button btn_current= (Guna2Button)sender;
            FChonGhe fChonGhe = new FChonGhe(btn_current.Name, btn_current.Tag.ToString());
            this.Hide();
            fChonGhe.ShowDialog();
            this.Show();
        }

        private void Pt_Click(object? sender, EventArgs e)
        {
            Guna2Button btn_current = (Guna2Button)sender;
            FChonGhe fChonGhe = new FChonGhe(btn_current.Name, btn_current.Tag.ToString());
            this.Hide();
            fChonGhe.ShowDialog();
            this.Show();
        }
    }
}
