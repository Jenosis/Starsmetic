using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class AshPotato : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("Seems tasteless on it's own. Could be made into something better.");
	}
    public override void SetDefaults()
    {
        item.width = 12;
        item.height = 12;
        item.maxStack = 99;
        item.useTurn = true;
        item.useAnimation = 15;
        item.useTime = 30;
        item.useStyle = 2;
		item.value = 25;
		item.UseSound = SoundID.Item2;
        item.consumable = true;
		item.buffType = 26 ;
		item.buffTime = 2000 ;
    }
	public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"DecorativeAshPotato", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
	}
}}