using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class CelestialMilkshake : ModItem
{
    public override void SetDefaults()
    {
        item.width = 12;
        item.height = 12;
        item.maxStack = 999;
        item.useTurn = true;
        item.useAnimation = 15;
        item.useTime = 30;
        item.useStyle = 2;
		item.value = 25;
		item.healMana = 105;
		item.UseSound = SoundID.Item3;
        item.consumable = true;
        item.buffType = BuffID.ManaSickness;
    }
	public override bool UseItem(Player player)
	{
		player.AddBuff(BuffID.WellFed, 12000);
		player.AddBuff(BuffID.ManaRegeneration, 15000);
		player.AddBuff(mod.BuffType("Frosty"), 3600);
		return true;
	}

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"StarrySyrup", 1);
		recipe.AddIngredient(null,"IceCream",1);
		recipe.AddTile(null,"ChillMachine");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
		
		recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"DecorativeCelestialMilkshake", 1);
		recipe.AddTile(null,"SculptingStand");
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}