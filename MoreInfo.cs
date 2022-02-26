global using Microsoft.Xna.Framework;
global using Microsoft.Xna.Framework.Graphics;
global using System;
global using System.Collections;
global using System.Collections.Generic;
global using System.Linq;
global using System.Reflection;
global using Terraria;
global using Terraria.GameContent;
global using Terraria.ID;
global using Terraria.Localization;
global using Terraria.ModLoader;
global using Terraria.UI.Chat;

namespace MoreInfo
{
    public class MoreInfo : Mod
	{
		public static ModKeybind InfoToggleHotkey;
		internal static MoreInfo instance;

		public override void Load() {
			instance = this;
			InfoToggleHotkey = KeybindLoader.RegisterKeybind(this, "Toggle Info", "F6");
		}

		public override void Unload() {
			InfoToggleHotkey = null;
			instance = null;
		}
	}
}