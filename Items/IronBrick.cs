using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class IronBrick : ModItem
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
        item.createTile = mod.TileType("IronBrick");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.IronOre, 1);
		recipe.AddIngredient(ItemID.StoneBlock,1);
		recipe.AddTile(17);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
    }
}}