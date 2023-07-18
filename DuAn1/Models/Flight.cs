using System;
using System.Collections.Generic;

namespace DuAn1.Models;

public partial class Flight
{
    public long Id { get; set; }

    public long PlaneTypeId { get; set; }

    public int LocationId { get; set; }

    public string FlightCode { get; set; } = null!;

    public string GoFrom { get; set; } = null!;

    public string GoTo { get; set; } = null!;

    public int Price { get; set; }

    public DateTime DateFlight { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual PlaneType PlaneType { get; set; } = null!;

    public virtual ICollection<Recommend> Recommends { get; } = new List<Recommend>();

    public virtual ICollection<Ticket> Tickets { get; } = new List<Ticket>();
}
