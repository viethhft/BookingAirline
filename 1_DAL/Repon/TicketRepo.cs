using _1_DAL.IRepon;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repon
{
    public class TicketRepo : ITicketRepo
    {
        BookingAirlineContext _context;
        public TicketRepo()
        {
            _context=new BookingAirlineContext();
        }
        public bool AddTicket(Ticket ticket)
        {
            try
            {
                _context.Tickets.Add(ticket);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Ticket> GetTickets()
        {
            return _context.Tickets.ToList();
        }

        public bool UpdateTicket(Ticket ticket)
        {
        }
    }
}
