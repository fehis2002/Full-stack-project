using System;
using System.Collections.Generic;

namespace E_Commerce_Voetbal.Domains_.Entities;

public partial class SectionName
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Section> Sections { get; set; } = new List<Section>();
}
