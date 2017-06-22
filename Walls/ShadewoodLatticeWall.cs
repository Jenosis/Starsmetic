using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Walls {
public class ShadewoodLatticeWall : ModWall
{
    public override void SetDefaults()
    {
        Main.wallHouse[Type] = true;
		Main.wallLight[Type] = true;
        drop = mod.ItemType("ShadewoodLatticeWall");
		dustType = mod.DustType("Pixel");
    }

    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}