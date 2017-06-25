using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class WeirdlyColoredPetal : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("Looks oddly colored");
	}
    public override void SetDefaults()
    {
        item.width = 20;
        item.height = 20;
        item.maxStack = 999;
        item.value = 100;
        item.rare = 1;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"Rose",1);
        recipe.SetResult(this, 5);
        recipe.AddRecipe();

        recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "Tulip", 1);
        recipe.SetResult(this, 5);
        recipe.AddRecipe();

        recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "Iris", 1);
        recipe.SetResult(this, 5);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "Lotus", 1);
        recipe.SetResult(this, 5);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "TigerLily", 1);
        recipe.SetResult(this, 5);
        recipe.AddRecipe();


        recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"PurpleFlowerBlock");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"RedFlowerBlock");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"BlueFlowerBlock");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"OrangeFlowerBlock");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"YellowFlowerBlock");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}