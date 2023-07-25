﻿using System;
using System.Collections.Generic;

namespace _1_DAL.Models
{
    public partial class Ticket
    {
        public long Id { get; set; }
        public string NameTicket { get; set; }
        public long CustomerId { get; set; }
        public long FlightId { get; set; }
        public DateTime CreateDate { get; set; }
        public int TwoWay { get; set; }

        public int status { get; set; }
        public int TotalPrice { get; set; }
        public string SeatCode { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Flight Flight { get; set; } = null!;
    }
}
