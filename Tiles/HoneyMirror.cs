using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;

namespace CosmeticVariety.Tiles {
public class HoneyMirror : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
		TileObjectData.newTile.Height = 3;
        TileObjectData.newTile.CoordinateHeights = new int[]
        {
            16,
            16,
            16
		};
		TileObjectData.newTile.AnchorBottom = default(AnchorData);
		TileObjectData.newTile.AnchorTop = default(AnchorData);
		TileObjectData.newTile.AnchorWall = true;
        TileObjectData.addTile(Type);
		dustType = mod.DustType("Pixel");
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(i * 16, j * 16, 32, 48, mod.ItemType("HoneyMirror"));
    }
}}