namespace MoreInfo.DebugInfos
{
    internal abstract class PlayerInfo : DebugInfo
    {
        internal Player Player { get; private set; }

        public override void Load() {
            base.Load();
            StatOffsetX = 240;
        }

        public override bool IsVisible() {
			Player = Main.LocalPlayer;

            Rectangle rectangle = new Rectangle((int)InfoLoader.MouseWorldZoomed.X, (int)InfoLoader.MouseWorldZoomed.Y, 1, 1);
            for (int j = 0; j < 255; j++) {
				if (!Main.player[j].active || Main.myPlayer == j || Main.player[j].dead || Main.player[j].ShouldNotDraw || !(Main.player[j].stealth > 0.5))
					continue;

                if (rectangle.Intersects(Main.player[j].getRect())) {
                    Player = Main.player[j];
				}
			}

			return Player != null;
        }
    }

    internal class PlayerChestIndex : PlayerInfo
    {
        public override string GetStat() => Player.chest.ToString();
        public override bool IsVisible() => base.IsVisible() && InfoLoader.DebugConfiguration.PlayerChestIndex;
    }
    internal class PlayerPositionWorld : PlayerInfo
    {
        public override string GetStat() => Player.position.ToString();
        public override bool IsVisible() => base.IsVisible() && InfoLoader.DebugConfiguration.PlayerPositionWorld;
    }
    internal class PlayerPositionTile : PlayerInfo
    {
        public override string GetStat() => Player.position.ToTileCoordinates().ToString();
        public override bool IsVisible() => base.IsVisible() && InfoLoader.DebugConfiguration.PlayerPositionTile;
    }
    internal class PlayerCenterWorld : PlayerInfo
    {
        public override string GetStat() => Player.Center.ToString();
        public override bool IsVisible() => base.IsVisible() && InfoLoader.DebugConfiguration.PlayerCenterWorld;
    }
    internal class PlayerCenterTile : PlayerInfo
    {
        public override string GetStat() => Player.Center.ToTileCoordinates().ToString();
        public override bool IsVisible() => base.IsVisible() && InfoLoader.DebugConfiguration.PlayerCenterTile;
    }

}
