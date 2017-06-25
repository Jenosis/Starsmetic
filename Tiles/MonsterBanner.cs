using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;
namespace CosmeticVariety.Tiles
{
	public class MonsterBanner : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
			TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidBottom, TileObjectData.newTile.Width, 0);
			TileObjectData.newTile.Height = 3;
			TileObjectData.newTile.CoordinateHeights = new int[]{ 16, 16, 16 };
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.StyleWrapLimit = 111;
			TileObjectData.addTile(Type);
			dustType = -1;
			disableSmartCursor = true;
			AddMapEntry(new Color(13, 88, 130));
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Banner");
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			int style = frameX / 18;
			string item;
			switch (style)
			{
				case 0:
					item = "MarbleElementalBanner";
					break;
				case 1:
					item = "BubbleBanner";
					break;
				case 2:
					item = "CosmiCopBanner";
					break;	
				case 3:
					item = "HummingBirdBanner";
					break;
				case 4:
					item = "LunarMothBanner";
					break;
				case 5:
					item = "MeteorMasherBanner";
					break;
				case 6:
					item = "ShamblingBlossomBanner";
					break;
				case 7:
					item = "StarGhoulBanner";
					break;		
				case 8:
					item = "StarrySlimeBanner";
					break;	
				case 9:
					item = "StarzarBanner";
					break;	
				case 10:
					item = "TurnishBanner";
					break;
				case 11:
					item = "WhiteDandelionBanner";
					break;
				case 12:
					item = "YellowDandelionBanner";
					break;
				default:
					return;
			}
			Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType(item));
		}

		public override void NearbyEffects(int i, int j, bool closer)
		{
			if (closer)
			{
				Player player = Main.player[Main.myPlayer];
				int style = Main.tile[i, j].frameX / 18;
				string type;
				switch (style)
				{
					case 0:
						type = "MarbleElemental";
						break;
					case 1:
						type = "Bubble";
						break;
					case 2:
						type = "CosmiCop";
						break;	
					case 3:
						type = "HummingBird";
						break;	
					case 4:
						type = "LunarMoth";
						break;
					case 5:
						type = "MeteorMasher";
						break;
					case 6:
						type = "ShamblingBlossom";
						break;
					case 7:
						type = "StarGhoul";
						break;		
					case 8:
						type = "StarrySlime";
						break;	
					case 9:
						type = "Starzar";
						break;	
					case 10:
						type = "Turnish";
						break;	
					case 11:
						type = "WhiteDandelion";
						break;
					case 12:
						type = "YellowDandelion";
						break;	
					default:
						return;
				}
				player.NPCBannerBuff[mod.NPCType(type)] = true;
				player.hasBanner = true;
			}
		}

		public override void SetSpriteEffects(int i, int j, ref SpriteEffects spriteEffects)
		{
			if (i % 2 == 1)
			{
				spriteEffects = SpriteEffects.FlipHorizontally;
			}
		}
	}
}