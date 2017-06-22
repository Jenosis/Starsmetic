using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Walls {
public class FlorawoodFence : ModWall
{
    public override void SetDefaults()
    {
        Main.wallHouse[Type] = true;
		Main.wallLight[Type] = true;
        drop = mod.ItemType("FlorawoodFence");
		dustType = mod.DustType("Vortex");
    }

    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}