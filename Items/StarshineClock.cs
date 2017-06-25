using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class StarshineClock : ModItem
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
		item.createTile = mod.TileType("StarshineClock");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.FallenStar, 10);
		recipe.AddIngredient(ItemID.Glass, 6);
		recipe.AddIngredient(ItemID.IronBar, 3);
		recipe.AddTile(106);
        recipe.SetResult(this);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.FallenStar, 10);
		recipe.AddIngredient(ItemID.Glass, 6);
		recipe.AddIngredient(ItemID.LeadBar, 3);
		recipe.AddTile(106);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}