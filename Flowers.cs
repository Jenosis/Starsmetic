
using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

using Microsoft.Xna.Framework;

namespace CosmeticVariety
{
    public class Flowers : GlobalTile
    {
        public override bool Drop(int i, int j, int type)
        {
            if (type == TileID.Plants || type == TileID.Plants2 || type == mod.TileType("FloraGrass"))
			{
				if (WorldGen.genRand.Next(2) == 0 && (Main.player[(int)Player.FindClosest(new Vector2((float)(i * 16), (float)(j * 16)), 16, 16)].HasItem(mod.ItemType("Trowel"))))
				{
					if (WorldGen.genRand.Next(7) == 0)
					{
						Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Tulip"));
					}
					if (WorldGen.genRand.Next(20) == 0)
					{
						Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Rose"));
					}
					if (WorldGen.genRand.Next(24) == 0)
					{
						Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Iris"));
					}
					if (WorldGen.genRand.Next(15) == 0)
					{
						Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("Lotus"));
					}
					if (WorldGen.genRand.Next(10) == 0)
					{
						Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("TigerLily"));
					}
				}
			}
            return true;
        }
    }
}