using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class Hellfries : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("Ash Potato Fries. Yum!");
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
		item.buffType = mod.BuffType("Hot") ;
		item.buffTime = 15000 ;
    }
	public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"AshPotato", 1);
		recipe.AddTile(96);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"DecorativeHellfries", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
	}
}}