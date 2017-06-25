using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class LivingShadewoodWand : ModItem
{
    public override void SetDefaults()
    {
        item.width = 28;
        item.height = 14;
        item.maxStack = 1;
        item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 10;
        item.useStyle = 1;
		item.tileWand = 911;
        item.consumable = false;
        item.value = 150;
        item.createTile = mod.TileType("LivingShadewood");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.Shadewood, 10);
		recipe.AddIngredient(ItemID.Vertebrae, 2);
		recipe.AddTile(304);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}