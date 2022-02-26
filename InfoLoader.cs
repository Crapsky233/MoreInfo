using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameInput;

namespace MoreInfo
{
    internal class InfoLoader
	{
		internal static AGenericConfiguration GenericConfiguration;
		internal static DebugConfiguration DebugConfiguration;

		public static int GenericInfoCount => GenericInfos.Count;
		internal static readonly List<Info> GenericInfos = new List<Info>();

		public static int DebugInfoCount => DebugInfos.Count;
		internal static readonly List<Info> DebugInfos = new List<Info>();

		internal static int AddGeneric(Info info) {
			GenericInfos.Add(info);
			return GenericInfos.Count - 1;
		}

		internal static int AddDebug(Info info) {
			DebugInfos.Add(info);
			return DebugInfos.Count - 1;
		}

		internal static void Unload() {
			GenericInfos.Clear();
			DebugInfos.Clear();
		}

		internal static string CorrectOrNot(bool flag) {
			if (flag) {
				return "✓";
			} else {
				return "×";
			}
		}

		/// <summary>
		/// 已经过游戏缩进后的MouseWorld，代码来自1.4.3.2原版
		/// </summary>
		internal static Vector2 MouseWorldZoomed {
            get {
				Vector2 vector = Main.screenPosition + new Vector2(Main.screenWidth, Main.screenHeight) / 2f;
				Vector2 value = Main.screenPosition + new Vector2(PlayerInput.MouseX, PlayerInput.MouseY);
				Vector2 value5 = value - vector;
				float scaleFactor = 1f / Main.GameViewMatrix.Zoom.X;
				Vector2 vector2 = vector + value5 * scaleFactor;
				return vector2;
			}
		}
	}
}
