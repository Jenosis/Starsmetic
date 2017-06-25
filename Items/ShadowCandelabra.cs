using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class ShadowCandelabra : ModItem
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
        item.createTile = mod.TileType("ShadowCandelabra");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "ShadowEssence", 5);
		recipe.AddIngredient(ItemID.CursedTorch, 3);
		recipe.AddTile(null,"ShadowExtraltar");
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}