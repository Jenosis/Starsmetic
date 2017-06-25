using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
    public class StarwoodHelmet : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Increases Minion Damage by 9%, Minion Capacity by 1, and Knockback");
		}
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 3;
            item.defense = 6;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("StarwoodChestplate") && legs.type == mod.ItemType("StarwoodLeggings");
        }
        public override void UpdateEquip(Player player)
        {
            player.minionDamage += 0.09f;
            player.minionKB = 3;
            player.maxMinions++;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.maxMinions++;
            player.setBonus = "An extra minion to help you!";
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Starwood", 20);
            recipe.AddTile(18);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}