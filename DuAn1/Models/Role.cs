using System;
using System.Collections.Generic;

namespace DuAn1.Models;

public partial class Role
{
    public int Id { get; set; }

    public string? DisplayName { get; set; }

    public virtual ICollection<Staff> Staff { get; } = new List<Staff>();
}
