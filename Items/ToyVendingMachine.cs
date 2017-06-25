using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class ToyVendingMachine : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("A fun little machine that dispenses toy capsules");
	}
    public override void SetDefaults()
    {
        item.width = 28;
        item.height = 14;
        item.maxStack = 99;
        item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 10;
        item.useStyle = 1;
        item.consumable = true;
        item.value = 150000;
		item.createTile = mod.TileType("ToyVendingMachine");
    }

    public override void AddRecipes()
    {

    }
}}