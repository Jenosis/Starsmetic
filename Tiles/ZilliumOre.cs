using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Tiles {
public class ZilliumOre : ModTile
{
    public override void SetDefaults()
    {
        Main.tileSolid[Type] = true;
        Main.tileBlockLight[Type] = true;
		Main.tileSpelunker[Type] = true;
		soundType = 21;
		minPick = 180;
        drop = mod.ItemType("ZilliumOre");
        AddMapEntry(new Color(21, 14, 74));
		ModTranslation name = CreateMapEntryName();
		name.SetDefault("Zillium");
		dustType = mod.DustType("Stardust");
    }

    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}