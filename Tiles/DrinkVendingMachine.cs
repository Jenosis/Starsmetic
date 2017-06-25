using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CosmeticVariety.Tiles
{
    public class DrinkVendingMachine : ModTile
    {
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileSolidTop[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			Main.tileTable[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x4);
			TileObjectData.addTile(Type);
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
			dustType = mod.DustType("Pixel");
		}
	
		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}
		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 48, 64, mod.ItemType("DrinkVendingMachine"));
		}
#region overrides

		int value = 0;
	
        public override void RightClick(int i, int j)
        {
			Item item = new Item();
			if(Main.rand.Next(2) == 0)
			{
				item.SetDefaults(ItemID.BottledWater);
			}
			else
			{
				item.SetDefaults(ItemID.BottledHoney);
			}
			item.stack = 1;
		
			value = item.value;
		
			if(Main.player[Main.myPlayer].BuyItem(item.value))
			{
				if(Main.player[Main.myPlayer].ItemSpace(item))
				{
					Main.player[Main.myPlayer].PutItemInInventory(item.type);
				}
				else
				{
					if(Main.rand.Next(2) == 0)
					{
						Item.NewItem(
						(int)Main.player[Main.myPlayer].position.X, 
						(int)Main.player[Main.myPlayer].position.Y, 
						Main.player[Main.myPlayer].width / 2, 
						Main.player[Main.myPlayer].height / 2, ItemID.BottledWater, 1, false, 0);
					}
					if(Main.rand.Next(2) == 0)
					{
						Item.NewItem(
						(int)Main.player[Main.myPlayer].position.X, 
						(int)Main.player[Main.myPlayer].position.Y, 
						Main.player[Main.myPlayer].width / 2, 
						Main.player[Main.myPlayer].height / 2, ItemID.BottledHoney, 1, false, 0);
					}
				}
				
				Main.NewText("Bought 1 Drink");
			}
			else
			{
				Main.NewText("You don't have enough Money");
			}
		
            return;
        }
		
#endregion
    }
}