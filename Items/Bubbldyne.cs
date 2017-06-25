using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class Bubbldyne : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.damage = 50;
			item.magic = true;
			item.UseSound = SoundID.Item8;
			item.mana = 13;
			item.useStyle = 4;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.useTime = 25;
			item.useAnimation = 18;
			item.value = 1000;
			item.rare = 8;
            item.autoReuse = true;
            item.shoot = ProjectileID.FlaironBubble;
            item.shootSpeed = 15f;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			position = Main.MouseWorld;
			float spread = 45f * 0.0174f;
			double startAngle = Math.Atan2(speedX, speedY)- spread/2;
			double deltaAngle = spread/12f;
			double offsetAngle;
			int i;
			for (i = 0; i < 12; i++ )
			{
				offsetAngle = (startAngle + deltaAngle * (i + i*i) / 2f) + 32f * i;
				Terraria.Projectile.NewProjectile(position.X, position.Y, (float)(Math.Sin(offsetAngle)*5f), (float)(Math.Cos(offsetAngle)*5f), item.shoot, damage, knockBack, item.owner);
				Terraria.Projectile.NewProjectile(position.X, position.Y, (float)(-Math.Sin(offsetAngle)*5f), (float)(-Math.Cos(offsetAngle)*5f), item.shoot, damage, knockBack, item.owner);
			}
			return false;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bubble, 10);
			recipe.AddIngredient(ItemID.BubbleGun, 1);
			recipe.AddIngredient(null,"Bubblio",1);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

	}
}