using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class Telescope : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("Perfect for stargazing!");
	}
    public override void SetDefaults()
    {
        item.width = 24;
        item.height = 25;
        item.maxStack = 999;
        item.value = 100;
        item.rare = 1;
		item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 10;
        item.useStyle = 1;
        item.consumable = true;
        item.createTile = mod.TileType("Telescope");
    }
    public override void AddRecipes()
    {
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.GoldBar, 3);
		recipe.AddIngredient(RecipeGroupID.IronBar, 2);
		recipe.AddIngredient(ItemID.Lens, 1);
		recipe.AddTile(16);
		recipe.SetResult(this, 1);
		recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.PlatinumBar, 3);
		recipe.AddIngredient(RecipeGroupID.IronBar, 2);
		recipe.AddIngredient(ItemID.Lens, 1);
		recipe.AddTile(16);
		recipe.SetResult(this, 1);
		recipe.AddRecipe();
    }
}}