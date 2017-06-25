using System;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CosmeticVariety.Tiles {
public class AdvancedCookingStation : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
		Main.tileTable[Type] = true;
		animationFrameHeight = 54;
		Main.tileLighted[Type] = true;
		TileObjectData.newTile.UsesCustomCanPlace = true;
        TileObjectData.newTile.Width = 5;
		TileObjectData.newTile.Height = 3;
		TileObjectData.newTile.CoordinateHeights = new int[]{ 16, 16,16};
		TileObjectData.newTile.CoordinateWidth = 16;
		TileObjectData.newTile.CoordinatePadding = 2;
        TileObjectData.addTile(Type);
		dustType = mod.DustType("Pixel");
		adjTiles = new int[]{TileID.Kegs, TileID.CookingPots, mod.TileType("Oven")};
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(i * 16, j * 16, 80, 48, mod.ItemType("AdvancedCookingStation"));
    }
}}