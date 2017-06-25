using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CosmeticVariety.Tiles {
public class LifeformAnalyzer : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
		TileObjectData.newTile.UsesCustomCanPlace = true;
        TileObjectData.newTile.Width = 2;
		TileObjectData.newTile.Height = 2;
		TileObjectData.newTile.CoordinateHeights = new int[]{ 16,16};
		TileObjectData.newTile.CoordinateWidth = 16;
		TileObjectData.newTile.CoordinatePadding = 2;        TileObjectData.addTile(Type);
		drop = (ItemID.LifeformAnalyzer);
		dustType = mod.DustType("Pixel");
		
    }
	public override void NearbyEffects(int i, int j, bool closer)
    {
        if (closer)
		{
			CosmeticWorld.accCritterGuideHelper = true;
		}
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}