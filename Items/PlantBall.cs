using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class PlantBall : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.damage = 50;
			item.UseSound = SoundID.Item1;
			item.maxStack = 999;
			item.thrown = true;
			item.useStyle = 4;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.useTime = 5;
			item.consumable = true;
			item.noUseGraphic = true;
			item.useAnimation = 10;
			item.value = 10000;
			item.rare = 9;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("PlantBall");
            item.shootSpeed = 8f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Veridanite", 5);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this,25);
			recipe.AddRecipe();
		}
	}
}