using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor {
	[AutoloadEquip(EquipType.Legs)]
public class ZillyGreaves : ModItem
{

	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("Increases Speed by 8%");
	}
	public override void SetDefaults()
    {
        item.width = 18;
        item.height = 18;
        item.value = 10000;
		item.defense = 12;
        item.rare = 5;
    }
	public override void UpdateEquip(Player player)
	{
		player.moveSpeed += 0.08f;
	}

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"ZilliumBar",18);
        recipe.AddTile(134);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}