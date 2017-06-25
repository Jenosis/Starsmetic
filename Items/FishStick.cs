using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class FishStick : ModItem
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
		item.buffTime = 60000 ;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"Flour", 3);
		recipe.AddIngredient(ItemID.Bass, 2);
		recipe.AddTile(null,"Oven");
        recipe.SetResult(this, 2);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"Flour", 3);
		recipe.AddIngredient(ItemID.AtlanticCod, 2);
		recipe.AddTile(null,"Oven");
        recipe.SetResult(this, 2);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"DecorativeFishStick", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}