namespace MoreInfo.Common
{
    internal class TooltipModifyGlobalItem : GlobalItem
    {
        private static List<string> _favouriteRemovedName = new List<string>() { "Favorite", "FavoriteDesc" };

        public override void Load() {
            base.Load();
            On.Terraria.Main.MouseText_DrawItemTooltip_GetLinesInfo += Main_MouseText_DrawItemTooltip_GetLinesInfo;
        }

        public override void Unload() {
            base.Unload();
            On.Terraria.Main.MouseText_DrawItemTooltip_GetLinesInfo -= Main_MouseText_DrawItemTooltip_GetLinesInfo;
        }

        private void Main_MouseText_DrawItemTooltip_GetLinesInfo(On.Terraria.Main.orig_MouseText_DrawItemTooltip_GetLinesInfo orig, Item item, ref int yoyoLogo, ref int researchLine, float oldKB, ref int numLines, string[] toolTipLine, bool[] preFixLine, bool[] badPreFixLine, string[] toolTipNames) {
            if (InfoLoader.DebugConfiguration.ItemSocialTooltip && item.social) {
                item.social = false;
                orig.Invoke(item, ref yoyoLogo, ref researchLine, oldKB, ref numLines, toolTipLine, preFixLine, badPreFixLine, toolTipNames);
                item.social = true;
                return;
            }
            orig.Invoke(item, ref yoyoLogo, ref researchLine, oldKB, ref numLines, toolTipLine, preFixLine, badPreFixLine, toolTipNames);
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
            base.ModifyTooltips(item, tooltips);

            for (int i = 0; i < tooltips.Count; i++) {
                TooltipLine t = tooltips[i];
                if (!InfoLoader.DebugConfiguration.ItemFavouriteTooltip && _favouriteRemovedName.Contains(t.Name)) {
                    tooltips.RemoveAt(i);
                    i--;
                    continue;
                }
                if (InfoLoader.DebugConfiguration.ItemUseTime && t.Name == "Speed") t.text += $" useTime: {item.useTime}";
                if (InfoLoader.DebugConfiguration.ItemUseTime && t.Name == "Knockback") t.text += $" knockback: {item.knockBack}";
                if (InfoLoader.DebugConfiguration.ItemTooltipNames) t.text += $"  [c/666666:({t.Name})]";
                if (InfoLoader.DebugConfiguration.ItemTooltipMods) t.text += $"  [c/666666:({t.mod})]";

            }
        }
    }
}
