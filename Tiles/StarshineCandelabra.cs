using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace CosmeticVariety.Tiles {
public class StarshineCandelabra : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
		Main.tileLighted[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
        TileObjectData.addTile(Type);
        AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTorch);
		dustType = mod.DustType("Stardust");
		adjTiles = new int[]{TileID.Candelabras};
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
        Item.NewItem(i * 16, j * 16, 32, 32, mod.ItemType("StarshineCandelabra"));
    }
}}