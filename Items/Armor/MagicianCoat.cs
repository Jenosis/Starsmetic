using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class MagicianCoat : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Adds 17% MAgic Damage nd 5% Crit");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 9;
			item.defense = 25;
		}
		public override void UpdateEquip(Player player)
		{
			player.magicDamage += 0.17f;
			player.magicCrit = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Mantilum", 50);
			recipe.AddIngredient(ItemID.NebulaBreastplate,1);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}