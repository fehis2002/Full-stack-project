using System;
using System.Collections.Generic;

namespace E_Commerce_Voetbal.Domains_.Entities;

public partial class Team
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int StadiumId { get; set; }

    public string Logo { get; set; } = null!;

    public virtual ICollection<Match> MatchHomeTeams { get; set; } = new List<Match>();

    public virtual ICollection<Match> MatchVisitorTeams { get; set; } = new List<Match>();

    public virtual Stadium Stadium { get; set; } = null!;

    public virtual ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();
}
