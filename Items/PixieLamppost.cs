using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class PixieLamppost : ModItem
{
    public override void SetDefaults()
    {
        item.width = 28;
        item.height = 14;
        item.maxStack = 99;
        item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 10;
        item.useStyle = 1;
        item.consumable = true;
        item.value = 150;
        item.createTile = mod.TileType("PixieLamppost");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.PixieDust, 4);
        recipe.AddIngredient(ItemID.Torch, 1);
		recipe.AddIngredient(ItemID.Glass, 2);
		recipe.AddIngredient(ItemID.IronBar, 3);
		recipe.AddTile(16);
        recipe.SetResult(this);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.PixieDust, 4);
        recipe.AddIngredient(ItemID.Torch, 1);
		recipe.AddIngredient(ItemID.Glass, 2);
		recipe.AddIngredient(ItemID.LeadBar, 3);
		recipe.AddTile(16);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}