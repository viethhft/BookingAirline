using _1_DAL.IRepon;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repon
{
    public class CustomerRepo : ICustomerRepo
    {
        BookingAirlineContext _context;
        public CustomerRepo()
        {
            _context = new();
        }
        public bool Create(Customer cus)
        {
            try
            {
                _context.Customers.Add(cus);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Customer Get(string id)
        {
            return _context.Customers.Where(c => c.Email == id).FirstOrDefault();
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }
        public bool Update(Customer cus)
        {
            try
            {
                _context.Customers.Update(cus);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
