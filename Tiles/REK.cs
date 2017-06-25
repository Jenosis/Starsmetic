using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CosmeticVariety.Tiles {
public class REK : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
		TileObjectData.newTile.CopyFrom(TileObjectData.StyleOnTable1x1);
        TileObjectData.addTile(Type);
		drop = (ItemID.REK);
		dustType = mod.DustType("Pixel");
		
    }
	public override void NearbyEffects(int i, int j, bool closer)
    {
        if (closer)
		{
			CosmeticWorld.accThirdEyeHelper = true;
			CosmeticWorld.accJarOfSoulsHelper = true;
			CosmeticWorld.accCritterGuideHelper = true;
		}
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}