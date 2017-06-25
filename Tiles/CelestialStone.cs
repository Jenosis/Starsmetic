using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;

namespace CosmeticVariety.Tiles {
public class CelestialStone : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.Width = 1;
		TileObjectData.newTile.Height = 1;
		TileObjectData.newTile.Origin = new Point16(0, 0);
		TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.Table | AnchorType.SolidWithTop, TileObjectData.newTile.Width, 0);
		TileObjectData.newTile.CoordinateHeights = new int[]
		{
			20
		};
		TileObjectData.newTile.DrawYOffset = -2;
		TileObjectData.newTile.CoordinateWidth = 18;
		TileObjectData.newTile.UsesCustomCanPlace = true;
        TileObjectData.addTile(Type);
		drop = (ItemID.CelestialStone);
		dustType = mod.DustType("Pixel");
		
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}