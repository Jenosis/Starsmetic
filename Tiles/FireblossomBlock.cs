using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace CosmeticVariety.Tiles {
public class FireblossomBlock : ModTile
{
    public override void SetDefaults()
    {
        Main.tileSolid[Type] = true;
		Main.tileMerge[Type][mod.TileType("FlowerStemBlock")] = true;
		Main.tileMerge[Type][mod.TileType("PetalBlock")] = true;
		Main.tileMerge[Type][mod.TileType("Floralwood")] = true;
		Main.tileMergeDirt[this.Type] = false;
		Main.tileBlendAll[this.Type] = true;
        drop = mod.ItemType("FireblossomBlock");
        AddMapEntry(new Color(200, 200, 100));
		dustType = mod.DustType("Vortex");
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}