using RimWorld;
using SubcoreInfo.Comps;
using System.Collections.Generic;
using Verse;

namespace SubcoreSkills.Comps
{
    public class CompSkillsBase : CompBase
    {
        /// <summary>
        /// Skills tracks the skills of the pawn scanned.
        /// </summary>
        public List<SkillRecord> Skills;

        /// <summary>
        /// PostExposeData is used to save our component state.
        /// </summary>
        public override void PostExposeData()
        {
            base.PostExposeData();
            Scribe_Deep.Look(ref Skills, "skills");
        }

        /// <summary>
        /// Copy the data from a pawn into this comp to ease data transfer.
        /// </summary>
        /// <param name="pawn"></param>
        public override void Copy(Pawn pawn)
        {
            Skills = pawn.skills.skills;
        }

        /// <summary>
        /// Copy the data from another comp into this one to ease data transfer.
        /// </summary>
        /// <param name="other"></param>
        public override void Copy(CompBase other)
        {
            if (other is CompSkillsBase comp)
            {
                Skills = comp.Skills;
            }
        }

        /// <summary>
        /// Reset clears all data in this comp.
        /// </summary>
        public override void Reset()
        {
            Skills = null;
        }
    }
}
