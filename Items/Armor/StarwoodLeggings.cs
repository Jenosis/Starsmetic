using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
    public class StarwoodLeggings : ModItem
    {
		public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("Increases Minion Damage by 7%, Minion Capacity by 1, and Knockback");
	}

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 3;
            item.defense = 5;
        }
        public override void UpdateEquip(Player player)
        {
            player.minionDamage += 0.07f;
            player.minionKB = 1;
            player.maxMinions++;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Starwood", 25);
            recipe.AddTile(18);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
