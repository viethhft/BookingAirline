using _1_DAL.Models;
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
        public FBuyTicketChild()
        {
            InitializeComponent();
        }
        public FBuyTicketChild(List<Flight> list) : this()
        {
            foreach (var item in list)
            {
                Panel form = new Panel();
                form.Width = 1235;
                form.Height = 111;
                form.BorderStyle = BorderStyle.FixedSingle;
                Label time1 = new Label();
                time1.Text = "ok";
                time1.Location = new Point(18, 30);
                Label time2 = new Label();
                time2.Text = "ok1";
                time2.Location = new Point(149, 30);
                Label code = new Label();
                code.Text = "code";
                code.Location = new Point(18, 62);
                Label name = new Label();
                code.Text = "name";
                code.Location = new Point(149, 62);
                Guna2Button pt = new Guna2Button();
                pt.Text = "GIÁ";
                pt.BorderRadius = 10;
                pt.BorderThickness = 1;
                pt.FillColor = Color.White;
                pt.ForeColor = Color.DarkCyan;
                pt.BorderColor = Color.DarkCyan;
                pt.Width = 217;
                pt.Height = 76;
                pt.Location = new Point(750, 22);
                Guna2Button tg = new Guna2Button();
                tg.Text = "GIÁ";
                tg.BorderRadius = 10;
                tg.BorderThickness = 1;
                tg.FillColor = Color.White;
                tg.ForeColor = Color.Goldenrod;
                tg.BorderColor = Color.Goldenrod;
                tg.Width = 217;
                tg.Height = 76;
                tg.Location = new Point(1000, 22);
                form.Controls.Add(time1);
                form.Controls.Add(time2);
                form.Controls.Add(code);
                form.Controls.Add(name);
                form.Controls.Add(pt);
                form.Controls.Add(tg);
                flowLayoutPanel1.Controls.Add(form);
            }
            int a = flowLayoutPanel1.Controls.Count;
            MessageBox.Show(a.ToString());

        }

    }
}
