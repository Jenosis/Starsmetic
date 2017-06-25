using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
    public class PlaceableVanilla : GlobalItem
    {
        public override void SetDefaults(Item item)
		{
            if (item.type == ItemID.AdhesiveBandage)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Bandaid");
            }
			if (item.type == ItemID.ArmorPolish)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("ArmorPolish");
            }
			if (item.type == ItemID.ArmorBracing)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("ArmorBracing");
            }
			if (item.type == ItemID.ArcticDivingGear)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("ArcticDivingGear");
            }
			if (item.type == ItemID.AnkhCharm)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Ankh");
            }
			if (item.type == ItemID.AnkhShield)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("AnkhShield");
            }
			if (item.type == ItemID.ButterflyDust)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("ButterflyDust");
            }
			if (item.type == ItemID.BandofRegeneration)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("BandOfRegeneration");
            }
			if (item.type == ItemID.BandofStarpower)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("BandOfStarpower");
            }
			if (item.type == ItemID.Bezoar)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Bezoar");
            }
			if (item.type == ItemID.BlackFairyDust)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("BlackFairyDust");
            }
			if (item.type == ItemID.BlizzardinaBottle)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("BlizzardBottle");
            }
			if (item.type == ItemID.BoneFeather)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("BoneFeather");
            }
			 if (item.type == ItemID.DepthMeter)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("DepthMeter");
            }
			if (item.type == ItemID.DiamondRing)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("DiamondRing");
            }
			if (item.type == ItemID.DivingGear)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("DivingGear");
            }
			if (item.type == ItemID.DPSMeter)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("DPSMeter");
            }
			if (item.type == ItemID.CelestialEmblem)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("CelestialEmblem");
            }
			if (item.type == ItemID.CelestialMagnet)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("CelestialMagnet");
            }
			if (item.type == ItemID.CelestialShell)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("CelestialShell");
            }
			if (item.type == ItemID.CelestialStone)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("CelestialStone");
            }
			if (item.type == ItemID.CharmofMyths)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("CharmOfMyths");
            }
			if (item.type == ItemID.CloudinaBottle)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("CloudBottle");
            }
			if (item.type == ItemID.CobaltShield)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("CobaltShield");
            }
			if (item.type == ItemID.CoinRing)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("CoinRing");
            }
			if (item.type == ItemID.Compass)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Compass");
            }
			if (item.type == ItemID.CopperWatch)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("CopperWatch");
            }
			if (item.type == ItemID.CountercurseMantra)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("CounterCurseMantra");
            }
			if (item.type == ItemID.CrossNecklace)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("CrossNecklace");
            }
			if (item.type == ItemID.DarkShard)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("DarkShard");
            }
			if (item.type == ItemID.DivingGear)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("DivingGear");
            }
			if (item.type == ItemID.DiamondRing)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("DiamondRing");
            }
			if (item.type == ItemID.DepthMeter)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("DepthMeter");
            }
			if (item.type == ItemID.DPSMeter)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("DPSMeter");
            }
			if (item.type == ItemID.FrostsparkBoots)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("FrostsparkBoots");
            }
			if (item.type == ItemID.EoCShield)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("ShieldOfCthulhu");
            }
			if (item.type == ItemID.ExplosivePowder)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("ExplosivePowder");
            }
			if (item.type == ItemID.EyeoftheGolem)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("EyeOfGolem");
            }
			if (item.type == ItemID.FartinaJar)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("FartBottle");
            }
			if (item.type == ItemID.FastClock)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("FastClock");
            }
			if (item.type == ItemID.FireFeather)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("FireFeather");
            }
			if (item.type == ItemID.FishFinder)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("FishFinder");
            }
			if (item.type == ItemID.FishermansGuide)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("FishingPocketGuide");
            }
			if (item.type == ItemID.Flipper)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Flipper");
            }
			if (item.type == ItemID.FlowerBoots)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("FlowerBoots");
            }
			if (item.type == ItemID.FlurryBoots)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("FlurryBoots");
            }
			if (item.type == ItemID.AncientBattleArmorMaterial)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("ForbiddenFragment");
            }
			if (item.type == ItemID.FrostCore)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("FrostCore");
            }
			if (item.type == ItemID.IceSkates)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("IceSkates");
            }
			if (item.type == ItemID.Gel)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Gel");
            }
			if (item.type == ItemID.GiantHarpyFeather)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("GiantHarpyFeather");
            }
			if (item.type == ItemID.GoblinTech)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("GoblinTech");
            }
			if (item.type == ItemID.GoldDust)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("GoldDust");
            }
			if (item.type == ItemID.GoldRing)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("GoldRing");
            }
			if (item.type == ItemID.GoldWatch)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("GoldWatch");
            }
			if (item.type == ItemID.GPS)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("GPS");
            }
			if (item.type == ItemID.IceFeather)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("IceFeather");
            }
			if (item.type == ItemID.ManaFlower)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("ManaFlower");
            }
			if (item.type == ItemID.MagmaStone)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("MagmaStone");
            }
			if (item.type == ItemID.LuckyCoin)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("LuckyCoin");
            }
			if (item.type == ItemID.LuckyHorseshoe)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("LuckyHorseshoe");
            }
			if (item.type == ItemID.ManaRegenerationBand)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("ManaRegenerationBand");
            }
			if (item.type == ItemID.Megaphone)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Megaphone");
            }
			if (item.type == ItemID.MetalDetector)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("MetalDetector");
            }
			if (item.type == ItemID.MoonCharm)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("MoonCharm");
            }
			if (item.type == ItemID.MoonShell)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("MoonShell");
            }
			if (item.type == ItemID.MoonStone)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("MoonStone");
            }
			if (item.type == ItemID.NaturesGift)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("NaturesGift");
            }
			if (item.type == ItemID.Nazar)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Nazar");
            }
			if (item.type == ItemID.NeptunesShell)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("NeptunesShell");
            }
			if (item.type == ItemID.MechanicalLens)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("MechanicalLens");
            }
			if (item.type == ItemID.LaserRuler)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("MechanicalRuler");
            }
			if (item.type == ItemID.MedicatedBandage)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("MedicatedBandage");
            }
			if (item.type == ItemID.SailfishBoots)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("SailfishBoots");
            }
			if (item.type == ItemID.ObsidianHorseshoe)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("ObsidianHorseshoe");
            }
			if (item.type == ItemID.ObsidianRose)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("ObsidianRose");
            }
			if (item.type == ItemID.ObsidianShield)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("ObsidianShield");
            }
			if (item.type == ItemID.ObsidianSkull)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("ObsidianSkull");
            }
			if (item.type == ItemID.ObsidianWaterWalkingBoots)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("ObsidianWaterWalkingBoots");
            }
			if (item.type == ItemID.PaladinsShield)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("PaladinShield");
            }
			if (item.type == ItemID.PanicNecklace)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("PanicNecklace");
            }
			if (item.type == ItemID.PDA)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("PDA");
            }
			if (item.type == ItemID.PhilosophersStone)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("PhilosophersStone");
            }
			if (item.type == ItemID.PixieDust)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("PixieDust");
            }
			if (item.type == ItemID.PutridScent)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("PutridScent");
            }
			if (item.type == ItemID.Radar)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Radar");
            }
			if (item.type == ItemID.PlatinumWatch)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("PlatinumWatch");
            }
			if (item.type == ItemID.REK)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("REK");
            }
			if (item.type == ItemID.RocketBoots)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("RocketBoots");
            }
			if (item.type == ItemID.Ruler)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Ruler");
            }
			if (item.type == ItemID.TempleKey)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("TempleKey");
            }
			if (item.type == ItemID.SandstorminaBottle)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("SandstormBottle");
            }
			if (item.type == ItemID.SharkToothNecklace)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("SawtoothNecklace");
            }
			if (item.type == ItemID.Sextant)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Sextant");
            }
			 if (item.type == ItemID.ShadowScale)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("ShadowScale");
            }
			if (item.type == ItemID.SilverWatch)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("SilverWatch");
            }
			if (item.type == ItemID.SpectreBoots)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("SpectreBoots");
            }
			if (item.type == ItemID.StarVeil)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("StarVeil");
            }
			if (item.type == ItemID.Stopwatch)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Stopwatch");
            }
			if (item.type == ItemID.SunStone)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("SunStone");
            }
			if (item.type == ItemID.SweetheartNecklace)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("SweetheartNecklace");
            }
			if (item.type == ItemID.TallyCounter)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("TallyCounter");
            }
			if (item.type == ItemID.Vitamins)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Vitamins");
            }
			if (item.type == ItemID.WispinaBottle)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("WispBottle");
            }
			if (item.type == ItemID.TinWatch)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("TinWatch");
            }
			if (item.type == ItemID.TissueSample)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("TissueSample");
            }
			if (item.type == ItemID.TrifoldMap)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("TrifoldMap");
            }
			if (item.type == ItemID.WaterWalkingBoots)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("WaterWalkingBoots");
            }
			if (item.type == ItemID.WeatherRadio)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("WeatherRadio");
            }
			if (item.type == ItemID.TsunamiInABottle)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("TsunamiBottle");
            }
			if (item.type == ItemID.VialofVenom)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("VialOfVenom");
            }
			if (item.type == ItemID.TungstenWatch)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("TungstenWatch");
            }
			if (item.type == ItemID.ThePlan)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("ThePlan");
            }
			 if (item.type == ItemID.LavaWaders)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("LavaWaders");
            }
			if (item.type == ItemID.LifeformAnalyzer)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("LifeformAnalyzer");
            }
			if (item.type == ItemID.LightningBoots)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("LightningBoots");
            }
			if (item.type == ItemID.LightShard)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("LightShard");
            }
			if (item.type == ItemID.JungleRose)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("JungleRose");
            }
			if (item.type == ItemID.LavaCharm)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("LavaCharm");
            }
			if (item.type == ItemID.JellyfishDivingGear)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("JellyfishDivingGear");
            }
			if (item.type == ItemID.JellyfishNecklace)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("JellyfishNecklace");
            }
			if (item.type == ItemID.HermesBoots)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("HermesBoots");
            }
			if (item.type == ItemID.AncientCloth)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("AncientCloth");
            }
			if (item.type == ItemID.TatteredCloth)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("TatteredCloth");
            }
			if (item.type == ItemID.Silk)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Silk");
            }
			if (item.type == ItemID.SharkFin)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("SharkFin");
            }
			if (item.type == ItemID.Aglet)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Aglet");
            }
			if (item.type == ItemID.AnkletoftheWind)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Anklet");
            }
			if (item.type == ItemID.AntlionMandible)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("AntlionMandible");
            }
			if (item.type == ItemID.BeeWax)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Beewax");
            }
			if (item.type == ItemID.Lens)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("Lens");
            }
			if (item.type == ItemID.BlackLens)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("BlackLens");
            }
			if (item.type == ItemID.IllegalGunParts)
            {
				item.useAnimation = 15;
				item.useTime = 15;
				item.consumable = true;
				item.useStyle = 1;
                item.createTile = mod.TileType("IllegalGunPart");
            }
        }
    }
}