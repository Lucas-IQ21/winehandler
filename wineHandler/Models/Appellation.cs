using System;
using System.Collections.Generic;

namespace wineHandler.Models;

public partial class Appellation
{
    public int IdAppellation { get; set; }

    public string Nom { get; set; } = null!;

    public int? AnneesApogeeMin { get; set; }

    public int? AnneesApogeeMax { get; set; }

    public virtual ICollection<Vin> Vins { get; set; } = new List<Vin>();
}
