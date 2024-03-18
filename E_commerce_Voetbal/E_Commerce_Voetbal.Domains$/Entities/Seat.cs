using System;
using System.Collections.Generic;

namespace E_Commerce_Voetbal.Domains_.Entities;

public partial class Seat
{
    public int Id { get; set; }

    public int SectionId { get; set; }

    public bool Available { get; set; }

    public virtual Section Section { get; set; } = null!;

    public virtual ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
