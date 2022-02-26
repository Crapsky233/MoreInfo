namespace MoreInfo.DebugInfos
{
    internal class MousePositionWorld : DebugInfo
    {
        public override void Load() => StatOffsetX = 240;

        public override bool IsVisible() => InfoLoader.DebugConfiguration.MousePositionWorld;

        public override string GetStat() => InfoLoader.MouseWorldZoomed.ToString();
    }

    internal class MousePositionTile : DebugInfo
    {
        public override void Load() => StatOffsetX = 240;

        public override bool IsVisible() => InfoLoader.DebugConfiguration.MousePositionTile;

        public override string GetStat() => InfoLoader.MouseWorldZoomed.ToTileCoordinates().ToString();
    }
}
