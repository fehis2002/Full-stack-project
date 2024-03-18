using System;
using System.Collections.Generic;

namespace E_Commerce_Voetbal.Domains_.Entities;

public partial class Ticket
{
    public int Id { get; set; }

    public string AspNetUserId { get; set; } = null!;

    public int MatchId { get; set; }

    public int SeatId { get; set; }

    public virtual AspNetUser AspNetUser { get; set; } = null!;

    public virtual Match Match { get; set; } = null!;

    public virtual Seat Seat { get; set; } = null!;
}
