using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class Milk : ModItem
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
		//item.value = 25;
		item.UseSound = SoundID.Item3;
        item.consumable = true;
        item.buffType = mod.BuffType("Bloated");
		item.buffTime = 3600 ;
    }
	public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);;
		recipe.AddIngredient(null,"DecorativeMilk",1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
	}
}}