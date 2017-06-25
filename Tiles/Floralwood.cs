using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Tiles {
public class Floralwood : ModTile
{
    public override void SetDefaults()
    {
        Main.tileSolid[Type] = true;
		Main.tileMerge[Type][mod.TileType("FlowerStemBlock")] = true;
		Main.tileMerge[Type][mod.TileType("PetalBlock")] = true;
		Main.tileMerge[Type][mod.TileType("FertileSoil")] = true;
        drop = mod.ItemType("Floralwood");
		dustType = mod.DustType("Vortex");
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}