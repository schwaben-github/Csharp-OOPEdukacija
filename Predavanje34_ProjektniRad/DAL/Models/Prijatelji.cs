using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Prijatelji
{
    public int PrijateljId { get; set; }

    public string? Ime { get; set; }

    public string? Prezime { get; set; }

    public string? Telefon { get; set; }

    public virtual ICollection<Posudbe> Posudbe { get; set; } = new List<Posudbe>();
}
