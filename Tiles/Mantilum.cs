using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Tiles {
public class Mantilum : ModTile
{
    public override void SetDefaults()
    {
        Main.tileSolid[Type] = true;
        Main.tileBlockLight[Type] = true;
        Main.tileLighted[Type] = true;
		Main.tileSpelunker[Type] = true;
		soundType = 21;
		minPick = 210;
        drop = mod.ItemType("Mantilum");
        AddMapEntry(new Color(108, 39, 134));
		ModTranslation name = CreateMapEntryName();
		name.SetDefault("Mantilum");
		dustType = mod.DustType("Nebula");
    }

    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
	public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
    {
        r = 0.5f;
        g = 0.0f;
        b = 0.5f;
    }
}}