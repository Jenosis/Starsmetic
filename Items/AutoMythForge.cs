using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class AutoMythForge : ModItem
{
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
		item.createTile = mod.TileType("AutoMythForge");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.Autohammer, 1);
		recipe.AddIngredient(null,"MythicAdamantiteForge", 1);
		recipe.AddTile(18);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.Autohammer, 1);
		recipe.AddIngredient(null,"MythicTitaniumForge", 1);
		recipe.AddTile(18);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}