using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class Clentamosphere : ModItem
	{
		public override void SetDefaults()
		{
			item.UseSound = SoundID.Item34;
			item.width = 26;
			item.height = 28;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.noMelee = true;
			item.autoReuse = true;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 30, 0, 0);
			item.rare = 9;
			item.useAmmo = AmmoID.Solution;
			item.shoot = 145;
			item.shootSpeed = 10f;
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
	}
}