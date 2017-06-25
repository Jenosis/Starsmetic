using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CosmeticVariety.Tiles {
public class AegisContraption : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
		Main.tileTable[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
        TileObjectData.addTile(Type);
		dustType = mod.DustType("Stardust");
		adjTiles = new int[]{TileID.Containers};
		
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
	public override void RightClick(int i, int j)
	{
		Main.player[Main.myPlayer].AddBuff(BuffID.Archery, 35000);
		Main.player[Main.myPlayer].AddBuff(BuffID.AmmoReservation, 35000);
		Main.player[Main.myPlayer].AddBuff(BuffID.Clairvoyance, 35000);
		Main.player[Main.myPlayer].AddBuff(BuffID.Endurance, 35000);
		Main.player[Main.myPlayer].AddBuff(BuffID.MagicPower, 35000);
		Main.player[Main.myPlayer].AddBuff(BuffID.Sharpened, 35000);
	}
	public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(i * 16, j * 16, 48, 48, mod.ItemType("AegisContraption"));
    }
}}