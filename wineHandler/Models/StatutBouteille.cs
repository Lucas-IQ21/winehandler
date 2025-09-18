using System.ComponentModel;

namespace wineHandler.Models
{
    public enum StatutBouteille
    {
        [Description("Stock")]
        S,
        [Description("Consommée")]
        C,
        [Description("Jetée")]
        J,
        [Description("Réservée")]
        R,
        [Description("Vendue")]
        V,
        [Description("Cadeau")]
        G,
        [Description("Cassée/Perdue")]
        X,
    }
}