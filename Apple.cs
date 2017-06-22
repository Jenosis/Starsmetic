using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CosmeticVariety.Items;

namespace CosmeticVariety
{
    public class Apple : GlobalTile
    {
        public override bool Drop(int i, int j, int type)
        {
            if(Main.rand.Next(15) == 1)
            {
                if ( Main.tile[i, j].type == 5 && Main.tile[i, j + 1].type != 5)
                {
                    if(    !Main.player[Main.myPlayer].ZoneCorrupt &&
                        !Main.player[Main.myPlayer].ZoneCrimson &&
                        !Main.player[Main.myPlayer].ZoneHoly &&
                        !Main.player[Main.myPlayer].ZoneSnow)
                        Item.NewItem(i * 16, j * 16, 26, 26, mod.ItemType("Apple"), 1, false, -1, false);
                }
            } return true;
		} 
    }
}