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

namespace DuAn1.Views
{
    public partial class FquanlyVe : Form
    {
        ITicketServices _ticketServices;
        public FquanlyVe()
        {
            _ticketServices = new TicketServices();
            InitializeComponent();
            load();
        }
        void load()
        {
            dgv_data.DataSource = _ticketServices.list_Ticket();
        }

    }
}
