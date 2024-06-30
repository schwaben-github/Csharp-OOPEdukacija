using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Posudbe
{
    public int PosudbaId { get; set; }

    public int? PrijateljId { get; set; }

    public DateTime DatumPosudbe { get; set; }

    public DateTime? DatumVracanja { get; set; }

    public int? MedijId { get; set; }

    public virtual Mediji? Medij { get; set; }

    public virtual Prijatelji? Prijatelj { get; set; }
}
