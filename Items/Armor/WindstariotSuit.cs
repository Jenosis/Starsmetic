using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
    public class WindstariotSuit : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Increases Minion damage by 17%, Minion Capacity by 2, and Knockback");
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
            player.minionDamage += 0.17f;
            player.minionKB = 5;
            player.maxMinions++;
            player.maxMinions++;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "StarlightOre", 50);
			recipe.AddIngredient(ItemID.StardustBreastplate, 1);
            recipe.AddTile(null, "AegisContraption");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}