using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class GFlameWheelLamp : ModItem
{
	public override void SetStaticDefaults()
	{
		DisplayName.SetDefault("Green Flame Wheel Lamp");
	}
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
		item.createTile = mod.TileType("GFlameWheelLamp");
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.GreenBrick, 6);
		recipe.AddIngredient(ItemID.Torch, 2);
		recipe.AddTile(16);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}