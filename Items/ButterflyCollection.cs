using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class ButterflyCollection : ModItem
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
		item.createTile = mod.TileType("ButterflyCollection");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.JuliaButterfly, 1);
		recipe.AddIngredient(ItemID.MonarchButterfly, 1);
		recipe.AddIngredient(ItemID.ZebraSwallowtailButterfly, 1);
		recipe.AddIngredient(ItemID.SulphurButterfly, 1);
		recipe.AddIngredient(ItemID.UlyssesButterfly, 1);
		recipe.AddIngredient(ItemID.TreeNymphButterfly, 1);
		recipe.AddIngredient(ItemID.RedAdmiralButterfly, 1);
		recipe.AddIngredient(ItemID.PurpleEmperorButterfly, 1);
		recipe.AddIngredient(ItemID.Wood, 5);
		recipe.AddTile(18);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}