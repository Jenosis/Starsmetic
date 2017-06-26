using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CosmeticVariety.Tiles {
public class InventorsWorkshop : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
		TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
        TileObjectData.addTile(Type);
		dustType = mod.DustType("Pixel");
		adjTiles = new int[]{TileID.TinkerersWorkbench, TileID.HeavyWorkBench};
		
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(i * 16, j * 16, 48, 48, mod.ItemType("InventorsWorkshop"));
    }
}}