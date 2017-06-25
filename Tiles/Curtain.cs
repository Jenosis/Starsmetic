using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Enums;
using Terraria.DataStructures;

namespace CosmeticVariety.Tiles {
public class Curtain : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = false;
		Main.tileRope[Type] = true;
        Main.tileLavaDeath[Type] = false;
		drop = mod.ItemType("Curtain");
        AddMapEntry(new Color(85, 63, 101));
		dustType = mod.DustType("Pixel");
		
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}