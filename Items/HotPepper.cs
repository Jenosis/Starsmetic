using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class HotPepper : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("A spicy pepper. Good on it's own or in a dish.");
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
		item.buffType = mod.BuffType("Spicy") ;
		item.buffTime = 9000 ;
    }
	public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(null,"DecorativeHotPepper",1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
	}
}}