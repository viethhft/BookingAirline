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

namespace DuAn1.Views
{
    public partial class FquanLyDoanhThu : Form
    {
        ITicketServices _ticketServices;
        IFlightServices _flightServices;
        public FquanLyDoanhThu()
        {
            _ticketServices = new TicketServices();
            _flightServices = new FlightServices();
            InitializeComponent();
            dgv_Revenue.ColumnCount = 4;
            dgv_Revenue.Columns[0].Name = "STT";
            dgv_Revenue.Columns[1].Name = "Mã chuyến bay";
            dgv_Revenue.Columns[2].Name = "Ngay bay";
            dgv_Revenue.Columns[3].Name = "Tổng doanh thu";
            var ticket = _ticketServices.list_Ticket().ToList();
            for (int i = 0; i < ticket.Count; i++)
            {
                for (int j = 0; j < ticket.Count; j++)
                {
                    if (ticket[i].FlightId > ticket[j].FlightId)
                    {
                        Ticket term = ticket[i];
                        ticket[i] = ticket[j];
                        ticket[j] = term;
                    }
                }
            }
            int count = 0;
            int total = 0;
            int stt = 1;
            for (int i = count; i < ticket.Count; i++)
            {
                total += ticket[i].TotalPrice;
                for (int j = i + 1; j < ticket.Count; j++)
                {
                    if (ticket[i].FlightId == ticket[j].FlightId)
                    {
                        total += ticket[j].TotalPrice;
                    }
                    else
                    {
                        count = j;
                        break;
                    }
                }
                var fl = _flightServices.get_list().Where(c => c.Id == ticket[i].FlightId).FirstOrDefault();
                dgv_Revenue.Rows.Add(stt, fl.FlightCode, fl.DateFlight, total);
                stt++;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_fill_Click(object sender, EventArgs e)
        {

        }
    }
}
