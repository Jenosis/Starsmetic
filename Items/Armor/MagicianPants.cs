using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class MagicianPants : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Adds 17% Magic Damage, 5% Crit, and 13% Speed");
		}


		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 9;
			item.defense = 20;
		}
		public override void UpdateEquip(Player player)
		{
			player.magicDamage += 0.17f;
			player.magicCrit = 5;
			player.moveSpeed += 0.13f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Mantilum", 40);
			recipe.AddIngredient(ItemID.NebulaLeggings,1);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}