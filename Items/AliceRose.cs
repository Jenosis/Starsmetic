using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class AliceRose : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("We're painting the roses red!");
	}
    public override void SetDefaults()
    {
        item.width = 28;
        item.height = 14;
        item.maxStack = 999;
        item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 10;
        item.useStyle = 1;
        item.consumable = true;
        item.createTile = mod.TileType("AliceRose");
    }

    public override void AddRecipes()
    {
		ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"WeirdlyColoredPetal", 1);
		recipe.AddTile(18);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();

    }
}}