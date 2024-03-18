using System;
using System.Collections.Generic;

namespace E_Commerce_Voetbal.Domains_.Entities;

public partial class Match
{
    public int Id { get; set; }

    public int HomeTeamId { get; set; }

    public int VisitorTeamId { get; set; }

    public int SeasonId { get; set; }

    public DateTime Date { get; set; }

    public TimeSpan Time { get; set; }

    public virtual Team HomeTeam { get; set; } = null!;

    public virtual Season Season { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    public virtual Team VisitorTeam { get; set; } = null!;
}
