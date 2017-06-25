using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class Porcelain : ModItem
{
    public override void SetDefaults()
    {
        item.width = 26;
        item.height = 26;
        item.maxStack = 999;
        item.value = 100;
        item.rare = 1;
    }

    public override void AddRecipes()
    {
		ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.StoneBlock);
		recipe.AddIngredient(ItemID.ClayBlock);
        recipe.SetResult(this, 2);
        recipe.AddRecipe();     
    }
}}