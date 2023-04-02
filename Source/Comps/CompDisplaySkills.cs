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
            for (int i = Skills.Count; i-- > 0;)
            {
                yield return Skills[i].StatDrawEntry();
            }
        }
    }
}
