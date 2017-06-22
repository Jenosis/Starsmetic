using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Projectiles
{
	public class MagicCard : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 42;
			projectile.height = 42;
			projectile.friendly = true;
			projectile.aiStyle = 9;
			Main.projFrames[projectile.type] = 2;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			projectile.thrown = true;
			aiType = ProjectileID.StarWrath;
		}
		public override void AI()
		{
			if (++projectile.frameCounter >= 2)
			{
				projectile.frameCounter = 0;
				if (++projectile.frame >= Main.projFrames[projectile.type])
				{
					projectile.frame = 0;
				}	
			}
		}
	}
}