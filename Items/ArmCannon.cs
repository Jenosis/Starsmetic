using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class ArmCannon : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.damage = 125;
			item.maxStack = 1;
			item.ranged = true;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.useTime = 10;
			item.useAnimation = 10;
			item.value = 10000;
			item.useAmmo = AmmoID.Bullet;
			item.rare = 9;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("ArmCannonShot");
            item.shootSpeed = 8f;
		}
		public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			mod.ProjectileType("ArmCannonShot");
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Chalchum", 32);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}