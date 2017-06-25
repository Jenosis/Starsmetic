using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class DivineSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The ultimate sword to end it all");
		}
		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.damage = 140;
			item.melee = true;
			item.useStyle = 1;
			item.knockBack = 10;
			item.useTime = 6;
			item.useAnimation = 10;
			item.value = 10000;
			item.rare =9;
            item.autoReuse = true;
            item.shoot = ProjectileID.StarWrath;
            item.shootSpeed = 15f;
		}
		public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float spread = 45f * 0.0174f;//45 degrees converted to radians
			float baseSpeed = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double baseAngle = Math.Atan2(speedX, speedY);
			double randomAngle = baseAngle+(Main.rand.NextFloat()-0.5f)*spread;
			speedX = baseSpeed*(float)Math.Sin(randomAngle);
			speedY = baseSpeed*(float)Math.Cos(randomAngle);
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "StarlightOre", 30);
			recipe.AddIngredient(ItemID.StarWrath);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}