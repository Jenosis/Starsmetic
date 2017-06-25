using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Tiles {
public class LivingBorealLeaf : ModTile
{
    public override void SetDefaults()
    {
        Main.tileSolid[Type] = true;
		Main.tileBlendAll[this.Type] = true;
        Main.tileBlockLight[Type] = true;
		Main.tileMerge[Type][mod.TileType("LivingBorealWood")] = true;
        drop = 2503;
        AddMapEntry(new Color(9, 63, 28));
		dustType = mod.DustType("Pixel");
    }

    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}