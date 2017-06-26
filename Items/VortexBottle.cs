using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class VortexBottle : ModItem
{
    public override void SetDefaults()
    {
        item.width = 28;
        item.height = 14;
        item.maxStack = 999;
        item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 10;
        item.useStyle = 1;
        item.consumable = true;
        item.value = 150;
        item.createTile = mod.TileType("VortexBottle");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.Bottle, 1);
		recipe.AddIngredient(ItemID.FallenStar, 1);
		recipe.AddIngredient(ItemID.FragmentVortex, 1);
		recipe.AddTile(412);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}