using System;
using System.Collections.Generic;

namespace wineHandler.Models;

public partial class Cave
{
    public int IdCave { get; set; }

    public string Nom { get; set; } = null!;

    public string? Famille { get; set; }

    public string? Fabricant { get; set; }

    public int NbTiroirs { get; set; }

    public int BouteillesParTiroir { get; set; }

    public decimal? TemperatureC { get; set; }

    public int? Capacite { get; set; }

    public virtual ICollection<Bouteille> Bouteilles { get; set; } = new List<Bouteille>();
}
