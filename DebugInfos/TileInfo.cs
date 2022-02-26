namespace MoreInfo.DebugInfos
{
    internal abstract class TileInfo : DebugInfo
    {
        internal static Tile Tile => Framing.GetTileSafely(InfoLoader.MouseWorldZoomed.ToTileCoordinates());

        public override void Load() {
            base.Load();
            StatOffsetX = 240;
        }

        public override bool IsVisible() {
            return InfoLoader.DebugConfiguration.TileInfoAlways || Tile.HasTile;
        }
    }

    internal class TileSolid : TileInfo
    {
        public override string GetStat() {
            return InfoLoader.CorrectOrNot(Main.tileSolid[Tile.TileType]);
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.TileSolid;
        }
    }

    internal class TileSolidTop : TileInfo
    {
        public override string GetStat() {
            return InfoLoader.CorrectOrNot(Main.tileSolidTop[Tile.TileType]);
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.TileSolidTop;
        }
    }

    internal class TileHalfBlock : TileInfo
    {
        public override string GetStat() {
            return InfoLoader.CorrectOrNot(Tile.IsHalfBlock);
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.TileHalfBlock;
        }
    }

    internal class TileSlope : TileInfo
    {
        public override string GetStat() {
            Tile t = Tile;
            return $"{t.Slope}({(int)t.Slope})";
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.TileSlope;
        }
    }

    internal class TileFrameX : TileInfo
    {
        public override string GetStat() {
            return Tile.TileFrameX.ToString();
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.TileFrameX;
        }
    }

    internal class TileFrameY : TileInfo
    {
        public override string GetStat() {
            return Tile.TileFrameY.ToString();
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.TileFrameY;
        }
    }

    internal class TileColor : TileInfo
    {
        public override string GetStat() {
            return Tile.TileColor.ToString();
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.TileColor;
        }
    }

    internal class TileIsActuated : TileInfo
    {
        public override string GetStat() {
            return $"{InfoLoader.CorrectOrNot(Tile.IsActuated)} (IsActuated=inActive)";
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.TileIsActuated;
        }
    }

    internal class TileActive : TileInfo
    {
        public override string GetStat() {
            return InfoLoader.CorrectOrNot(Tile.HasTile);
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.TileActive;
        }
    }

    internal class TileType : TileInfo
    {
        public override string GetStat() {
            return Tile.TileType.ToString();
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.TileType;
        }
    }

    internal class TileModName : TileInfo
    {
        public override string GetStat() {
            return TileLoader.GetTile(Tile.TileType).Mod.Name;
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.TileModName && TileLoader.GetTile(Tile.TileType) != null;
        }
    }

    internal class TileFullName : TileInfo
    {
        public override string GetStat() {
            return TileLoader.GetTile(Tile.TileType).FullName;
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.TileFullName && TileLoader.GetTile(Tile.TileType) != null;
        }
    }

    internal class TileMinPick : TileInfo
    {
        public override string GetStat() {
            return TileLoader.GetTile(Tile.TileType).MinPick.ToString();
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.TileMinPick && TileLoader.GetTile(Tile.TileType) != null;
        }
    }
}
