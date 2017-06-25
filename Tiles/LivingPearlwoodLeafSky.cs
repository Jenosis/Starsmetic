using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Tiles {
public class LivingPearlwoodLeafSky : ModTile
{
    public override void SetDefaults()
    {
        Main.tileSolid[Type] = true;
        Main.tileBlockLight[Type] = true;
		Main.tileBlendAll[this.Type] = true;
		Main.tileMerge[Type][mod.TileType("LivingPearlwood")] = true;
		Main.tileMerge[Type][mod.TileType("LivingPearlwoodLeafLime")] = true;
		Main.tileMerge[Type][mod.TileType("LivingPearlwoodLeafBlue")] = true;
		Main.tileMerge[Type][mod.TileType("LivingPearlwoodLeafPurple")] = true;
		Main.tileMerge[Type][mod.TileType("LivingPearlwoodLeafMagenta")] = true;
		Main.tileMerge[Type][mod.TileType("LivingPearlwoodLeafYellow")] = true;
        drop = 621;
        AddMapEntry(new Color(57, 57, 125));
		dustType = mod.DustType("Pixel");
    }

    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}