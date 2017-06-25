using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Tiles {
public class StarshineBrick : ModTile
{
    public override void SetDefaults()
    {
        Main.tileSolid[Type] = true;
        Main.tileBlockLight[Type] = true;
		Main.tileMerge[Type][mod.TileType("ManaStarBlock")] = true;
		Main.tileMerge[Type][mod.TileType("Starsoil")] = true;
		Main.tileMerge[Type][mod.TileType("StarshineBrick")] = true;
		Main.tileMerge[Type][mod.TileType("Starstone")] = true;
        drop = mod.ItemType("StarshineBrick");
		dustType = mod.DustType("Stardust");
    }

    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}