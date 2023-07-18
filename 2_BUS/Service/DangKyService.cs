using _1_DAL.IRepon;
using _1_DAL.Models;
using _1_DAL.Repon;
using _2_BUS.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Service
{
    public class DangKyService : IDangKyService
    {
        IDangKy _dangky;
        public DangKyService()
        {
            _dangky = new DangKyRepo();
        }
        public string Create(Customer customer)
        {
            if (_repo.Create(customer))
            {
                return "Đăng ký thành công";
            }
            return "Không thành công";
        }
    }
}
