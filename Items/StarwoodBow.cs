using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class StarwoodBow : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 23;
			item.ranged = true;
			item.width = 60;
			item.height = 60;
			item.maxStack = 1;
			item.useTime = 17;
			item.useAnimation = 17;
			item.knockBack = 7f;
			item.UseSound = SoundID.Item5;
			item.noMelee = true;
			item.useStyle = 5;
			item.shoot = 1;
			item.value = Item.sellPrice(0, 0, 9, 0);
			item.rare = 2;
			item.shootSpeed = 9f;
			item.useAmmo = AmmoID.Arrow;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			float spread = 45f * 0.0174f; //45 degrees spread converted to radians because math reasons
			float baseSpeed = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double startAngle = Math.Atan2(speedX, speedY)- spread/2;
			double deltaAngle = spread/1f; //spread divided by number of shots
			double offsetAngle;
			int i;
			for (i = 0; i < 0;i++ ) //i < number of shots
			{
			    offsetAngle = startAngle + deltaAngle * i;
				Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed*(float)Math.Sin(offsetAngle), baseSpeed*(float)Math.Cos(offsetAngle), item.shoot, damage, knockBack, item.owner);
			}
			float num70 = (float)Main.mouseX + Main.screenPosition.X - position.X;
			float num71 = (float)Main.mouseY + Main.screenPosition.Y - position.Y;
            float num87 = 0.314159274f;
			int num88 = 5;
			Vector2 vector = new Vector2(num70, num71);
			vector.Normalize();
			vector *= 40f;
			float num90 = (float)- ((float)num88 - 1f) / 2f;
			Vector2 vector2 = vector.RotatedBy((double)(num87 * num90), default(Vector2));	
			int num91 = Projectile.NewProjectile(position.X + vector2.X, position.Y + vector2.Y, speedX, speedY,(ProjectileID.JestersArrow), damage, knockBack, Main.myPlayer);		
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Starwood", 10);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}