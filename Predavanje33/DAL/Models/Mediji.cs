using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Mediji
{
    public int MedijId { get; set; }

    public string? Naslov { get; set; }

    public string? Tip { get; set; }

    public virtual ICollection<Posudbe> Posudbe { get; set; } = new List<Posudbe>();
}
