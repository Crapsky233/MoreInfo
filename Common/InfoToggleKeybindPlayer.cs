using Terraria.Audio;
using Terraria.GameInput;
using Terraria.ModLoader.Config;

namespace MoreInfo.Common
{
    internal class InfoToggleKeybindPlayer : ModPlayer
	{
		public override void ProcessTriggers(TriggersSet triggersSet) {
			if (MoreInfo.InfoToggleHotkey.JustPressed) {
				SoundEngine.PlaySound(SoundID.MenuTick);
				InfoLoader.GenericConfiguration.InfoVisible = !InfoLoader.GenericConfiguration.InfoVisible;
				MethodInfo saveMethodInfo = typeof(ConfigManager).GetMethod("Save", BindingFlags.Static | BindingFlags.NonPublic);
				if (saveMethodInfo != null)
					saveMethodInfo.Invoke(null, new object[] { InfoLoader.GenericConfiguration });
				else
					MoreInfo.instance.Logger.Warn("In-game SaveConfig failed, code update required. Please report the bug to the author on Steam Workshop.");
			}
		}
	}
}
