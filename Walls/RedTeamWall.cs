using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Walls {
public class RedTeamWall : ModWall
{
    public override void SetDefaults()
    {
        Main.wallHouse[Type] = true;
        drop = mod.ItemType("RedTeamWall");
		dustType = mod.DustType("Pixel");
    }

    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}