using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Tiles {
public class Pallasite : ModTile
{
    public override void SetDefaults()
    {
        Main.tileSolid[Type] = true;
        Main.tileBlockLight[Type] = true;
        Main.tileLighted[Type] = true;
		Main.tileSpelunker[Type] = true;
		soundType = 21;
		minPick = 210;
        drop = mod.ItemType("Pallasite");
        AddMapEntry(new Color(113, 46, 24));
		ModTranslation name = CreateMapEntryName();
		name.SetDefault("Pallasite");
		dustType = mod.DustType("Solar");
    }

    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
	public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
    {
        r = 0.5f;
        g = 0.2f;
        b = 0.0f;
    }
}}