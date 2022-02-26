using MoreInfo.Common;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.Localization;

namespace MoreInfo.GenericInfos
{
    internal class LanternsUp : GenericInfo
    {
        public override string GetStat() {
            var dayTime = "(It's daytime now!)";
            if (GameCulture.FromCultureName(GameCulture.CultureName.Chinese).IsActive)
                dayTime = "(现在是白天!)";
            return $"{InfoLoader.CorrectOrNot(LanternNight.LanternsUp)} {(Main.dayTime ? dayTime : "")}";
        }

        public override bool IsVisible() {
            return InfoLoader.GenericConfiguration.LanternsUp;
        }
    }

    internal class GnomeNearby : GenericInfo
    {
        public override string GetStat() {
            return InfoLoader.CorrectOrNot(Main.LocalPlayer.HasGardenGnomeNearby);
        }

        public override bool IsVisible() {
            return InfoLoader.GenericConfiguration.GnomeNearby;
        }
    }

    internal class PotionLuck : GenericInfo
    {
        public override string GetStat() {
            return ((float)(int)Main.LocalPlayer.luckPotion * 0.1f).ToString();
        }

        public override bool IsVisible() {
            return InfoLoader.GenericConfiguration.PotionLuck;
        }
    }

    internal class LadybugLuck : GenericInfo
    {
        public override string GetStat() {
            return ((float)GetLadyBugLuck() * 0.2f).ToString();
        }

        private float GetLadyBugLuck() {
            if (Main.LocalPlayer.ladyBugLuckTimeLeft > 0)
                return (float)Main.LocalPlayer.ladyBugLuckTimeLeft / (float)NPC.ladyBugGoodLuckTime;

            if (Main.LocalPlayer.ladyBugLuckTimeLeft < 0)
                return (0f - (float)Main.LocalPlayer.ladyBugLuckTimeLeft) / (float)NPC.ladyBugBadLuckTime;

            return 0f;
        }

        public override bool IsVisible() {
            return InfoLoader.GenericConfiguration.LadybugLuck;
        }
    }

    internal class TorchLuck : GenericInfo
    {
        public override string GetStat() {
            return ((float)(int)Main.LocalPlayer.torchLuck * 0.2f).ToString();
        }

        public override bool IsVisible() {
            return InfoLoader.GenericConfiguration.TorchLuck;
        }
    }

    internal class TotalLuck : GenericInfo
    {
        public override string GetStat() {
            return Main.LocalPlayer.luck.ToString();
        }

        public override bool IsVisible() {
            return InfoLoader.GenericConfiguration.TotalLuck;
        }
    }
}
