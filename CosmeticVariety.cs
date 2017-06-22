using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using CosmeticVariety.Tiles;
using System.Collections.Generic;
using Terraria.GameContent.UI;
using System.Linq;
using System.IO;
using CosmeticVariety.Items;
using CosmeticVariety.Items.Armor;
using CosmeticVariety.NPCs;
using CosmeticVariety.Skies;
namespace CosmeticVariety {
public class CosmeticVariety : Mod
{
	public CosmeticVariety ()
	{
		Properties = new ModProperties()
		{
			Autoload = true,
			AutoloadGores = true,
			AutoloadSounds = true,
			AutoloadBackgrounds = true
		};
	}
	public override void HandlePacket(BinaryReader bb, int whoAmI)
	{
		MNetSync.HandlePacket(bb, whoAmI, this);
	}
	public static int CustomCurrencyID;
	public override void Load()
	{
		CustomCurrencyID = CustomCurrencyManager.RegisterCurrency(new CustomCurrency(ItemType<Items.MagicBean>(), 999L));
		if (!Main.dedServ)
		{
			AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/StarPalace"), ItemType("StellariaMusicBox"), TileType("StellariaMusicBox"));
			AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/FlowerFields"), ItemType("FlorianaMusicBox"), TileType("FlorianaMusicBox"));
			Filters.Scene["CosmeticVariety:StarrySky"] = new Filter(new ScreenShaderData("FilterMiniTower").UseColor(0f, 0.0f, 0.0f).UseOpacity(0.0f), EffectPriority.High);
			SkyManager.Instance["CosmeticVariety:StarrySky"] = new StarrySky();
		}
	}
	public override void UpdateMusic(ref int music)
	{
		if (Main.myPlayer != -1 && !Main.gameMenu)
		{
			if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].GetModPlayer<CosmeticPlayer>(this).ZoneStar)
			{
				music = this.GetSoundSlot(SoundType.Music, "Sounds/Music/StarPalace");
			}
			if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].GetModPlayer<CosmeticPlayer>(this).ZoneFlower)
			{
				music = this.GetSoundSlot(SoundType.Music, "Sounds/Music/FlowerFields");
			}
		}
	}
    public override void AddRecipes()
    {	
		ModRecipe recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "LaminatedFlooring");
		recipe.AddTile(18);
        recipe.SetResult(ItemID.Wood, 1);
        recipe.AddRecipe();
		
		recipe.AddIngredient(ItemID.BottledWater,1);
		recipe.AddTile(TileID.SkyMill);
		recipe.SetResult(ItemID.Cloud, 25);
        recipe.AddRecipe();    
		
		recipe.AddIngredient(null, "LogPlatform", 2);
		recipe.AddTile(304);
        recipe.SetResult(ItemID.Wood, 1);
        recipe.AddRecipe();
		
		recipe.AddIngredient(ItemID.Wood, 10);
		recipe.AddIngredient(ItemID.Acorn, 2);
		recipe.AddTile(304);
        recipe.SetResult(ItemID.LivingWoodWand, 1);
        recipe.AddRecipe();
		
		recipe.AddIngredient(ItemID.Wood, 10);
		recipe.AddIngredient(ItemID.Acorn, 2);
		recipe.AddTile(304);
        recipe.SetResult(ItemID.LeafWand, 1);
        recipe.AddRecipe();
		
		recipe.AddIngredient(ItemID.RichMahogany, 10);
		recipe.AddIngredient(ItemID.JungleGrassSeeds, 2);
		recipe.AddTile(304);
        recipe.SetResult(ItemID.LivingMahoganyLeafWand, 1);
        recipe.AddRecipe();
		
		recipe.AddIngredient(ItemID.RichMahogany, 10);
		recipe.AddIngredient(ItemID.JungleGrassSeeds, 2);
		recipe.AddTile(304);
        recipe.SetResult(ItemID.LivingMahoganyWand, 1);
        recipe.AddRecipe();
		
		recipe.AddIngredient(null, "LivingMahoganyWoodWall", 4);
		recipe.AddTile(304);
        recipe.SetResult(ItemID.RichMahogany, 1);
        recipe.AddRecipe();
		
		recipe.AddIngredient(null, "LivingMahoganyLeafWall", 4);
		recipe.AddTile(304);
        recipe.SetResult(ItemID.RichMahogany, 1);
        recipe.AddRecipe();
		
		recipe.AddIngredient(null, "LeafPlatform",2);
		recipe.AddTile(304);
        recipe.SetResult(ItemID.Wood, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(ItemID.Wood,10);
		recipe.AddIngredient(ItemID.FallenStar, 5);
		recipe.AddTile(106);
        recipe.SetResult(ItemID.LivingLoom, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeBell");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.Bell, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSlimeCrown");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.SlimeCrown, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSEye");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.SuspiciousLookingEye, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeMechEye");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.MechanicalEye, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeMechWorm");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.MechanicalWorm, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeMechSkull");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.MechanicalSkull, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeBloodySpine");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.BloodySpine, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeWormFood");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.WormFood, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeAbeemination");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.Abeemination, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativePowerCell");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.LihzahrdPowerCell, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeCelestialSigil");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.CelestialSigil, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeTreasureMap");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.PirateMap, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSnowglobe");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.SnowGlobe, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeNaughtyPresent");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.NaughtyPresent, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativePumpkinMedallion");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.PumpkinMoonMedallion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSolarTablet");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.SolarTablet, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeGoblinBattleStandard");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.GoblinBattleStandard, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeDemonScythe");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.DemonScythe, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeAquaSceptre");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.AquaScepter, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeRainbowRod");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.RainbowRod, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeIceRod");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.IceRod, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeCrystalStorm");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.CrystalStorm, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeCursedFlames");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.CursedFlames, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeFlameLash");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.Flamelash, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeMagicMissile");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.MagicMissile, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeWaterBolt");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.WaterBolt, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeAmethystStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.AmethystStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeTopazStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.TopazStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSapphireStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.SapphireStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeEmeraldStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.EmeraldStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeRubyStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.RubyStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeDiamondStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.DiamondStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeNimbusRod");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.NimbusRod, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeCrimsonRod");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.CrimsonRod, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeBookOfSkulls");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.BookofSkulls, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeGoldenShower");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.GoldenShower, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSpectreStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.SpectreStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeMagnetSphere");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.MagnetSphere, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeBatSceptre");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.BatScepter, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeManaCrystal");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.ManaCrystal, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeFallenStar");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.FallenStar, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeBlizzardStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.BlizzardStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeRazorBladeTyphoon");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.RazorbladeTyphoon, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeMeteorStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.MeteorStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeAmberStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.AmberStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeLunarFlare");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.LunarFlareBook, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeLastPrism");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.LastPrism, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeWandofSparking");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.WandofSparking, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeBlastCannon");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.ChargedBlasterCannon, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeClingerStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.ClingerStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeDeadlySphereStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.DeadlySphereStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSkyFracture");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.SkyFracture, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeHornetStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.HornetStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeImpStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.ImpStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeInfernoFork");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.InfernoFork, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeLifeDrain");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.SoulDrain, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeLunarPortalStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.MoonlordTurretStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeOpticStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.OpticStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativePirateStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.PirateStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativePoisonStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.PoisonStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativePygmyStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.PygmyStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeQueenSpiderStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.QueenSpiderStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeRavenStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.RavenStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeRainbowCrystalStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.RainbowCrystalStaff, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeShadowbeamStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.ShadowbeamStaff, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSlimeStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.SlimeStaff, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSpiderStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.SpiderStaff, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeStaffOfEarth");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.StaffofEarth, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeStaffOfTheFrostHydra");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.StaffoftheFrostHydra, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeStardustCellStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.StardustCellStaff, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeStardustDragonStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.StardustDragonStaff, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeTempestStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.TempestStaff, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeUnholyTrident");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.UnholyTrident, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeVenomStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.VenomStaff, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeVileThorn");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.Vilethorn, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeVilePowder");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.VilePowder, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativePurificationPowder");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.PurificationPowder, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeViciousPowder");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.ViciousPowder, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeFlaskofVenom");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.FlaskofVenom, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeFlaskofCursedFlames");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.FlaskofCursedFlames, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeFlaskofFire");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.FlaskofFire, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeFlaskofGold");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.FlaskofGold, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeFlaskofIchor");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.FlaskofIchor, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeFlaskofPoison");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.FlaskofPoison, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeFlaskofNanites");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.FlaskofNanites, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeFlaskofParty");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.FlaskofParty, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeHolyWater");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.HolyWater, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeUnholyWater");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.UnholyWater, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeBloodWater");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.BloodWater, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "WeirdlyColoredPetal",10);
		recipe.AddIngredient(ItemID.RichMahogany, 8);
		recipe.AddIngredient(ItemID.SkyBlueFlower,1);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.FlowerBoots, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeXenoStaff");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.XenoStaff, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeHarp");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.Harp, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "Starwood",3);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.FallenStar, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeMagicMirror");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.MagicMirror, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeIceMirror");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.IceMirror, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeMagicalHarp");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.MagicalHarp, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeFairyBell");
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.FairyBell, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "SilkCarpet");
		recipe.AddTile(18);
        recipe.SetResult(ItemID.Silk, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "StarshinePlatform",2);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.FallenStar, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "StarshineFence",4);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.FallenStar, 1);
        recipe.AddRecipe(); 
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(ItemID.FishingSeaweed, 2);
		recipe.AddIngredient(ItemID.ClayPot, 2);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.SeaweedPlanter, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(ItemID.StoneBlock,1);
		recipe.AddIngredient(ItemID.Coral,1);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.CoralstoneBlock, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(ItemID.Wood,2);
		recipe.AddIngredient(ItemID.FallenStar, 3);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.WandofSparking, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "SoupPot",1);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.BowlofSoup, 2);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null,"WhiteTeamWall", 4);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.TeamBlockWhite,1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null,"GreenTeamWall", 4);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.TeamBlockGreen,1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null,"BlueTeamWall", 4);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.TeamBlockBlue,1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null,"RedTeamWall", 4);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.TeamBlockRed,1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null,"YellowTeamWall", 4);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.TeamBlockYellow,1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null,"PinkTeamWall", 4);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.TeamBlockPink,1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "Paper", 3);
        recipe.SetResult(ItemID.Book, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(ItemID.Coral, 1);
        recipe.SetResult(ItemID.Seashell, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "LatticeWall", 4);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.Wood, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "PearlwoodLatticeWall", 4);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.Pearlwood, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "PalmLatticeWall", 4);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.PalmWood, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "BorealLatticeWall", 4);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.BorealWood, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "LivingBorealWoodWall", 4);
		recipe.AddTile(304);
        recipe.SetResult(ItemID.BorealWood, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "LivingBorealLeafWall", 4);
		recipe.AddTile(304);
        recipe.SetResult(ItemID.BorealWood, 1);
        recipe.AddRecipe();
		
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "LivingPalmWoodWall", 4);
		recipe.AddTile(304);
        recipe.SetResult(ItemID.PalmWood, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "LivingPalmLeafWall", 4);
		recipe.AddTile(304);
        recipe.SetResult(ItemID.PalmWood, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "EbonwoodLatticeWall", 4);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.Ebonwood, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "ShadewoodLatticeWall", 4);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.Shadewood, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "RichMahoganyLatticeWall", 4);
		recipe.AddTile(18);
        recipe.SetResult(ItemID.RichMahogany, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "SolarWall", 4);
		recipe.AddTile(412);
        recipe.SetResult(ItemID.LunarBlockSolar, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "SolarPlatform", 2);
		recipe.AddTile(412);
        recipe.SetResult(ItemID.LunarBlockSolar, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "VortexWall", 4);
		recipe.AddTile(412);
        recipe.SetResult(ItemID.LunarBlockVortex, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "VortexPlatform", 2);
		recipe.AddTile(412);
        recipe.SetResult(ItemID.LunarBlockVortex, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "NebulaWall", 4);
		recipe.AddTile(412);
        recipe.SetResult(ItemID.LunarBlockNebula, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "NebulaPlatform", 2);
		recipe.AddTile(412);
        recipe.SetResult(ItemID.LunarBlockNebula, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "StardustWall", 4);
		recipe.AddTile(412);
        recipe.SetResult(ItemID.LunarBlockStardust, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "StardustPlatform", 2);
		recipe.AddTile(412);
        recipe.SetResult(ItemID.LunarBlockStardust, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeBomb", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.Bomb, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeStickyBomb", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.StickyBomb, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeBouncyBomb", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.BouncyBomb, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeBeenade", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.Beenade, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeHappyGrenade", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.PartyGirlGrenade, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeFrostFlower", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.FlowerofFrost, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeFireFlower", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.FlowerofFire, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeGrenade", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.Grenade, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeBouncyGrenade", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.BouncyGrenade, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeStickyGrenade", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.StickyGrenade, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeDynamite", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.Dynamite, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeStickyDynamite", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.StickyDynamite, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeBouncyDynamite", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.BouncyDynamite, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeAle", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.Ale, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeAmmoReservationPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.AmmoReservationPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeArcheryPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.ArcheryPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeBattlePotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.BattlePotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeBottledWater", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.BottledWater, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeBottledHoney", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.BottledHoney, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSoup", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.BowlofSoup, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeBuilderPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.BuilderPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeCalmingPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.CalmingPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeChristmasPudding", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.ChristmasPudding, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeCookedFish", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.CookedFish, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeCookedMarshmallow", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.CookedMarshmallow, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeCookedShrimp", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.CookedShrimp, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeCratePotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.CratePotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeDangersensePotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.TrapsightPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeEggnog", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.Eggnog, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeEndurancePotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.EndurancePotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeFeatherfallPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.FeatherfallPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeFishingPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.FishingPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeFlipperPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.FlipperPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeGenderChangePotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.ArcheryPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeGrubSoup", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.GrubSoup, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeGillsPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.GillsPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeGingerbreadCookie", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.GingerbreadCookie, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeGravitationPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.GravitationPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeGreaterHealingPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.GreaterHealingPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeGreaterManaPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.GreaterManaPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeHealingPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.HealingPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeHeartreachPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.HeartreachPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeHunterPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.HunterPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeInfernoPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.InfernoPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeInvisibilityPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.InvisibilityPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeIronskinPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.IronskinPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeLesserHealingPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.LesserHealingPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeLesserRestorationPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.LesserRestorationPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeLesserManaPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.LesserManaPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeLifeforcePotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.LifeforcePotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeLovePotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.LovePotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeMagicPowerPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.MagicPowerPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeManaPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.ManaPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeManaRegenerationPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.ManaRegenerationPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeMiningPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.MiningPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeMushroom", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.Mushroom, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeNightOwlPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.NightOwlPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeObsidianSkinPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.ObsidianSkinPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativePadThai", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.PadThai, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativePho", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.Pho, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativePumpkinPie", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.PumpkinPie, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeRagePotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.RagePotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeRecallPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.RecallPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeRegenerationPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.RegenerationPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeRestorationPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.RestorationPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSake", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.Sake, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSashimi", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.Sashimi, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeShinePotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.ShinePotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSonarPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.SonarPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSpelunkerPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.SpelunkerPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeBacon", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.Bacon, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeViciousMushroom", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.ViciousMushroom, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeStinkPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.StinkPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSugarCookie", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.SugarCookie, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(ItemID.Silk, 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.Present, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSummoningPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.SummoningPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSuperManaPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.SuperManaPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSuperHealingPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.SuperHealingPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeSwiftnessPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.SwiftnessPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeStrangeBrew", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.StrangeBrew, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeTeleportationPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.TeleportationPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeThornsPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.ThornsPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeTitanPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.TitanPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeVileMushroom", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.VileMushroom, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeWarmthPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.WarmthPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeWaterWalkingPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.WaterWalkingPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "DecorativeWrathPotion", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(ItemID.WrathPotion, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "BrassBar",1);
		recipe.AddIngredient(ItemID.Torch,1);
		recipe.AddTile(16);
        recipe.SetResult(ItemID.ChainLantern, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "BrassBar",1);
		recipe.AddIngredient(ItemID.Torch,1);
		recipe.AddTile(16);
        recipe.SetResult(ItemID.BrassLantern, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "BrassBar",1);
		recipe.AddIngredient(ItemID.Torch,1);
		recipe.AddTile(16);
        recipe.SetResult(ItemID.CagedLantern, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "BrassBar",1);
		recipe.AddIngredient(ItemID.Torch,1);
		recipe.AddTile(16);
        recipe.SetResult(ItemID.CarriageLantern, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "BrassBar",1);
		recipe.AddIngredient(ItemID.Torch,1);
		recipe.AddTile(16);
        recipe.SetResult(ItemID.AlchemyLantern, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "BrassBar",1);
		recipe.AddIngredient(ItemID.Torch,1);
		recipe.AddTile(16);
        recipe.SetResult(ItemID.DiablostLamp, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "BrassBar",1);
		recipe.AddIngredient(ItemID.Torch,1);
		recipe.AddTile(16);
        recipe.SetResult(ItemID.OilRagSconse, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "BrassBar",1);
		recipe.AddTile(16);
        recipe.SetResult(ItemID.BrassShelf, 2);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(this);
        recipe.AddIngredient(null, "BrassBar",1);
		recipe.AddTile(16);
        recipe.SetResult(ItemID.Cog, 6);
        recipe.AddRecipe();
    }
	public static bool NoBiome(NPCSpawnInfo spawnInfo)
	{
		Player player = spawnInfo.player;
		return !player.ZoneJungle && !player.ZoneDungeon && !player.ZoneCorrupt && !player.ZoneCrimson && !player.ZoneHoly && !player.ZoneSnow && !player.ZoneUndergroundDesert;
	}
}}