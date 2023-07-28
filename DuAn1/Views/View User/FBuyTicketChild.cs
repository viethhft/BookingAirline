using _1_DAL.Models;
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
            flowLayoutPanel1.Controls.Clear();
            Panel a = new Panel();
            foreach (var item in list)
            {
                a = panel1;
                flowLayoutPanel1.Controls.Add(a);
                MessageBox.Show("a");
            }
        }
        
    }
}
