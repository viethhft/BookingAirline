using System;
using System.Collections.Generic;

namespace DuAn1.Models;

public partial class Customer
{
    public long Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime? Dob { get; set; }

    public string? Gender { get; set; }

    public string Phone { get; set; } = null!;

    public string? Address { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<Bank> Banks { get; } = new List<Bank>();

    public virtual ICollection<Ticket> Tickets { get; } = new List<Ticket>();
}
