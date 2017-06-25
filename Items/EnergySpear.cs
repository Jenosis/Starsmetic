using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class EnergySpear : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.DayBreak);
			item.damage = (int)(item.damage * 1.5);
			item.width = 18;
			item.height = 18;
			item.damage = 170;
			item.melee = true;
			item.knockBack = 5;
			item.useTime = 10;
			item.useAnimation = 10;
			item.value = 10000;
			item.rare = 9;
            item.autoReuse = true;          
			item.shoot = mod.ProjectileType("EnergySpear");
            item.shootSpeed = 10f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Veridanite", 20);
			recipe.AddIngredient(ItemID.DayBreak, 1);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}