using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class StarlightOre : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("The light element from the heavens");
		DisplayName.SetDefault("Star Quartz");
	}
    public override void SetDefaults()
    {
        item.width = 24;
        item.height = 25;
        item.maxStack = 999;
        item.value = 1000;
        item.rare = 1;
		item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 10;
        item.useStyle = 1;
        item.consumable = true;
        item.createTile = mod.TileType("StarlightOre");
    }
    public override void AddRecipes()
    {
    }
}}