using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class Coffee : ModItem
{
    public override void SetDefaults()
    {
        item.width = 12;
        item.height = 12;
        item.maxStack = 999;
        item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 20;
        item.useStyle = 2;
		item.UseSound = SoundID.Item3;
        item.consumable = true;
        item.buffType = mod.BuffType("Jitters");
        item.buffTime = 22000 ;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"BeverageCup", 1);
		recipe.AddTile(null,"BeverageBrewer");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}