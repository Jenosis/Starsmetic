using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class Apple : ModItem
{
    public override void SetDefaults()
    {
        item.width = 12;
        item.height = 12;
        item.maxStack = 999;
        item.useTurn = true;
        item.useAnimation = 15;
        item.useTime = 30;
        item.useStyle = 2;
		item.value = 25;
		item.UseSound = SoundID.Item2;
        item.consumable = true;
		item.buffType = 26 ;
        item.buffType = mod.BuffType("Energized");
		item.buffTime = 1800 ;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"DecorativeApple", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}