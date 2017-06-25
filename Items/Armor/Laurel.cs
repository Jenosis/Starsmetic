using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class Laurel : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Adds 15% Ranged Damage nd 5% Crit");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 9;
			item.defense = 20;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("NatureCloak") && legs.type == mod.ItemType("NatureLeggings");
		}
		public override void UpdateEquip(Player player)
		{
			player.rangedDamage += 0.15f;
			player.rangedCrit = 5;
		}

		public override void UpdateArmorSet(Player player)
		{
            player.setBonus = "A leaf crystal appears to help you. Armor set bonus changes depending what biome you're in";
            player.AddBuff(60, 18000, true);
            player.sporeSac = true;
            player.cordage = true;
            if (player.ZoneDesert)
            {
                player.thrownCost50 = true;
            }
            if (player.ZoneUndergroundDesert)
            {
                player.thrownCost50 = true;
            }
            if (player.ZoneCorrupt)
            {
                player.moveSpeed += 0.15f;
            }
            if (player.ZoneCrimson)
            {
                player.crimsonRegen = true;
            }
            if (player.ZoneDungeon)
            {
                player.boneArmor = true;
                player.ammoCost80 = true;
            }
            if (player.ZoneJungle)
            {
                player.manaCost -= 0.16f;
            }
        }
		public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
		{
			drawHair = true;
			drawAltHair = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Veridanite", 30);
			recipe.AddIngredient(ItemID.VortexHelmet,1);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}