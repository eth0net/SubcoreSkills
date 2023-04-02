using RimWorld;
using SubcoreInfo;
using Verse;

namespace SubcoreSkills.Comps
{
    /// <summary>
    /// CompSubcoreSkills is added to subcores and is used to track skills of the pawn scanned into the subcore.
    /// </summary>
    public class CompSubcoreSkills : CompDisplaySkills
    {
        /// <summary>
        /// AllowStackWith ensures that subcores can only be stacked with others of the same pattern.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool AllowStackWith(Thing other)
        {
            if (!base.AllowStackWith(other)) { return false; }

            CompSubcoreSkills otherComp = other?.TryGetComp<CompSubcoreSkills>();
            if (otherComp == null) { return false; }

            return Skills == otherComp.Skills;
        }

        /// <summary>
        /// PostPostGeneratedForTrader is called after the subcore is generated for a trader.
        /// </summary>
        /// <param name="trader"></param>
        /// <param name="forTile"></param>
        /// <param name="forFaction"></param>
        public override void PostPostGeneratedForTrader(TraderKindDef trader, int forTile, Faction forFaction)
        {
            base.PostPostGeneratedForTrader(trader, forTile, forFaction);

            if (!SubcoreInfoSettings.randomTraderInfo) { return; }

            Copy(PawnGenerator.GeneratePawn(forFaction.RandomPawnKind(), forFaction));
        }
    }
}
