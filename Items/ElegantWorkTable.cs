using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class ElegantWorkTable : ModItem
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
		item.createTile = mod.TileType("ElegantWorkTable");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null,"ElegantTable", 1);
		recipe.AddIngredient(null,"ElegantWorkbench", 1);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}