using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class Crystalline : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Tsunami);
			item.shootSpeed = 14f;
            item.useAmmo = AmmoID.Arrow;
			item.damage = (int)(item.damage * 3.0);
		}
		public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float spread = 45f * 0.0174f; //45 degrees spread converted to radians because math reasons
			float baseSpeed = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double startAngle = Math.Atan2(speedX, speedY)- spread/2;
			double deltaAngle = spread/5f; //spread divided by number of shots
			double offsetAngle;
			int i;
			for (i = 0; i < 5;i++ ) //i < number of shots
			{
			  offsetAngle = startAngle + deltaAngle * i;
			  Terraria.Projectile.NewProjectile(position.X, position.Y, baseSpeed*(float)Math.Sin(offsetAngle), baseSpeed*(float)Math.Cos(offsetAngle), item.shoot, damage, knockBack, item.owner);
			}
		  return false;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrystalShard, 25);
			recipe.AddIngredient(null,"Mantilum", 22);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}