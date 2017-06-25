using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CosmeticVariety.Tiles {
public class MythicAdamantiteForge : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileLavaDeath[Type] = true;
		Main.tileLighted[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style4x2); //this style already takes care of direction for us
		TileObjectData.newTile.CoordinateHeights = new int[]{ 16, 18 };
        TileObjectData.addTile(Type);
		dustType = mod.DustType("Pixel");
        adjTiles = new int[]{TileID.MythrilAnvil, TileID.AdamantiteForge, TileID.Anvils, TileID.Furnaces, TileID.Hellforge};
    }
	public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
    {
        r = 0.35f;
        g = 0.2f;
        b = 0.1f;
    }

    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = 1;
    }
    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(i * 16, j * 16, 64, 32, mod.ItemType("MythicAdamantiteForge"));
    }

}}