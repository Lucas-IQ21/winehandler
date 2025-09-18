using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace wineHandler.Models;

public partial class Bouteille
{
    public int IdBouteille { get; set; }

    public int IdVin { get; set; }

    public int IdCave { get; set; }

    public int NoTiroir { get; set; }

    public int? NoEmplacement { get; set; }

    public string Statut { get; set; } = null!;

    [NotMapped] // pas mappé côté bdd
    public StatutBouteille StatutEnum
    {
        get => Enum.TryParse<StatutBouteille>(Statut, out var result) ? result : StatutBouteille.S;
        set => Statut = value.ToString();
    }

    public DateOnly? DateAcquisition { get; set; }

    public DateOnly? DateConsommation { get; set; }

    public string? Note { get; set; }

    public virtual Cave IdCaveNavigation { get; set; } = null!;

    public virtual Vin IdVinNavigation { get; set; } = null!;
}
