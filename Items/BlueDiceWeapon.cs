using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	
	public class BlueDiceWeapon : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("8 to the 8th power is 16777216! Is bound to shoot random throwing projectiles.");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.damage = 34;
			item.thrown = true;
			item.useStyle = 1;
			item.knockBack = 5;
			item.useTime = 15;
			item.useAnimation = 15;
			item.value = 10000;
			item.rare = 2;
            item.autoReuse = true;
            item.shoot = 1;
			item.shootSpeed = 10f;
			item.consumable = false;
		}
		int[] randType = new int[5] { ProjectileID.Shuriken, ProjectileID.Bone,ProjectileID.HappyBomb, ProjectileID.BoneJavelin, ProjectileID.BouncyGrenade };
		public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			
			type = randType[Main.rand.Next(5)];
			
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ZilliumBar", 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}