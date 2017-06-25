using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class CompleteBreakfast: ModItem
{
    public override void SetDefaults()
    {
        item.width = 24;
        item.height = 25;
        item.maxStack = 30;
        item.value = 1000;
        item.rare = 1;
		item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 30;
        item.useTime = 30;
        item.useStyle = 2;
		item.healLife = 135;
		item.UseSound = SoundID.Item2;
		item.potion = true;
        item.consumable = true;
    }
	public override bool UseItem(Player player)
	{
		player.AddBuff(BuffID.WellFed, 100000);
		player.AddBuff(mod.BuffType("Energized"), 3600);
		return true;
	}
    public override void AddRecipes()
    {
		ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"WheatBread", 1);
		recipe.AddIngredient(null,"Egg", 1);
		recipe.AddIngredient(ItemID.Bacon, 1);
		recipe.AddTile(18);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"RyeBread", 1);
		recipe.AddIngredient(null,"Egg", 1);
		recipe.AddIngredient(ItemID.Bacon, 1);
		recipe.AddTile(18);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"DecorativeCompleteBreakfast", 1);
		recipe.AddTile(18);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}