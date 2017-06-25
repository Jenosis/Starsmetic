using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class PerfectlyGenericObject : ModItem
{
    public override void SetDefaults()
    {
        item.width = 24;
        item.height = 25;
        item.maxStack = 999;
        item.value = 100;
        item.rare = 1;
		item.consumable = true;
    }

    public override void AddRecipes()
    {
		ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.Cog);
		recipe.AddIngredient(ItemID.DirtBlock);
        recipe.AddIngredient(ItemID.Gel);
		recipe.AddTile(220);
		recipe.SetResult(this, 3);
        recipe.AddRecipe();  
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"PerfectlyGenericBlock");
		recipe.AddTile(18);
		recipe.SetResult(this, 1);
        recipe.AddRecipe(); 		
    }
}}