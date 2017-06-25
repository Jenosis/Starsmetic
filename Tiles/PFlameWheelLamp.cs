using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Enums;
using Terraria.DataStructures;

namespace CosmeticVariety.Tiles {
public class PFlameWheelLamp : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
		Main.tileLighted[Type] = true;
		animationFrameHeight = 36;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2);
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
		if(frameCounter >= 8) //replace 10 with duration of frame in ticks
		{
			frameCounter = 0;
			frame++;
			frame %= 4;
		}
	}
	public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
    {
        r = 0.7f;
        g = 0.5f;
        b = 0.4f;
    }
	public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(i * 16, j * 16, 16, 32, mod.ItemType("PFlameWheelLamp"));
    }
}}