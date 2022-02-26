namespace MoreInfo.DebugInfos
{
    internal abstract class WallInfo : DebugInfo
    {
        internal static Tile Tile => Framing.GetTileSafely(InfoLoader.MouseWorldZoomed.ToTileCoordinates());

        public override void Load() {
            base.Load();
            StatOffsetX = 280;
        }

        public override bool IsVisible() {
            return InfoLoader.DebugConfiguration.WallInfoAlways || Tile.WallType != 0;
        }
    }

    internal class WallType : WallInfo
    {
        public override string GetStat() {
            return Tile.WallType.ToString();
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.WallType;
        }
    }

    internal class WallColor : WallInfo
    {
        public override string GetStat() {
            return Tile.WallColor.ToString();
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.WallColor;
        }
    }

    internal class WallFrameNumber : WallInfo
    {
        public override string GetStat() {
            return Tile.WallFrameNumber.ToString();
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.WallFrameNumber;
        }
    }

    internal class WallFrameX : WallInfo
    {
        public override string GetStat() {
            return Tile.WallFrameX.ToString();
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.WallFrameX;
        }
    }

    internal class WallFrameY : WallInfo
    {
        public override string GetStat() {
            return Tile.WallFrameY.ToString();
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.WallFrameY;
        }
    }
}
