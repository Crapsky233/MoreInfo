using Terraria.UI;

namespace MoreInfo
{
    internal class InfoSystem : ModSystem
	{
        public override void Load() {
            base.Load();
            On.Terraria.Player.RecalculateLuck += Player_RecalculateLuck;
        }

        private void Player_RecalculateLuck(On.Terraria.Player.orig_RecalculateLuck orig, Player self) {
            orig.Invoke(self);
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers) {
			int mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
			if (mouseTextIndex != -1) {
				int y = 236;
				layers.Insert(mouseTextIndex,
				new LegacyGameInterfaceLayer("MoreInfo: Generic Info", delegate {
					if (InfoLoader.GenericConfiguration.InfoVisible) {
						DrawInterface_GenericInfo(out y);
					}
					return true;
				}, InterfaceScaleType.UI));

				layers.Insert(++mouseTextIndex,
				new LegacyGameInterfaceLayer("MoreInfo: Debug Info", delegate {
					if (InfoLoader.GenericConfiguration.InfoVisible) {
						DrawInterface_DebugInfo(y);
					}
					return true;
				}, InterfaceScaleType.UI));
			}
		}

		private void DrawInterface_GenericInfo(out int lastY) {
			int baseX = Main.playerInventory ? 590 : 20;
			lastY = Main.playerInventory ? 9 : 220;
			for (int j = 0; j < InfoLoader.GenericInfoCount; j++) {
				if (!InfoLoader.GenericInfos[j].IsVisible())
					continue;

				string name = Language.GetTextValue($"Mods.{Mod.Name}.GenericInfoName.{InfoLoader.GenericInfos[j].Name}") + ':';
				string stat = InfoLoader.GenericInfos[j].GetStat();

				lastY += 18;

				Utils.DrawBorderStringFourWay(Main.spriteBatch, FontAssets.MouseText.Value, name, baseX, lastY, Color.White, Color.Black * 0.36f, default(Vector2), 1f);
				Utils.DrawBorderStringFourWay(Main.spriteBatch, FontAssets.MouseText.Value, stat, baseX + InfoLoader.GenericInfos[j].StatOffsetX, lastY, Color.White, Color.Black * 0.36f, default(Vector2), 1f);
			}
		}

		private void DrawInterface_DebugInfo(int startY) {
			int baseX = Main.playerInventory ? 590 : 20;
			int y = startY + 18;
			for (int j = 0; j < InfoLoader.DebugInfoCount; j++) {
				if (!InfoLoader.DebugInfos[j].IsVisible())
					continue;

				string name = Language.GetTextValue($"Mods.{Mod.Name}.DebugInfoName.{InfoLoader.DebugInfos[j].Name}") + ':';
				string stat = InfoLoader.DebugInfos[j].GetStat();

				y += 18;

				Utils.DrawBorderStringFourWay(Main.spriteBatch, FontAssets.MouseText.Value, name, baseX, y, Color.White, Color.Black * 0.36f, default(Vector2), 1f);
				Utils.DrawBorderStringFourWay(Main.spriteBatch, FontAssets.MouseText.Value, stat, baseX + InfoLoader.DebugInfos[j].StatOffsetX, y, Color.White, Color.Black * 0.36f, default(Vector2), 1f);
			}
		}
	}
}
