using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
    public class AstralWatchBody : ModItem
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
            item.defense = 24;
        }
        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += 0.10f;
            player.rangedCrit = 4;
			player.magicDamage += 0.10f;
            player.magicCrit = 5;
			player.minionDamage += 0.10f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"StarwoodChestplate", 1);
			recipe.AddIngredient(null,"StarliteCore", 3);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}