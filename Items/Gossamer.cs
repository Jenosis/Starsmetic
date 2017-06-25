using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class Gossamer : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("A very fine fabric that can be fashioned into something more dazzling");
	}
    public override void SetDefaults()
    {
        item.width = 12;
        item.height = 12;
        item.maxStack = 999;
        item.useTurn = true;
		item.value = 2500;
    }
	
}}