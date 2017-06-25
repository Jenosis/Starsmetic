using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class DreamFountain : ModItem
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
        item.useStyle = 1;
        item.consumable = true;
		item.createTile = mod.TileType("DreamFountain");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.FallenStar, 10);
		recipe.AddIngredient(ItemID.PureWaterFountain, 1);
		recipe.AddIngredient(ItemID.BloodWaterFountain, 1);
		recipe.AddIngredient(ItemID.IcyWaterFountain, 1);
		recipe.AddIngredient(ItemID.DesertWaterFountain, 1);
		recipe.AddIngredient(ItemID.JungleWaterFountain, 1);
		recipe.AddIngredient(ItemID.CorruptWaterFountain, 1);
		recipe.AddIngredient(ItemID.CrimsonWaterFountain, 1);
		recipe.AddIngredient(ItemID.HallowedWaterFountain, 1);
		recipe.AddTile(412);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}