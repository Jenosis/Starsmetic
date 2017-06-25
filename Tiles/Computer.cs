using System;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;


namespace CosmeticVariety.Tiles {
public class Computer : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
		animationFrameHeight = 36;
        TileObjectData.newTile.UsesCustomCanPlace = true;
        TileObjectData.newTile.Width = 2;
		TileObjectData.newTile.Height = 2;
		TileObjectData.newTile.CoordinateHeights = new int[]{ 16,16};
		TileObjectData.newTile.CoordinateWidth = 16;
		TileObjectData.newTile.CoordinatePadding = 2;
		TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.Table| AnchorType.SolidTile | AnchorType.SolidWithTop, TileObjectData.newTile.Width, 0);
        TileObjectData.addTile(Type);
		dustType = mod.DustType("Pixel");
		
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
    public override void AnimateTile(ref int frame, ref int frameCounter)
	{
		frameCounter++;
		if(frameCounter >= 10) //replace 10 with duration of frame in ticks
		{
			frameCounter = 0;
			frame++;
			frame %= 2;
		}
	}
	public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(i * 16, j * 16, 32, 32, mod.ItemType("Computer"));
    }

}}