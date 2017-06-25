using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CosmeticVariety.Tiles {
public class DreamFountain : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
		Main.tileTable[Type] = true;
		animationFrameHeight = 54;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
        TileObjectData.addTile(Type);
		dustType = mod.DustType("Stardust");
		
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
			frame %= 6;
		}
	}
    public override void NearbyEffects(int i, int j, bool closer)
    {
        if (closer)
        {
            Main.player[Main.myPlayer].AddBuff(mod.BuffType("Dreamstate"), 10);
        }
    }
	public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(i * 16, j * 16, 48, 48, mod.ItemType("DreamFountain"));
    }
}}