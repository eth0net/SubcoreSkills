using RimWorld;
using System.Collections.Generic;

namespace SubcoreSkills.Comps
{
    /// <summary>
    /// CompDisplayInfo implements the common display methods for subcore skill components.
    /// </summary>
    public class CompDisplaySkills : CompSkillsBase
    {
        /// <summary>
        /// CompInspectStringExtra adds to the item inspection pane.
        /// </summary>
        /// <returns></returns>
        public override string CompInspectStringExtra()
        {
            return base.CompInspectStringExtra();
        }

        /// <summary>
        /// SpecialDisplayStats adds to the item info pane.
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<StatDrawEntry> SpecialDisplayStats()
        {
            foreach (SkillRecord skill in Skills)
            {
                yield return new StatDrawEntry(StatCategoryDefOf.SubcoreSkills, skill.def.defName, skill.Level.ToString(), "Subcore skill level for " + skill.def.defName + ".", 10);
            }
        }
    }
}
