using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
    public class InfermantlePlatelegs : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Adds 17% Melee Damage nd 5% Crit");
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
            player.meleeDamage += 0.17f;
            player.meleeCrit = 5;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SolarFlareLeggings, 1);
            recipe.AddIngredient(null, "Pallasite", 40);
            recipe.AddTile(null, "AegisContraption");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
