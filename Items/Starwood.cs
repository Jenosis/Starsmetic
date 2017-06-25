using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class Starwood : ModItem
{
    public override void SetDefaults()
    {
        item.width = 28;
        item.height = 28;
        item.maxStack = 999;
        item.value = 0;
        item.rare = 0;
		item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 7;
        item.useStyle = 1;
		item.consumable = true;
		item.createTile = mod.TileType("Starwood");
    }

    public override void AddRecipes()
    {
		ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "StarwoodWall",4);
		recipe.AddTile(18);
        recipe.SetResult(this,1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "StarwoodLatticeWall",4);
		recipe.AddTile(18);
        recipe.SetResult(this,1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "StarwoodFence",4);
		recipe.AddTile(18);
        recipe.SetResult(this,1);
        recipe.AddRecipe();
    }
}}