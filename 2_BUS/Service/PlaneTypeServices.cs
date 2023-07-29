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
    public class PlaneTypeServices : IPlaneTypeServices
    {
        IPlaneTypeRepo _repo;
        public PlaneTypeServices()
        {
            _repo= new PlaneTypeRepo();
        }
        public List<PlaneType> get_list()
        {
            return _repo.get_list();
        }
    }
}
