using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Enums;
using Terraria.DataStructures;

namespace CosmeticVariety.Tiles {
public class WanderingEyeLamp : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
		Main.tileLighted[Type] = true;
		animationFrameHeight = 36;
		TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table, TileObjectData.newTile.Width, 0);
        TileObjectData.newTile.UsesCustomCanPlace = true;
        TileObjectData.newTile.Width = 2;
		TileObjectData.newTile.Height = 2;
		TileObjectData.newTile.CoordinateHeights = new int[]{ 16, 16};
		TileObjectData.newTile.CoordinateWidth = 16;
		TileObjectData.newTile.CoordinatePadding = 2;
        TileObjectData.addTile(Type);
        AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTorch);
		dustType = mod.DustType("Pixel");
    }
    public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
    {
        r = 0.7f;
        g = 0.7f;
        b = 0.7f;
    }
	public override void AnimateTile(ref int frame, ref int frameCounter)
	{
		frameCounter++;
		if(frameCounter >= 12) //replace 10 with duration of frame in ticks
		{
			frameCounter = 0;
			frame++;
			frame %= 8;
		}
	}
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
	
    public override void KillMultiTile(int i, int j,int frameX, int frameY)
    {
        Item.NewItem(i * 16, j * 16, 32, 32, mod.ItemType("WanderingEyeLamp"));
    }

}}