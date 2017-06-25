using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class Starseed: ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("Shimmering seeds that look like they could grow beautifil celestial plants");
	}
    public override void SetDefaults()
    {
        item.width = 24;
        item.height = 25;
        item.maxStack = 999;
        item.value = 3000;
		item.consumable = true;
        item.rare = 1;
		item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 30;
        item.useStyle = 1;
		item.createTile = mod.TileType("Starplants");
    }
}}