using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
    public class WindstariotGlasses : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Increases Minion Damage by 15%, Minion Capacity by 2, and Knockback");
		}

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 9;
            item.defense = 19;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("WindstariotSuit") && legs.type == mod.ItemType("WindstariotLeggings");
        }
        public override void UpdateEquip(Player player)
        {
            player.minionDamage += 0.15f;
            player.minionKB = 5;
            player.maxMinions++;
            player.maxMinions++;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.maxMinions++;
            player.setBonus = "Extra minions and Stardust Guardian at your disposal!";
            player.setStardust = true;
            if (player.whoAmI == Main.myPlayer)
            {
                if (player.FindBuffIndex(187) == -1)
                {
                    player.AddBuff(187, 3600, true);
                }
                if (player.ownedProjectileCounts[623] < 1)
                {
                    Projectile.NewProjectile(player.Center.X, player.Center.Y, 0f, -1f, 623, 0, 0f, Main.myPlayer, 0f, 0f);
                    return;
                }
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
            recipe.AddIngredient(null, "StarlightOre", 30);
			recipe.AddIngredient(ItemID.StardustHelmet, 1);
            recipe.AddTile(null, "AegisContraption");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}