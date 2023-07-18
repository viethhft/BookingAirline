using System;
using System.Collections.Generic;

namespace DuAn1.Models;

public partial class Class
{
    public int Id { get; set; }

    public string DisplayName { get; set; } = null!;

    public int Price { get; set; }

    public virtual ICollection<SeatDetail> SeatDetails { get; } = new List<SeatDetail>();
}
