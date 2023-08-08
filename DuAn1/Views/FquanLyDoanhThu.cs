using _1_DAL.Models;
using _2_BUS.IService;
using _2_BUS.Service;
using Microsoft.Office.Interop.Excel;
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
        IPlaneTypeServices _planeTypeServices;
        public FquanLyDoanhThu()
        {
            _planeTypeServices = new PlaneTypeServices();
            _ticketServices = new TicketServices();
            _flightServices = new FlightServices();
            InitializeComponent();
            load();
        }
        void load()
        {
            dgv_Revenue.ColumnCount = 6;
            dgv_Revenue.Rows.Clear();
            dgv_Revenue.Columns[0].Name = "STT";
            dgv_Revenue.Columns[1].Name = "Mã chuyến bay";
            dgv_Revenue.Columns[2].Name = "Ngay bay";
            dgv_Revenue.Columns[3].Name = "Số vé đã bán";
            dgv_Revenue.Columns[4].Name = "Tổng số vé";
            dgv_Revenue.Columns[5].Name = "Tổng doanh thu";
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
            int total = 0;
            int stt = 1;
            for (int i = 0; i < ticket.Count; i++)
            {
                int soveban = 1;
                total = ticket[i].TotalPrice;
                for (int j = i + 1; j < ticket.Count; j++)
                {
                    if (ticket[i].FlightId == ticket[j].FlightId)
                    {
                        soveban++;
                        total += ticket[j].TotalPrice;
                    }
                    else
                    {
                        var fl = _flightServices.get_list().Where(c => c.Id == ticket[i].FlightId).FirstOrDefault();
                        var plane = _planeTypeServices.get_list().Where(c => c.Id == fl.PlaneTypeId).FirstOrDefault();
                        dgv_Revenue.Rows.Add(stt, fl.FlightCode, fl.DateFlight, soveban, plane.TotalSeat, total);
                        i = j - 1;
                        break;
                    }
                }
                if (i + 1 == ticket.Count)
                {
                    var fl = _flightServices.get_list().Where(c => c.Id == ticket[i].FlightId).FirstOrDefault();
                    var plane = _planeTypeServices.get_list().Where(c => c.Id == fl.PlaneTypeId).FirstOrDefault();
                    dgv_Revenue.Rows.Add(stt, fl.FlightCode, fl.DateFlight, 1, plane.TotalSeat, total);
                }
                stt++;
            }
        }
        private void btn_fill_Click(object sender, EventArgs e)
        {
            dgv_Revenue.ColumnCount = 4;
            dgv_Revenue.Rows.Clear();
            dgv_Revenue.Columns[0].Name = "STT";
            dgv_Revenue.Columns[1].Name = "Mã chuyến bay";
            dgv_Revenue.Columns[2].Name = "Ngay bay";
            dgv_Revenue.Columns[3].Name = "Tổng doanh thu";
            var ticket = _ticketServices.list_Ticket().Where(c => c.CreateDate >= date_From.Value.AddDays(-1) && c.CreateDate <= date_To.Value).ToList();
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
            int total = 0;
            int stt = 1;
            for (int i = 0; i < ticket.Count; i++)
            {
                total = ticket[i].TotalPrice;
                for (int j = i + 1; j < ticket.Count; j++)
                {
                    if (ticket[i].FlightId == ticket[j].FlightId)
                    {
                        total += ticket[j].TotalPrice;
                    }
                    else
                    {
                        var fl = _flightServices.get_list().Where(c => c.Id == ticket[i].FlightId).FirstOrDefault();
                        dgv_Revenue.Rows.Add(stt, fl.FlightCode, fl.DateFlight, total);
                        i = j - 1;
                        break;
                    }
                }
                if (i + 1 == ticket.Count)
                {
                    var fl = _flightServices.get_list().Where(c => c.Id == ticket[i].FlightId).FirstOrDefault();
                    dgv_Revenue.Rows.Add(stt, fl.FlightCode, fl.DateFlight, total);
                }
                stt++;
            }
        }

        private void date_To_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(date_From.Value, date_To.Value) == 1)
            {
                MessageBox.Show("Ngày sau không thể nhỏ hơn ngày trước");
                date_To.Value = date_From.Value;
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            Export();
        }
        void Export()
        {
            //try
            //{
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgv_Revenue.Columns.Count; i++)
            {
                excel.Cells[1, i + 1] = dgv_Revenue.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgv_Revenue.Rows.Count; i++)
            {
                for (int j = 0; j < dgv_Revenue.Columns.Count; j++)
                {
                    excel.Cells[i + 2, j + 1] = dgv_Revenue.Rows[i].Cells[j].Value.ToString();
                }
            }
            excel.Columns.AutoFit();
            excel.Visible = false;
            excel.GetSaveAsFilename();
        }
    }
}
