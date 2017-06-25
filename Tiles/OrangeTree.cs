using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Enums;

namespace CosmeticVariety.Tiles
{
	public class OrangeTree : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileCut[Type] = false;
			//Main.tileAlch[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.StyleDye);
			//TileObjectData.newTile.UsesCustomCanPlace = true;
			//TileObjectData.newTile.Width = 1;
			//TileObjectData.newTile.Height = 1;
			TileObjectData.newTile.CoordinatePadding = 2;
			TileObjectData.newTile.CoordinateHeights=new int[]{48};
			TileObjectData.newTile.DrawYOffset= -30;
			TileObjectData.newTile.CoordinateWidth = 34;
			TileObjectData.newTile.StyleHorizontal = true;
			Main.tileNoFail[Type] = true;
			//Main.tileLavaDeath[Type] = true;
			//dustType = -1;
			//disableSmartCursor = true;
			//AddMapEntry(new Color(13, 88, 130), "Banner");
			//TileObjectData.newTile.Width = 1;
			//TileObjectData.newTile.Height = 1;
			//TileObjectData.newTile.Origin = Point16.Zero;
			//TileObjectData.newTile.UsesCustomCanPlace = true;
			//TileObjectData.newTile.CoordinateHeights = new int[]
			//{
			//	20
			//};
			//TileObjectData.newTile.CoordinateWidth = 16;
			//TileObjectData.newTile.CoordinatePadding = 2;
			//TileObjectData.newTile.DrawYOffset = -1;
			//TileObjectData.newTile.StyleHorizontal = true;
			//TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.AlternateTile, TileObjectData.newTile.Width, 0);
			//TileObjectData.newTile.WaterPlacement = LiquidPlacement.NotAllowed;
			//TileObjectData.newTile.LavaDeath = true;
			//TileObjectData.newTile.LavaPlacement = LiquidPlacement.NotAllowed;
			//TileObjectData.addBaseTile(out TileObjectData.StyleAlch);
			AddMapEntry(new Color(13, 88, 130));
			TileObjectData.newTile.AnchorValidTiles = new int[]
			{
				2, //TileID.Grass
				60,//TileID.JungleGrass
				109,//TileID.HallowedGrass
				mod.TileType<FertileSoil>(),
				mod.TileType<Starsoil>()
			};
			TileObjectData.newTile.AnchorAlternateTiles = new int[]
			{
				78, //ClayPot
				TileID.PlanterBox
			};
			TileObjectData.addTile(Type);
			//drop = mod.ItemType()
		}
		public override void SetSpriteEffects(int i, int j, ref SpriteEffects spriteEffects)
		{
			if (i % 2 == 1)
			{
				spriteEffects = SpriteEffects.FlipHorizontally;
			}
		}

		public override bool Drop(int i, int j)
		{
			int stage = Main.tile[i, j].frameX / 34;
			if (stage == 2)
			{
				Item.NewItem(i * 16, j * 16, 0, 0, mod.ItemType("OrangeSeed"));
				Item.NewItem(i * 16, j * 16, 0, 0, mod.ItemType("Orange"));
			}
			return false;
		}

		public override void RandomUpdate(int i, int j)
		{
			if (Main.tile[i, j].frameX == 0)
			{
				Main.tile[i, j].frameX += 34;
			}
			else if (Main.tile[i, j].frameX == 34)
			{
				Main.tile[i, j].frameX += 34;
			}
		}

	}
}
