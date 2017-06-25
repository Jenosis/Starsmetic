using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Enums;
using Terraria.DataStructures;

namespace CosmeticVariety.Tiles {
public class Silk : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
		TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.Table, TileObjectData.newTile.Width, 0);
        TileObjectData.addTile(Type);
		drop = (ItemID.Silk);
		dustType = mod.DustType("Pixel");
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}