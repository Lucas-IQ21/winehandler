using System;
using System.Collections.Generic;

namespace wineHandler.Models;

public partial class Vin
{
    public int IdVin { get; set; }

    public string Couleur { get; set; } = null!;

    public int IdAppellation { get; set; }

    public string Nom { get; set; } = null!;

    public int AnneeMillesime { get; set; }

    public int? AnneesRecMin { get; set; }

    public int? AnneesRecMax { get; set; }

    public virtual ICollection<Bouteille> Bouteilles { get; set; } = new List<Bouteille>();

    public virtual Appellation IdAppellationNavigation { get; set; } = null!;
}
