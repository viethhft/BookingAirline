﻿using _1_DAL.Models;
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
        List<Flight> list_search;
        public FBuyTicketChild()
        {
            list_search=new List<Flight>();
            InitializeComponent();
        }
            //public FBuyTicketChild(List<Flight> aa):base()

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
