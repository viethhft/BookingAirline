using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Service
{
    public class CheckAccountType
    {
        BookingAirlineContext _context;
        List<staff> _staff;
        public CheckAccountType()
        {
            _context = new();
            _staff = new();
        }

        public int CheckType(string email, string password)
        {
            _staff = _context.staff.ToList();

            foreach (var i in _staff.Where(c => c.Email == email && c.Password == password))
            {
                if (i.RoleId == 0)
                {
                    return 1;
                }
                else if (i.RoleId == 1)
                {
                    return 2;
                }
            }
            return 0;
        }
    }
}
