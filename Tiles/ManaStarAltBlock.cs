using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Tiles {
public class ManaStarAltBlock : ModTile
{
    public override void SetDefaults()
    {
        Main.tileSolid[Type] = true;
        Main.tileBlockLight[Type] = true;
		Main.tileMerge[Type][mod.TileType("ManaStarBlock")] = true;
		Main.tileMerge[Type][mod.TileType("Starsoil")] = true;
		Main.tileMerge[Type][mod.TileType("StarshineBrick")] = true;
		Main.tileMerge[Type][mod.TileType("StarshineBlock")] = true;
		Main.tileMerge[Type][mod.TileType("Starstone")] = true;
        drop = mod.ItemType("ManaStarAltBlock");
        AddMapEntry(new Color(67, 3, 184));
		dustType = mod.DustType("Stardust");
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}