using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CosmeticVariety.Tiles {
public class GumdropCandle : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
		Main.tileLighted[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.StyleOnTable1x1);
        TileObjectData.addTile(Type);
		drop = mod.ItemType("GumdropCandle");
        AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTorch);
		dustType = mod.DustType("Pixel");
		adjTiles = new int[]{TileID.Candles};
    }
    public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
    {
        r = 0.8f;
        g = 1.2f;
        b = 0.8f;
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}