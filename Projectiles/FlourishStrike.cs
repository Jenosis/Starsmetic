using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ModLoader;

namespace CosmeticVariety.Projectiles
{
	public class FlourishStrike : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 18;
			projectile.height = 34;
			projectile.scale = 0.75f;
			projectile.aiStyle = 0;
			projectile.timeLeft = 90;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.tileCollide = true;
			projectile.ignoreWater = true;
			projectile.ranged = true;
			projectile.extraUpdates = 5;
			projectile.penetrate = -1;
		}
		public override void AI()
		{
			projectile.light = 0.9f;
			int DustID2 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width + 4, projectile.height + 4, 60, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 120, default(Color), 0.9f);
			Main.dust[DustID2].noGravity = true;
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
		}
		public override void Kill(int timeLeft)
        {
			int proj1 = Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0, 0, 229, projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f);
			Main.projectile[proj1].ai[1] = 300;
		}
	}
}