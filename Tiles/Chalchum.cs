using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Tiles {
public class Chalchum : ModTile
{
    public override void SetDefaults()
    {
        Main.tileSolid[Type] = true;
        Main.tileBlockLight[Type] = true;
        Main.tileLighted[Type] = true;
		Main.tileSpelunker[Type] = true;
		soundType = 21;
		minPick = 210;
        drop = mod.ItemType("Chalchum");
		ModTranslation name = CreateMapEntryName();
			name.SetDefault("Chalchum");
        AddMapEntry(new Color(210, 2100, 194));
		dustType = mod.DustType("Stardust");
    }

    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
	public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
    {
        r = 0.5f;
        g = 0.5f;
        b = 0.5f;
    }
}}