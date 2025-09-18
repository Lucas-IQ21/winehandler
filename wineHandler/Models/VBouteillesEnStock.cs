using System;
using System.Collections.Generic;

namespace wineHandler.Models;

public partial class VBouteillesEnStock
{
    public int IdBouteille { get; set; }

    public string NomCave { get; set; } = null!;

    public string? Famille { get; set; }

    public string? Fabricant { get; set; }

    public int NoTiroir { get; set; }

    public int? NoEmplacement { get; set; }

    public string NomVin { get; set; } = null!;

    public string Couleur { get; set; } = null!;

    public string NomAppellation { get; set; } = null!;

    public int AnneeMillesime { get; set; }

    public int? AnneeApogeeDebut { get; set; }

    public int? AnneeApogeeFin { get; set; }
}
