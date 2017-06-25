using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CosmeticVariety.Tiles {
public class Coffee : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
		animationFrameHeight = 18;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
		TileObjectData.newTile.CopyFrom(TileObjectData.StyleOnTable1x1);
        TileObjectData.addTile(Type);
		drop = mod.ItemType("DecorativeCoffee");
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
			frame %= 6;
		}
	}
}}