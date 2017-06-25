using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class PinaColada : ModItem
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
		item.UseSound = SoundID.Item28;
        item.consumable = true;
		item.buffType = 25 ;
		item.buffTime = 20000 ;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"CoconutCup", 1);
		recipe.AddTile(94);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"DecorativePinaColada", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}