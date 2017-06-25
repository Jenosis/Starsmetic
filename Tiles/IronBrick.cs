using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace CosmeticVariety.Tiles {
public class IronBrick : ModTile
{
    public override void SetDefaults()
    {
        Main.tileSolid[Type] = true;
		Main.tileMergeDirt[this.Type] = false;
		Main.tileBlendAll[this.Type] = true;
		soundType = 21;
        drop = mod.ItemType("IronBrick");
        AddMapEntry(new Color(150, 20, 200));
		dustType = mod.DustType("Vortex");
    }
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}