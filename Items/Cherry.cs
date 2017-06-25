using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class Cherry : ModItem
{
    public override void SetDefaults()
	{
        item.width = 12;
        item.height = 12;
		item.value = 1000;
        item.maxStack = 999;
        item.useTurn = true;
        item.useAnimation = 15;
        item.useTime = 30;
        item.useStyle = 2;
		item.UseSound = SoundID.Item2;
        item.consumable = true;
		item.buffType = 26 ;
        item.buffType = mod.BuffType("Energized");
        item.buffTime = 9000 ;
    }

    public override void AddRecipes()
    {
		ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"DecorativeCherry", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();    
    }
}}