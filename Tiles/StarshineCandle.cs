using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CosmeticVariety.Tiles {
public class StarshineCandle : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
		Main.tileLighted[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.StyleOnTable1x1);
        TileObjectData.addTile(Type);
		drop = mod.ItemType("StarshineCandle");
        AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTorch);
		dustType = mod.DustType("Stardust");
		adjTiles = new int[]{TileID.Candles};
    }
	public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
	{
		r = ((float)Main.rand.Next(120,180)/255f); 
		g = ((float)Main.rand.Next(120,180)/255f);
		b = ((float)Main.rand.Next(120,180)/255f);
	}
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(i * 16, j * 16, 16, 16, mod.ItemType("StarshineCandle"));
    }
}}