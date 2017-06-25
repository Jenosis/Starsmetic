using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class CraftCandy : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("Useful for making Sweet Furniture");
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
        item.consumable = false;
        item.value = 150;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"Sugar", 2);
		recipe.AddTile(null,"Oven");
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}