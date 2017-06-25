using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class ThrowingAxe : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.damage = 50;
			item.maxStack = 999;
			item.thrown = true;
			item.useStyle = 4;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.useTime = 10;
			item.consumable = true;
			item.noUseGraphic = true;
			item.useAnimation = 10;
			item.UseSound = SoundID.Item1;
			item.value = 10000;
			item.rare = 9;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("ThrowingAxe");
            item.shootSpeed = 9f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Chalchum", 5);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this,25);
			recipe.AddRecipe();
		}
	}
}