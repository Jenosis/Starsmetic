using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class FloralFabric : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("A flower petal based fabric teeming with botanical power");
	}
    public override void SetDefaults()
    {
        item.width = 12;
        item.height = 12;
        item.maxStack = 999;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"Gossamer", 1);
		recipe.AddIngredient(null,"WeirdlyColoredPetal",4);
		recipe.AddIngredient(ItemID.PixieDust, 3);
		recipe.AddTile(134);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}