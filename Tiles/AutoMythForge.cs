using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CosmeticVariety.Tiles {
public class AutoMythForge : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
		Main.tileLighted[Type] = true;
		animationFrameHeight = 54;
		TileObjectData.newTile.CopyFrom(TileObjectData.Style6x3);
        TileObjectData.addTile(Type);
		dustType = mod.DustType("Pixel");
		adjTiles = new int[]{TileID.MythrilAnvil, TileID.AdamantiteForge, TileID.Autohammer, TileID.Hellforge, TileID.Anvils, TileID.Furnaces};
    }
	public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
    {
        r = 0.35f;
        g = 0.2f;
        b = 0.1f;
    }

	public override void AnimateTile(ref int frame, ref int frameCounter)
	{
		frameCounter++;
		if(frameCounter >= 8) //replace 10 with duration of frame in ticks
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
    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(i * 16, j * 16, 96, 48, mod.ItemType("AutoMythForge"));
    }
}}