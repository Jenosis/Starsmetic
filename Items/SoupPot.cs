using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class SoupPot : ModItem
{
    public override void SetDefaults()
    {
		item.UseSound = SoundID.Item3;
		item.useStyle = 2;
		item.useTurn = true;
		item.useAnimation = 17;
		item.useTime = 17;
		item.maxStack = 30;
		item.consumable = true;
		item.width = 10;
		item.height = 10;
		item.buffType = 26;
		item.buffTime = 216000;
		item.rare = 1;
		item.value = 2000;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"DecorativeSoupPot", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.BowlofSoup, 2);
		recipe.AddTile(18);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
    }
}}