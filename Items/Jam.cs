using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class Jam : ModItem
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
		item.UseSound = SoundID.Item5;
        item.consumable = true;
		item.buffType = 26 ;
        item.buffType = mod.BuffType("Energized");
        item.buffTime = 9000 ;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"Apple", 1);
		recipe.AddIngredient(ItemID.Bottle, 1);
		recipe.AddTile(null,"CanningStation");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"Lemon", 1);
		recipe.AddIngredient(ItemID.Bottle, 1);
		recipe.AddTile(null,"CanningStation");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"Cherry", 1);
		recipe.AddIngredient(ItemID.Bottle, 1);
		recipe.AddTile(null,"CanningStation");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"DecorativeJam", 1);
		recipe.AddTile(null,"CanningStation");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}