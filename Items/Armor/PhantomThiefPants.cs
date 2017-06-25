using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor {
	[AutoloadEquip(EquipType.Legs)]
public class PhantomThiefPants : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("Trousers of the leader of heart thieves");
	}


    public override void SetDefaults()
    {
        item.width = 18;
        item.height = 18;
        item.value = 10000;
		item.vanity = true;
        item.rare = 2;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.BlackThread, 5);
		recipe.AddIngredient(ItemID.Silk, 10);
        recipe.AddTile(86);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}