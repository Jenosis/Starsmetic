
using System;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CosmeticVariety.Tiles {
public class LifePlant : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
		Main.tileLighted[Type] = true;
		TileObjectData.newTile.UsesCustomCanPlace = true;
        TileObjectData.newTile.Width = 2;
		TileObjectData.newTile.Height = 3;
		TileObjectData.newTile.CoordinateHeights = new int[]{ 16, 16,16};
		TileObjectData.newTile.CoordinateWidth = 16;
		TileObjectData.newTile.CoordinatePadding = 2;
		TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.Table| AnchorType.SolidTile | AnchorType.SolidWithTop, TileObjectData.newTile.Width, 0);
        TileObjectData.addTile(Type);
		dustType = mod.DustType("Vortex");
    }
	public override void NearbyEffects(int i, int j, bool closer)
    {
        if (closer)
        {
            Main.player[Main.myPlayer].AddBuff(mod.BuffType("LifeAura"), 18);
        }
    }
	public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
    {
        r = 0.4f;
        g = 0.8f;
        b = 0.1f;
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(i * 16, j * 16, 32, 48, mod.ItemType("LifePlant"));
    }
}}