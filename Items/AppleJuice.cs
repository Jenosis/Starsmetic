using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class AppleJuice : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("It's like Christmas up in here!");
	}
    public override void SetDefaults()
    {
        item.width = 12;
        item.height = 12;
        item.maxStack = 999;
        item.useTurn = true;
        item.useAnimation = 20;
        item.useTime = 20;
        item.useStyle = 2;
		item.UseSound = SoundID.Item3;
        item.consumable = true;
        item.buffType = mod.BuffType("Energized");
        item.buffTime = 20000 ;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"Apple", 1);
		recipe.AddTile(18);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"DecorativeAppleJuice", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}