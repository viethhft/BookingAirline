using System;
using System.Collections.Generic;

namespace DuAn1.Models;

public partial class PlaneType
{
    public long Id { get; set; }

    public string PlaneCode { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public int TotalSeat { get; set; }

    public virtual ICollection<Flight> Flights { get; } = new List<Flight>();

    public virtual ICollection<SeatDetail> SeatDetails { get; } = new List<SeatDetail>();
}
