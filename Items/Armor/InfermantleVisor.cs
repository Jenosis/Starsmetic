using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
    public class InfermantleVisor : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Adds 15% Melee Damage nd 5% Crit");
		}

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 9;
            item.defense = 30;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("InfermantlePlatebody") && legs.type == mod.ItemType("InfermantlePlatelegs");
        }
        public override void UpdateEquip(Player player)
        {
            player.meleeDamage += 0.15f;
            player.meleeCrit = 5;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Petals,shiny regen, and lava immunity oh my! A 20% increase on movement speed and endurance with a splash of dodging.";
            player.endurance += 0.20f;
            player.moveSpeed += 0.20f;
            player.lavaImmune = true;
            player.onHitPetal = true;
            player.shinyStone = true;
            player.onHitDodge = true;
        }
	    
        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = true;
            drawAltHair = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SolarFlareHelmet, 1);
            recipe.AddIngredient(null, "Pallasite", 30);
            recipe.AddTile(null, "AegisContraption");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}