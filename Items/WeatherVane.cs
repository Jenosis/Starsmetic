using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class WeatherVane : ModItem
{
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
        item.createTile = mod.TileType("WeatherVane");
    }
    public override void AddRecipes()
    {
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.IronBar, 7);
		recipe.AddTile(16);
        recipe.SetResult(this);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.LeadBar, 7);
		recipe.AddTile(16);
        recipe.SetResult(this);
    }
}}