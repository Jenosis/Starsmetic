using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class ShadowEssence : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("An essence gather from green flames and rock from the Corruption");
	}
    public override void SetDefaults()
    {
        item.width = 24;
        item.height = 25;
        item.maxStack = 999;
        item.value = 1000;
        item.rare = 1;
		item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 10;
        item.useStyle = 1;
    }
    public override void AddRecipes()
    {
	ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.CursedFlame,1);
		recipe.AddIngredient(ItemID.EbonstoneBlock,1);
        recipe.AddTile(null,"ShadowExtraltar");
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}