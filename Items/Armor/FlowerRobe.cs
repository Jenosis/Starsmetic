using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class FlowerRobe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Adds 5% Magic Damage, 5% Crit. and 50 mana");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000;
			item.rare = 1;
			item.defense = 3;
		}
		public override void UpdateEquip(Player player)
		{
			player.magicDamage += 0.05f;
			player.magicCrit = 5;
			player.statManaMax2 += 50;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WeirdlyColoredPetal", 20);
			recipe.AddIngredient(ItemID.Silk, 8);
			recipe.AddTile(86);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}