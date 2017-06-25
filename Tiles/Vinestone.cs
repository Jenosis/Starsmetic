using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace CosmeticVariety.Tiles {
public class Vinestone : ModTile
{
    public override void SetDefaults()
    {
        Main.tileSolid[Type] = true;
		Main.tileMerge[Type][mod.TileType("FlowerStemBlock")] = true;
		Main.tileMerge[Type][mod.TileType("PetalBlock")] = true;
		Main.tileMerge[Type][mod.TileType("Floralwood")] = true;
		Main.tileMergeDirt[this.Type] = false;
		Main.tileBlendAll[this.Type] = true;
		soundType = 21;
        drop = mod.ItemType("Vinestone");
        AddMapEntry(new Color(100, 200, 200));
		dustType = mod.DustType("Vortex");
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}