using SubcoreInfo;
using UnityEngine;
using Verse;

namespace SubcoreSkills
{
    /// <summary>
    /// SubcoreSkills class to load up the mod and initialise everything.
    /// </summary>
    public class SubcoreSkills : Mod
    {
        /// <summary>
        /// SubcoreSkills settings reference.
        /// </summary>
        internal static SubcoreSkillsSettings settings;

        /// <summary>
        /// SubcoreSkills constructor to load the mod and settings.
        /// </summary>
        /// <param name="content"></param>
        public SubcoreSkills(ModContentPack content) : base(content) {
            settings = GetSettings<SubcoreSkillsSettings>();
        }

        /// <summary>
        /// DoSettingsWindowContents configures the settings window.
        /// </summary>
        /// <param name="inRect"></param>
        public override void DoSettingsWindowContents(Rect inRect)
        {
            base.DoSettingsWindowContents(inRect);
        }

        /// <summary>
        /// SettingsCategory returns the name of the settings category.
        /// </summary>
        /// <returns></returns>
        public override string SettingsCategory() => "SubcoreSkills".Translate();
    }
}
