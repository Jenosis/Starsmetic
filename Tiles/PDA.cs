using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CosmeticVariety.Tiles {
public class PDA : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
		TileObjectData.newTile.CopyFrom(TileObjectData.StyleOnTable1x1);
        TileObjectData.addTile(Type);
		drop = (ItemID.PDA);
		dustType = mod.DustType("Pixel");
		
    }
	public override void NearbyEffects(int i, int j, bool closer)
    {
        if (closer)
		{
			Main.clock = true;
			CosmeticWorld.accWeatherRadioHelper = true;
			CosmeticWorld.accCalendarHelper = true;
			CosmeticWorld.accDepthMeterHelper = 1;
			CosmeticWorld.accCompassHelper = 1;
			CosmeticWorld.accCritterGuideHelper = true;
			CosmeticWorld.accOreFinderHelper = true;
			CosmeticWorld.accStopwatchHelper = true;
			CosmeticWorld.accFishFinderHelper = true;
			CosmeticWorld.accDreamCatcherHelper = true;
			CosmeticWorld.accThirdEyeHelper = true;
			CosmeticWorld.accJarOfSoulsHelper = true;
		}
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}