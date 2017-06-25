using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class Wheat : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("Nice golden wheat to make flour with");
	}
    public override void SetDefaults()
    {
        item.width = 12;
        item.height = 12;
        item.maxStack = 999;
        item.useTurn = true;
        item.autoReuse = true;
		item.value = 45;
    }
	    public override void AddRecipes()
    {
		ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.Hay, 1);
        recipe.SetResult(this, 3);
        recipe.AddRecipe();
    }
}}