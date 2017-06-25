using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class TV : ModItem
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
        item.createTile = mod.TileType("TV");
    }
    public override void AddRecipes()
    {
		ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.Wire, 10);
		recipe.AddIngredient(ItemID.IronBar, 3);
		recipe.AddTile(18);
        recipe.SetResult(this);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.Wire, 10);
		recipe.AddIngredient(ItemID.LeadBar, 3);
		recipe.AddTile(18);
        recipe.SetResult(this);
    }
}}