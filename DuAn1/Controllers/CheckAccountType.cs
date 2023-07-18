using DuAn1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1.Controllers.Controller
{
    public class CheckAccountType
    {
        BookingAirlineContext _context;
        List<Staff> _staff;
        public CheckAccountType()
        {
            _context = new();
            _staff = new();
        }

        public int CheckType(string email, string password)
        {
            _staff = _context.Staff.ToList();

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
