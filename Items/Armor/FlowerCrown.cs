using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class FlowerCrown : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Adds 2% Magic Damage, 1% Crit");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;			
			item.value = 100;
			item.rare = 1;
            item.autoReuse = true;
            item.defense = 2;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("FlowerRobe");
		}
		public override void UpdateEquip(Player player)
		{
			player.magicDamage += 0.02f;
			player.magicCrit = 1;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased max mana capacity";
            player.statManaMax2 += 10;
        }
		public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
		{
			drawHair = true;
			drawAltHair = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WeirdlyColoredPetal", 30);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}