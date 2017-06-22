using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Projectiles
{
	public class ThrowingAxe : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 90;
			projectile.height = 34;
			projectile.friendly = true;
			projectile.aiStyle = 8;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			projectile.ranged = true;
			aiType = ProjectileID.StarWrath;
		}
	}
}