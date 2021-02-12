using System.ComponentModel;

namespace BlaTzee.Types
{
    public enum Wins
    {
        [Description("No matches; you lost ")]
        none,
        [Description("Pair; you lost ")] Pair,
        [Description("3 of a Kind; you win ")] ThreeOfKind,
        [Description("4 of a Kind; you win ")] FourOfKind,
        [Description("5 of a kind; you win ")] FiveOfKind,
        [Description("Straight; you win ")] Straight
    }
}