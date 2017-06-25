using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class MythicTitaniumForge : ModItem
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
		item.createTile = mod.TileType("MythicTitaniumForge");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.TitaniumForge, 1);
		recipe.AddIngredient(ItemID.MythrilAnvil, 1);
		recipe.AddTile(18);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.TitaniumForge, 1);
		recipe.AddIngredient(ItemID.OrichalcumAnvil, 1);
		recipe.AddTile(18);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.TitaniumForge, 1);
		recipe.AddIngredient(null,"MythicHellforge", 1);
		recipe.AddTile(18);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}