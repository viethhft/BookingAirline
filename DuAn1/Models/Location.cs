using System;
using System.Collections.Generic;

namespace DuAn1.Models;

public partial class Location
{
    public int Id { get; set; }

    public string LocaCode { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public virtual ICollection<Flight> Flights { get; } = new List<Flight>();
}
