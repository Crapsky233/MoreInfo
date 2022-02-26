namespace MoreInfo.DebugInfos
{
    internal abstract class ItemInfo : DebugInfo
    {
        public override void Load() => StatOffsetX = 240;

        public override bool IsVisible() => Main.HoverItem.active && Main.HoverItem.type != ItemID.None;
    }

    internal class ItemType : ItemInfo
    {
        public override string GetStat() => Main.HoverItem.type.ToString();

        public override bool IsVisible() => base.IsVisible() && InfoLoader.DebugConfiguration.ItemType;
    }

    internal class ItemAnimationTime : ItemInfo
    {
        public override string GetStat() {
            return Main.HoverItem.useAnimation.ToString();
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.ItemAnimationTime && Main.HoverItem.useTime > 0;
        }
    }

    internal class ItemUseStyle : ItemInfo
    {
        public override string GetStat() {
            return Main.HoverItem.useStyle.ToString();
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.ItemUseStyle && Main.HoverItem.useTime > 0;
        }
    }

    internal class ItemShoot : ItemInfo
    {
        public override string GetStat() {
            var p = new Projectile();
            p.SetDefaults(Main.HoverItem.shoot);
            return $"{Main.HoverItem.shoot} ({p.Name})";
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.ItemShoot && Main.HoverItem.shoot != ProjectileID.None;
        }
    }

    internal class ItemShootSpeed : ItemInfo
    {
        public override string GetStat() {
            return $"{Main.HoverItem.shootSpeed} ({Math.Round(Main.HoverItem.shootSpeed * (216000f / 42240f))}mph)";
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.ItemShootSpeed && Main.HoverItem.shoot != ProjectileID.None;
        }
    }

    internal class ItemSize : ItemInfo
    {
        public override string GetStat() {
            return $"{Main.HoverItem.width}×{Main.HoverItem.height}";
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.ItemSize;
        }
    }

    internal class ItemMaxStack : ItemInfo
    {
        public override string GetStat() {
            return Main.HoverItem.maxStack.ToString();
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.ItemMaxStack;
        }
    }

    internal class ItemMod : ItemInfo
    {
        public override string GetStat() {
            return ItemLoader.GetItem(Main.HoverItem.type).Mod.Name;
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.ItemMod && ItemLoader.GetItem(Main.HoverItem.type) != null;
        }
    }

    internal class ItemFullName : ItemInfo
    {
        public override string GetStat() {
            return ItemLoader.GetItem(Main.HoverItem.type).FullName;
        }

        public override bool IsVisible() {
            return base.IsVisible() && InfoLoader.DebugConfiguration.ItemFullName && ItemLoader.GetItem(Main.HoverItem.type) != null;
        }
    }
}
