using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
    public class AstralWatchHelm : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Adds 10% Damage and 4% Crit to all but Melee");
		}

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 5;
            item.defense = 12;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("AstralWatchBody") && legs.type == mod.ItemType("AstralWatchLegging");
        }
        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += 0.10f;
            player.rangedCrit = 4;
			player.magicDamage += 0.10f;
            player.magicCrit = 5;
			player.minionDamage += 0.10f;
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Extends maximum wingtime";
			player.wingTimeMax = 800;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"StarwoodHelmet", 1);
			recipe.AddIngredient(null,"StarliteCore", 2);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}