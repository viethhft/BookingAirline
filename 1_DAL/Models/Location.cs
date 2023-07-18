using System;
using System.Collections.Generic;

namespace _1_DAL.Models
{
    public partial class Location
    {
        public Location()
        {
            Flights = new HashSet<Flight>();
        }

        public int Id { get; set; }
        public string LocaCode { get; set; } = null!;
        public string DisplayName { get; set; } = null!;

        public virtual ICollection<Flight> Flights { get; set; }
    }
}
