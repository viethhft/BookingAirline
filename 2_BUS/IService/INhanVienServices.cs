using _1_DAL.Models;
using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface INhanVienServices
    {
       public bool addNhanVien(ViewNhanVien nhanVien);

        public bool deleteNhanVien(int Id);
        public bool updateNhanVien(ViewNhanVien nhanVien);
        public List<staff> getAllNhanVien(); 
        //public List<staff> getAllNhanVien();
        public List<ViewNhanVien> GetAllViewNhanVien();
    }
}
