using System;
using System.Collections.Generic;

namespace E_Commerce_Voetbal.Domains_.Entities;

public partial class Subscription
{
    public int Id { get; set; }

    public string AspNetUserId { get; set; } = null!;

    public int SeasonId { get; set; }

    public int TeamId { get; set; }

    public int SeatId { get; set; }

    public virtual AspNetUser AspNetUser { get; set; } = null!;

    public virtual Season Season { get; set; } = null!;

    public virtual Seat Seat { get; set; } = null!;

    public virtual Team Team { get; set; } = null!;
}
