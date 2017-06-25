using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class GothicSink : ModItem
{
    public override void SetDefaults()
    {
        item.width = 28;
        item.height = 14;
        item.maxStack = 99;
        item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 10;
        item.useStyle = 1;
        item.consumable = true;
        item.value = 150;
        item.createTile = mod.TileType("GothicSink");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.Bone, 6);
		recipe.AddIngredient(ItemID.WaterBucket, 1);
		recipe.AddTile(18);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}