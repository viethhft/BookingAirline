using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModel
{
    public class ViewNhanVien
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? Status { get; set; }
    }
}
