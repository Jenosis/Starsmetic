using System;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;


namespace CosmeticVariety.Tiles {
public class Telescope : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.UsesCustomCanPlace = true;
        TileObjectData.newTile.Width = 3;
		TileObjectData.newTile.Height = 3;
		TileObjectData.newTile.CoordinateHeights = new int[]{ 16,16,16};
		TileObjectData.newTile.CoordinateWidth = 16;
		TileObjectData.newTile.CoordinatePadding = 2;
		TileObjectData.newTile.Direction = TileObjectDirection.PlaceLeft;
        TileObjectData.newTile.StyleWrapLimit = 2;
        TileObjectData.newTile.StyleMultiplier = 2;
        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
        TileObjectData.newAlternate.Direction = TileObjectDirection.PlaceRight;
        TileObjectData.addAlternate(1);
        TileObjectData.newSubTile.CopyFrom(TileObjectData.newTile);
        TileObjectData.newSubTile.LinkedAlternates = true;
        TileObjectData.newSubTile.LavaDeath = false;
        TileObjectData.newSubTile.LavaPlacement = LiquidPlacement.Allowed;
        TileObjectData.addSubTile(Type);
		TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.Table| AnchorType.SolidTile | AnchorType.SolidWithTop, TileObjectData.newTile.Width, 0);
        TileObjectData.addTile(Type);
		dustType = mod.DustType("Pixel");
    }
	public override void NearbyEffects(int i, int j, bool closer)
    {
        if (closer)
		{
			CosmeticWorld.accCalendarHelper = true;
		}
    }

    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(i * 16, j * 16, 32, 32,mod.ItemType("Telescope"));
    }
}}