using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace CosmeticVariety.Tiles {
public class SeashellBlock : ModTile
{
    public override void SetDefaults()
    {
        Main.tileSolid[Type] = true;
        drop = mod.ItemType("SeashellBlock");
		dustType = mod.DustType("Solar");
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}