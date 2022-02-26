using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace MoreInfo
{
    [Label("$Mods.MoreInfo.Configs.Title.GenericConfiguration")]
    public class AGenericConfiguration : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
        public override void OnLoaded() => InfoLoader.GenericConfiguration = this;

        [DefaultValue(true)]
        [Label("$Mods.MoreInfo.Configs.Label.Generic.InfoVisible")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Generic.InfoVisible")]
        public bool InfoVisible { get; set; }

        #region Chest Info
        [Header("$Mods.MoreInfo.Configs.Header.ChestInfo")]

        [DefaultValue(true)]
        [Label("$Mods.MoreInfo.GenericInfoName.ChestNameDisplay")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Generic.ChestNameDisplay")]
        public bool ChestNameDisplay { get; set; }

        [Range(-18, 18)]
        [Slider]
        [DefaultValue(4)]
        [Label("$Mods.MoreInfo.GenericInfoName.ChestNameYOffset")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Generic.ChestNameYOffset")]
        public int ChestNameYOffset { get; set; }

        [Range(.1f, 2f)]
        [DefaultValue(1f)]
        [Label("$Mods.MoreInfo.GenericInfoName.ChestNameSize")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Generic.ChestNameSize")]
        public float ChestNameSize { get; set; }

        [DefaultValue(true)]
        [Label("$Mods.MoreInfo.GenericInfoName.ChestSpaceDisplay")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Generic.ChestSpaceDisplay")]
        public bool ChestSpaceDisplay { get; set; }
        #endregion

        #region Biome Info
        [Header("$Mods.MoreInfo.Configs.Header.BiomeInfo")]

        [DefaultValue(true)]
        [Label("$Mods.MoreInfo.GenericInfoName.BiomeBasicInfo")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Generic.BiomeBasicInfo")]
        public bool BiomeBasicInfo { get; set; }

        [DefaultValue(true)]
        [Label("$Mods.MoreInfo.GenericInfoName.BiomeMixedInfo")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Generic.BiomeMixedInfo")]
        public bool BiomeMixedInfo { get; set; }

        [DefaultValue(true)]
        [Label("$Mods.MoreInfo.GenericInfoName.BiomeModdedInfo")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Generic.BiomeModdedInfo")]
        public bool BiomeModdedInfo { get; set; }
        #endregion

        #region Luck Info
        [Header("$Mods.MoreInfo.Configs.Header.LuckInfo")]

        [DefaultValue(true)]
        [Label("$Mods.MoreInfo.GenericInfoName.TotalLuck")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Generic.TotalLuck")]
        public bool TotalLuck { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.GenericInfoName.TorchLuck")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Generic.TorchLuck")]
        public bool TorchLuck { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.GenericInfoName.LadybugLuck")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Generic.LadybugLuck")]
        public bool LadybugLuck { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.GenericInfoName.PotionLuck")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Generic.PotionLuck")]
        public bool PotionLuck { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.GenericInfoName.GnomeNearby")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Generic.GnomeNearby")]
        public bool GnomeNearby { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.GenericInfoName.LanternsUp")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Generic.LanternsUp")]
        public bool LanternsUp { get; set; }
        #endregion
    }

    [Label("$Mods.MoreInfo.Configs.Title.DebugConfiguration")]
    public class DebugConfiguration : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
        public override void OnLoaded() => InfoLoader.DebugConfiguration = this;

        #region Mouse Info
        [Header("$Mods.MoreInfo.Configs.Header.MouseInfo")]

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.MousePositionWorld")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.MousePositionWorld")]
        public bool MousePositionWorld { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.MousePositionTile")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.MousePositionTile")]
        public bool MousePositionTile { get; set; }
        #endregion

        #region Player Info
        [Header("$Mods.MoreInfo.Configs.Header.PlayerInfo")]

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.PlayerPositionWorld")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.PlayerPositionWorld")]
        public bool PlayerPositionWorld { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.PlayerPositionTile")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.PlayerPositionTile")]
        public bool PlayerPositionTile { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.PlayerCenterWorld")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.PlayerCenterWorld")]
        public bool PlayerCenterWorld { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.PlayerCenterTile")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.PlayerCenterTile")]
        public bool PlayerCenterTile { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.PlayerChestIndex")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.PlayerChestIndex")]
        public bool PlayerChestIndex { get; set; }
        #endregion

        #region Item Info
        [Header("$Mods.MoreInfo.Configs.Header.ItemInfo")]

        [DefaultValue(true)]
        [Label("$Mods.MoreInfo.DebugInfoName.ItemType")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.ItemType")]
        public bool ItemType { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.ItemUseTime")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.ItemUseTime")]
        public bool ItemUseTime { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.ItemAnimationTime")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.ItemAnimationTime")]
        public bool ItemAnimationTime { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.ItemShootSpeed")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.ItemShootSpeed")]
        public bool ItemKnockback { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.ItemUseStyle")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.ItemUseStyle")]
        public bool ItemUseStyle { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.ItemShoot")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.ItemShoot")]
        public bool ItemShoot { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.ItemShootSpeed")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.ItemShootSpeed")]
        public bool ItemShootSpeed { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.ItemSize")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.ItemSize")]
        public bool ItemSize { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.ItemMaxStack")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.ItemMaxStack")]
        public bool ItemMaxStack { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.ItemMod")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.ItemMod")]
        public bool ItemMod { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.ItemFullName")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.ItemFullName")]
        public bool ItemFullName { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.ItemTooltipNames")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.ItemTooltipNames")]
        public bool ItemTooltipNames { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.ItemTooltipMods")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.ItemTooltipMods")]
        public bool ItemTooltipMods { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.ItemFavouriteTooltip")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.ItemFavouriteTooltip")]
        public bool ItemFavouriteTooltip { get; set; }

        [DefaultValue(true)]
        [Label("$Mods.MoreInfo.DebugInfoName.ItemSocialTooltip")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.ItemSocialTooltip")]
        public bool ItemSocialTooltip { get; set; }
        #endregion

        #region Tile Info
        [Header("$Mods.MoreInfo.Configs.Header.TileInfo")]

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.Configs.Label.Debug.TileInfoAlways")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.TileInfoAlways")]
        public bool TileInfoAlways { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.TileSolid")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.TileSolid")]
        public bool TileSolid { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.TileSolidTop")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.TileSolidTop")]
        public bool TileSolidTop { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.TileHalfBlock")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.TileHalfBlock")]
        public bool TileHalfBlock { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.TileSlope")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.TileSlope")]
        public bool TileSlope { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.TileFrameX")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.TileFrameX")]
        public bool TileFrameX { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.TileFrameY")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.TileFrameY")]
        public bool TileFrameY { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.TileColor")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.TileColor")]
        public bool TileColor { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.TileIsActuated")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.TileIsActuated")]
        public bool TileIsActuated { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.TileActive")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.TileActive")]
        public bool TileActive { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.TileType")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.TileType")]
        public bool TileType { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.TileModName")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.TileModName")]
        public bool TileModName { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.TileFullName")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.TileFullName")]
        public bool TileFullName { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.TileMinPick")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.TileMinPick")]
        public bool TileMinPick { get; set; }
        #endregion

        #region Wall Info
        [Header("$Mods.MoreInfo.Configs.Header.WallInfo")]

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.Configs.Label.Debug.WallInfoAlways")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.WallInfoAlways")]
        public bool WallInfoAlways { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.WallType")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.WallType")]
        public bool WallType { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.WallColor")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.WallColor")]
        public bool WallColor { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.WallFrameNumber")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.WallFrameNumber")]
        public bool WallFrameNumber { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.WallFrameX")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.WallFrameX")]
        public bool WallFrameX { get; set; }

        [DefaultValue(false)]
        [Label("$Mods.MoreInfo.DebugInfoName.WallFrameY")]
        [Tooltip("$Mods.MoreInfo.Configs.Tooltip.Debug.WallFrameY")]
        public bool WallFrameY { get; set; }
        #endregion
    }
}
