using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class LivingPearlwoodYellowLeafWand : ModItem
{
    public override void SetDefaults()
    {
        item.width = 28;
        item.height = 14;
        item.maxStack = 1;
        item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 10;
        item.useStyle = 1;
		item.tileWand = 621;
        item.consumable = false;
        item.value = 150;
        item.createTile = mod.TileType("LivingPearlwoodLeafYellow");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.Pearlwood, 10);
		recipe.AddIngredient(ItemID.PixieDust, 2);
		recipe.AddIngredient(ItemID.CrystalShard, 1);
		recipe.AddTile(304);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}