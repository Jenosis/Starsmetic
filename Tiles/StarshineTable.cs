using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CosmeticVariety.Tiles {
public class StarshineTable : ModTile
{
    public override void SetDefaults()
    {
		Main.tileSolidTop[Type] = true;
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileTable[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
		AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
		TileObjectData.newTile.CoordinateHeights = new int[]{ 20, 20 };
        TileObjectData.addTile(Type);
		dustType = mod.DustType("Stardust");
        adjTiles = new int[]{TileID.Tables};
    }


    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = 1;
    }
    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(i * 16, j * 16, 48, 32, mod.ItemType("StarshineTable"));
    }

}}