using _1_DAL.IRepon;
using _1_DAL.Models;
using _1_DAL.Repon;
using _2_BUS.IService;
using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Service
{
    public class NhanVienServices: INhanVienServices
    {
        List<ViewNhanVien> _viewNhanVienList;
        IChucVuRepon _IChucVuRepon;
        INhanVienRepon _INhanVienRepon;
        List<staff> _lststaff;
        public NhanVienServices()
        {
            _lststaff = new List<staff>();
            _viewNhanVienList = new List<ViewNhanVien>();
            _IChucVuRepon = new ChucVuRepon();
            _INhanVienRepon = new NhanVienRepon();
        }

        public bool addNhanVien(ViewNhanVien nhanVien)
        {
            staff sta = new staff()
            {
                Id = nhanVien.Id,
                RoleId = nhanVien.RoleId,
                DisplayName = nhanVien.DisplayName,
                Password = nhanVien.Password,
                Email = nhanVien.Email,
                Phone = nhanVien.Phone,
                Status = nhanVien.Status,

            };
            _INhanVienRepon.addNhanVien(sta);
            return true;
        }

        public bool deleteNhanVien(int Id)
        {
            var delete = _INhanVienRepon.getNhanVien().FirstOrDefault(c => c.Id == Id);
            _INhanVienRepon.deleteNhanVien(delete);
            return true;
        }

        public List<staff> getAllNhanVien()
        {
            _lststaff = _INhanVienRepon.getNhanVien().ToList();
            return _lststaff;
        }

        public List<ViewNhanVien> GetAllViewNhanVien()
        {
            _viewNhanVienList = (from a in _INhanVienRepon.getNhanVien()
                                 join b in _IChucVuRepon.getAllChucVu() on a.RoleId equals b.Id
                                 select new ViewNhanVien
                                 {
                                     Id = a.Id,
                                     RoleId = a.RoleId,
                                     DisplayName = a.DisplayName,
                                     Password = a.Password,
                                     Email = a.Email,
                                     Phone = a.Phone,
                                     Status = a.Status,

                                 }).ToList();
            return _viewNhanVienList;
        }

        public bool updateNhanVien(ViewNhanVien nhanVien)
        {
            var update = _INhanVienRepon.getNhanVien().FirstOrDefault(c => c.Id == nhanVien.Id);
            update.DisplayName = nhanVien.DisplayName;
            update.Password = nhanVien.Password;
            update.Email = nhanVien.Email;
            update.Phone = nhanVien.Phone;
            update.Status = nhanVien.Status;
            return true;
        }
    }
    
}
