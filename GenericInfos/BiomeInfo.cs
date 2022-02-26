

namespace MoreInfo.GenericInfos
{
    internal class BiomeBasicInfo : GenericInfo
    {
        internal static void MixBiome(ref string originalStr, string biome) {
            if (originalStr != Language.GetTextValue($"Mods.MoreInfo.None")) {
                originalStr += $", {biome}";
                return;
            }
            originalStr = biome;
        }

        public override string GetStat() {
            var p = Main.LocalPlayer;

            var biomeForest = Language.GetTextValue("TownNPCMoodBiomes.Forest");
            var biomeCorrupt = Language.GetTextValue("Bestiary_Biomes.TheCorruption");
            var biomeCrimson = Language.GetTextValue($"Bestiary_Biomes.Crimson");
            var biomeSnow = Language.GetTextValue("Bestiary_Biomes.Snow");
            var biomeDesert = Language.GetTextValue("Bestiary_Biomes.Desert");
            var biomeBeach = Language.GetTextValue("Bestiary_Biomes.Ocean");
            var biomeDungeon = Language.GetTextValue("Bestiary_Biomes.TheDungeon");
            var biomeJungle = Language.GetTextValue("Bestiary_Biomes.Jungle");
            var biomeHallow = Language.GetTextValue("Bestiary_Biomes.TheHallow");
            var biomeGlowshroom = Language.GetTextValue($"Mods.{Mod.Name}.Biome.Glowshroom");
            var biomeSolar = Language.GetTextValue("Bestiary_Biomes.SolarPillar");
            var biomeVortex = Language.GetTextValue("Bestiary_Biomes.VortexPillar");
            var biomeNebula = Language.GetTextValue("Bestiary_Biomes.NebulaPillar");
            var biomeStardust = Language.GetTextValue("Bestiary_Biomes.StardustPillar");
            var heightSky = Language.GetTextValue("GameUI.LayerSpace");
            var heightOverworld = Language.GetTextValue("GameUI.LayerSurface");
            var heightDirtLayer = Language.GetTextValue("GameUI.LayerUnderground");
            var heightRockLayer = Language.GetTextValue("GameUI.LayerCaverns");
            var heightUnderworld = Language.GetTextValue("GameUI.LayerUnderworld");
            var eventRain = Language.GetTextValue("Bestiary_Events.Rain");
            var eventSandstorm = Language.GetTextValue("Bestiary_Events.Sandstorm");
            var eventOldOneArmy = Language.GetTextValue("Bestiary_Invasions.OldOnesArmy");
            var minibiomeMeteor = Language.GetTextValue("Bestiary_Biomes.Meteor");
            var minibiomeGranite = Language.GetTextValue("Bestiary_Biomes.Granite");
            var minibiomeMarble = Language.GetTextValue("Bestiary_Biomes.Marble");
            var minibiomeHive = Language.GetTextValue("MapObject.BeeHive");
            var minibiomeGemCave = Language.GetTextValue($"Mods.{Mod.Name}.Minibiome.GemCave");
            var minibiomeLihzhardTemple = Language.GetTextValue("Bestiary_Biomes.TheTemple");
            var minibiomeGraveyard = Language.GetTextValue("Bestiary_Biomes.Graveyard");

            var biomeMixed = Language.GetTextValue($"Mods.{Mod.Name}.None");
            if (p.ZoneCorrupt) biomeMixed = biomeCorrupt;
            if (p.ZoneCrimson) MixBiome(ref biomeMixed, biomeCrimson);
            if (p.ZoneSnow) MixBiome(ref biomeMixed, biomeSnow);
            if (p.ZoneDesert) MixBiome(ref biomeMixed, biomeDesert);
            if (p.ZoneBeach) MixBiome(ref biomeMixed, biomeBeach);
            if (p.ZoneJungle) MixBiome(ref biomeMixed, biomeJungle);
            if (p.ZoneDungeon) MixBiome(ref biomeMixed, biomeDungeon);
            if (p.ZoneHallow) MixBiome(ref biomeMixed, biomeHallow);
            if (p.ZoneGlowshroom) MixBiome(ref biomeMixed, biomeGlowshroom);
            if (p.ZoneTowerSolar) MixBiome(ref biomeMixed, biomeSolar);
            if (p.ZoneTowerVortex) MixBiome(ref biomeMixed, biomeVortex);
            if (p.ZoneTowerNebula) MixBiome(ref biomeMixed, biomeNebula);
            if (p.ZoneTowerStardust) MixBiome(ref biomeMixed, biomeStardust);
            if (p.ZoneForest) MixBiome(ref biomeMixed, biomeForest);
            if (p.ZoneSkyHeight) MixBiome(ref biomeMixed, heightSky);
            if (p.ZoneOverworldHeight) MixBiome(ref biomeMixed, heightOverworld);
            if (p.ZoneDirtLayerHeight) MixBiome(ref biomeMixed, heightDirtLayer);
            if (p.ZoneRockLayerHeight) MixBiome(ref biomeMixed, heightRockLayer);
            if (p.ZoneUnderworldHeight) MixBiome(ref biomeMixed, heightUnderworld);
            if (p.ZoneRain) MixBiome(ref biomeMixed, eventRain);
            if (p.ZoneSandstorm) MixBiome(ref biomeMixed, eventSandstorm);
            if (p.ZoneOldOneArmy) MixBiome(ref biomeMixed, eventOldOneArmy);
            if (p.ZoneMeteor) MixBiome(ref biomeMixed, minibiomeMeteor);
            if (p.ZoneGranite) MixBiome(ref biomeMixed, minibiomeGranite);
            if (p.ZoneMarble) MixBiome(ref biomeMixed, minibiomeMarble);
            if (p.ZoneHive) MixBiome(ref biomeMixed, minibiomeHive);
            if (p.ZoneGemCave) MixBiome(ref biomeMixed, minibiomeGemCave);
            if (p.ZoneLihzhardTemple) MixBiome(ref biomeMixed, minibiomeLihzhardTemple);
            if (p.ZoneGraveyard) MixBiome(ref biomeMixed, minibiomeGraveyard);

            return biomeMixed;
        }

        public override bool IsVisible() {
            return InfoLoader.GenericConfiguration.BiomeBasicInfo;
        }
    }

    internal class BiomeMixedInfo : GenericInfo
    {
        public override string GetStat() {
            var p = Main.LocalPlayer;

            var biomeCorruptUndergroundDesert = Language.GetTextValue("Bestiary_Biomes.CorruptUndergroundDesert");
            var biomeCrimsonUndergroundDesert = Language.GetTextValue("Bestiary_Biomes.CrimsonUndergroundDesert");
            var biomeHallowUndergroundDesert = Language.GetTextValue("Bestiary_Biomes.HallowUndergroundDesert");
            var biomeUndergroundDesert = Language.GetTextValue("Bestiary_Biomes.UndergroundDesert");
            var biomeUndergroundCorruption = Language.GetTextValue("Bestiary_Biomes.UndergroundCorruption");
            var biomeUndergroundCrimson = Language.GetTextValue("Bestiary_Biomes.UndergroundCrimson");
            var biomeUndergroundHallow = Language.GetTextValue("Bestiary_Biomes.UndergroundHallow");
            var biomeUndergroundJungle = Language.GetTextValue("Bestiary_Biomes.UndergroundJungle");
            var biomeUndergroundMushroom = Language.GetTextValue("Bestiary_Biomes.UndergroundMushroom");
            var biomeUndergroundSnow = Language.GetTextValue("Bestiary_Biomes.UndergroundSnow");
            var biomeCorruptIce = Language.GetTextValue("Bestiary_Biomes.CorruptIce");
            var biomeCrimsonIce = Language.GetTextValue("Bestiary_Biomes.CrimsonIce");
            var biomeHallowIce = Language.GetTextValue("Bestiary_Biomes.HallowIce");
            var biomeSurfaceMushroom = Language.GetTextValue("Bestiary_Biomes.SurfaceMushroom");
            var biomeCorruptDesert = Language.GetTextValue("Bestiary_Biomes.CorruptDesert");
            var biomeCrimsonDesert = Language.GetTextValue("Bestiary_Biomes.CrimsonDesert");
            var biomeHallowDesert = Language.GetTextValue("Bestiary_Biomes.HallowDesert");

            var biomeMixed = Language.GetTextValue($"Mods.{Mod.Name}.None");
            if (p.ZonePurity) return biomeMixed;

            if (p.ZoneUndergroundDesert) {
                bool normal = true;
                if (p.ZoneCorrupt) { biomeMixed = biomeCorruptUndergroundDesert; normal = false; }
                if (p.ZoneCrimson) { BiomeBasicInfo.MixBiome(ref biomeMixed, biomeCrimsonUndergroundDesert); normal = false; }
                if (p.ZoneHallow) { BiomeBasicInfo.MixBiome(ref biomeMixed, biomeHallowUndergroundDesert); normal = false; }
                if (normal) biomeMixed = biomeUndergroundDesert;
            }
            if (Main.LocalPlayer.position.Y >= Main.worldSurface * 16.0) {
                if (p.ZoneCorrupt) BiomeBasicInfo.MixBiome(ref biomeMixed, biomeUndergroundCorruption);
                if (p.ZoneCrimson) BiomeBasicInfo.MixBiome(ref biomeMixed, biomeUndergroundCrimson);
                if (p.ZoneHallow) BiomeBasicInfo.MixBiome(ref biomeMixed, biomeUndergroundHallow);
                if (p.ZoneJungle) BiomeBasicInfo.MixBiome(ref biomeMixed, biomeUndergroundJungle);
                if (p.ZoneGlowshroom) BiomeBasicInfo.MixBiome(ref biomeMixed, biomeUndergroundMushroom);
                if (p.ZoneSnow) {
                    bool normal = true;
                    if (p.ZoneCorrupt) { BiomeBasicInfo.MixBiome(ref biomeMixed, biomeCorruptIce); normal = false; }
                    if (p.ZoneCrimson) { BiomeBasicInfo.MixBiome(ref biomeMixed, biomeCrimsonIce); normal = false; }
                    if (p.ZoneHallow) { BiomeBasicInfo.MixBiome(ref biomeMixed, biomeHallowIce); normal = false; }
                    if (normal) BiomeBasicInfo.MixBiome(ref biomeMixed, biomeUndergroundSnow);
                }
            }
            if (Main.LocalPlayer.position.Y < Main.worldSurface * 16.0) {
                if (p.ZoneGlowshroom) BiomeBasicInfo.MixBiome(ref biomeMixed, biomeSurfaceMushroom);
            }
            if (p.ZoneDesert) {
                if (p.ZoneCorrupt) BiomeBasicInfo.MixBiome(ref biomeMixed, biomeCorruptDesert);
                if (p.ZoneCrimson) BiomeBasicInfo.MixBiome(ref biomeMixed, biomeCrimsonDesert);
                if (p.ZoneHallow) BiomeBasicInfo.MixBiome(ref biomeMixed, biomeHallowDesert);
            }

            return biomeMixed;
        }

        public override bool IsVisible() {
            return InfoLoader.GenericConfiguration.BiomeMixedInfo;
        }
    }

    internal class BiomeModdedInfo : GenericInfo
    {
        public override string GetStat() {
            var p = Main.LocalPlayer;

            var biomeMixed = Language.GetTextValue($"Mods.{Mod.Name}.None");
            if (p.ZonePurity) return biomeMixed;

            var loader = LoaderManager.Get<BiomeLoader>();
            var target = loader.GetType().GetField("list", BindingFlags.Instance | BindingFlags.NonPublic);
            if (target == null || !typeof(IList).IsAssignableFrom(target.FieldType)) return biomeMixed;
            var targetList = (List<ModBiome>)target.GetValue(loader);

            foreach (var n in from b in targetList where b.IsBiomeActive(p) select b.DisplayName.GetTranslation(Language.ActiveCulture)) {
                BiomeBasicInfo.MixBiome(ref biomeMixed, n);
            }

            return biomeMixed;
        }

        public override bool IsVisible() {
            return InfoLoader.GenericConfiguration.BiomeModdedInfo;
        }
    }

}
