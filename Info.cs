using Terraria.ModLoader;

namespace MoreInfo
{
    internal abstract class Info : ModType
	{
		/// <summary>
		/// This is the internal ID of this Info.
		/// </summary>
		public int Type { get; internal set; }

		/// <summary>
		/// This is the X draw offset of the stat of the Info.
		/// </summary>
		public int StatOffsetX = 160;

		public sealed override void SetupContent() => SetStaticDefaults();

		public abstract string GetStat();

		public virtual bool IsVisible() { return false; }
	}
}
