using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class HotNSpicyFries: ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("Extra spicy looking fries. Sure to please fans of heat.");
	}
    public override void SetDefaults()
    {
        item.width = 12;
        item.height = 12;
        item.maxStack = 99;
        item.useTurn = true;
        item.useAnimation = 15;
        item.useTime = 30;
        item.useStyle = 2;
		item.value = 25;
		item.UseSound = SoundID.Item2;
        item.consumable = true;
		item.buffType = mod.BuffType("HotnSpicy") ;
		item.buffTime = 12000 ;
    }
	public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"AshPotato", 1);
		recipe.AddIngredient(null,"HotPepper", 1);
		recipe.AddTile(96);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"Hellfries", 1);
		recipe.AddIngredient(null,"HotPepper", 1);
		recipe.AddTile(96);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"DecorativeSpicyHellfries", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
	}
}}