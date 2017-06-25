using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CosmeticVariety.Tiles {
public class PixieLamppost : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
		Main.tileLighted[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
        TileObjectData.newTile.Height = 6;
        TileObjectData.newTile.CoordinateHeights = new int[]
        {
            16,
            16,
            16,
            16,
            16,
			16
        };
        TileObjectData.addTile(Type);
		dustType = mod.DustType("Pixel");
    }
	public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
    {
        r = 1.0f;
        g = 1.0f;
        b = 0.5f;
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(i * 16, j * 16, 48, 32, mod.ItemType("PixieLamppost"));
    }
}}