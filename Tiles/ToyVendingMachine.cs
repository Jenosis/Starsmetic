using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CosmeticVariety.Tiles
{
    public class ToyVendingMachine : ModTile
    {
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileSolidTop[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			Main.tileTable[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
			TileObjectData.newTile.Height = 3;
			TileObjectData.newTile.CoordinateHeights = new int[]
			{
				16,
				16,
				16
			};
			TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.Table| AnchorType.SolidTile | AnchorType.SolidWithTop, TileObjectData.newTile.Width, 0);
			TileObjectData.addTile(Type);
			dustType = mod.DustType("Pixel");
		}
	
		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}
		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 48, 64, mod.ItemType("ToyVendingMachine"));
		}
#region overrides

		int value = 0;
	
        public override void RightClick(int i, int j)
        {
			Item item = new Item();
			if(Main.rand.Next(3) == 0)
			{
				item.SetDefaults(mod.ItemType("BlueCapsule"));
			}
			if(Main.rand.Next(3) == 1)
			{
				item.SetDefaults(mod.ItemType("GreenCapsule"));
			}
			if(Main.rand.Next(3) == 2)
			{
				item.SetDefaults(mod.ItemType("PinkCapsule"));
			}
			else
			{
				item.SetDefaults(mod.ItemType("SeafoamCapsule"));
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
						Main.player[Main.myPlayer].height / 2, mod.ItemType("Capsule1"), 1, false, 0);
					}
					else if(Main.rand.Next(2) == 0)
					{
						Item.NewItem(
						(int)Main.player[Main.myPlayer].position.X, 
						(int)Main.player[Main.myPlayer].position.Y, 
						Main.player[Main.myPlayer].width / 2, 
						Main.player[Main.myPlayer].height / 2, mod.ItemType("Capsule2"), 1, false, 0);
					}
					else
					{
						Item.NewItem(
						(int)Main.player[Main.myPlayer].position.X, 
						(int)Main.player[Main.myPlayer].position.Y, 
						Main.player[Main.myPlayer].width / 2, 
						Main.player[Main.myPlayer].height / 2, mod.ItemType("Capsule"), 1, false, 0);
					}
				}
				
				Main.NewText("Bought 1 Capsule");
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