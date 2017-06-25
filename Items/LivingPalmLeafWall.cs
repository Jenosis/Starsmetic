using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class LivingPalmLeafWall : ModItem
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
        item.createWall = mod.WallType("LivingPalmLeafWall");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.PalmWood, 1);
		recipe.AddTile(304);
        recipe.SetResult(this, 4);
        recipe.AddRecipe();
    }
}}