using System;
using System.Collections.Generic;

namespace E_Commerce_Voetbal.Domains_.Entities;

public partial class Section
{
    public int Id { get; set; }

    public int SectionNameId { get; set; }

    public int Capacity { get; set; }

    public int StadiumId { get; set; }

    public int TicketPrice { get; set; }

    public int SubscriptionPrice { get; set; }

    public virtual ICollection<Seat> Seats { get; set; } = new List<Seat>();

    public virtual SectionName SectionName { get; set; } = null!;

    public virtual Stadium Stadium { get; set; } = null!;
}
