using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class StarliteCore : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("Starlite condensed into a more malleable form");
	}
    public override void SetDefaults()
    {
        item.width = 12;
        item.height = 12;
        item.maxStack = 999;
		ItemID.Sets.ItemNoGravity[item.type] = true;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"StarliteFragments", 1);
		recipe.AddIngredient(ItemID.SoulofLight,1);
		recipe.AddIngredient(ItemID.SoulofNight,1);
		recipe.AddIngredient(ItemID.FallenStar,1);
		recipe.AddTile(134);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}