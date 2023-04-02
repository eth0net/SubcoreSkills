using RimWorld;
using Verse;

namespace SubcoreSkills
{
    /// <summary>
    /// SubcoreSkill class to store required skill info.
    /// </summary>
    public class SubcoreSkill : IExposable
    {
        /// <summary>
        /// Name for this skill.
        /// </summary>
        public string Name;

        /// <summary>
        /// Level for this skill.
        /// </summary>
        public int Level;

        /// <summary>
        /// Passion for this skill.
        /// </summary>
        public Passion Passion;

        /// <summary>
        /// Order in lists for this skill.
        /// </summary>
        public int Order;

        /// <summary>
        /// Construct a blank SubcoreSkill.
        /// </summary>
        public SubcoreSkill() { }

        /// <summary>
        /// Construct a SubcoreSkill from a SkillRecord to store the data we need.
        /// </summary>
        /// <param name="skillRecord"></param>
        public SubcoreSkill(SkillRecord skillRecord)
        {
            Name = skillRecord.def.defName;
            Level = skillRecord.levelInt;
            Passion = skillRecord.passion;
            Order = (int)skillRecord.def.listOrder;
        }

        /// <summary>
        /// ExposeData saves and loads data.
        /// </summary>
        public void ExposeData()
        {
            Scribe_Values.Look(ref Name, "name", "");
            Scribe_Values.Look(ref Level, "level", 0);
            Scribe_Values.Look(ref Passion, "passion", Passion.None);
            Scribe_Values.Look(ref Order, "order", 0);
        }

        /// <summary>
        /// StatDrawEntry returns a complete StatDrawEntry for the skill.
        /// </summary>
        /// <returns></returns>
        public StatDrawEntry StatDrawEntry()
        {
            return new(StatCategoryDefOf.SubcoreSkills, Name, Level.ToString(), "Subcore skill level for " + Name + ".", Order + 200);
        }
    }
}
