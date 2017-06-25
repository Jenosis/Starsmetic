using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class NatureCloak : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Adds 17% Ranged Damage nd 5% Crit");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 9;
			item.defense = 30;
		}
		public override void UpdateEquip(Player player)
		{
			player.rangedDamage += 0.17f;
			player.rangedCrit = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Veridanite", 50);
			recipe.AddIngredient(ItemID.VortexBreastplate,1);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}