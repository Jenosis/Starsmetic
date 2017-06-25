using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class LivingPetalWand : ModItem
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
		item.tileWand = mod.ItemType("Floralwood");
        item.consumable = false;
        item.value = 150;
        item.createTile = mod.TileType("PetalBlock");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"Floralwood", 10);
		recipe.AddIngredient(null,"WeirdlyColoredPetal", 2);
		recipe.AddTile(304);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}