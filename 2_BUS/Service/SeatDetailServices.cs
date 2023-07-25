using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.IRepon;
using _1_DAL.Models;
using _1_DAL.Repon;
using _2_BUS.IService;
namespace _2_BUS.Service
{
    public class SeatDetailServices : ISeatDetailServices
    {
        ISeatDetailRepo _repo;
        public SeatDetailServices()
        {
            _repo=new SeatDetailRepo();
        }
        public string Create(SeatDetail seatDetail)
        {
            if (_repo.Create(seatDetail))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm không thành công";
            }    
        }

        public List<SeatDetail> list()
        {
            return _repo.get_list();
        }
    }
}
