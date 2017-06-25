using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class RyeBread : ModItem
{
    public override void SetDefaults()
    {
        item.width = 12;
        item.height = 12;
        item.maxStack = 999;
        item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 7;
        item.useStyle = 2;
		item.UseSound = SoundID.Item2;
        item.consumable = true;
		item.buffType = 26;
        item.buffType = mod.BuffType("Energized");
        item.buffTime = 45000;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"DecorativeRyeBread", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"Flour", 3);
		recipe.AddTile(null,"Oven");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}