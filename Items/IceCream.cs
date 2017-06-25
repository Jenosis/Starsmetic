using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class IceCream : ModItem
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
        item.buffType = mod.BuffType("Frosty");
		item.buffTime = 7200 ;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"Sugar", 2);
		recipe.AddIngredient(ItemID.Snowball,4);
		recipe.AddIngredient(null,"Milk",1);
		recipe.AddTile(null,"ChillMachine");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"DecorativeIceCream", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}