using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class CookBook : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("A book of Grandma's best recipes!");
	}
    public override void SetDefaults()
    {
        item.width = 12;
        item.height = 12;
        item.maxStack = 999;
        item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 7;
        item.useStyle = 1;
        item.consumable = true;
		item.createTile = mod.TileType("CookBook");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"Paper",20);
		recipe.AddTile(101);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}