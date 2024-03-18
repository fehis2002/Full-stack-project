using System;
using System.Collections.Generic;

namespace E_Commerce_Voetbal.Domains_.Entities;

public partial class Stadium
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Image { get; set; } = null!;

    public virtual ICollection<Section> Sections { get; set; } = new List<Section>();

    public virtual ICollection<Team> Teams { get; set; } = new List<Team>();
}
