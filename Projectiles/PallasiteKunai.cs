using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Projectiles
{
	public class PallasiteKunai : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 42;
			projectile.height = 42;
			projectile.friendly = true;
			projectile.aiStyle = 2;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			projectile.thrown = true;
			aiType = ProjectileID.ThrowingKnife;
		}
	}
}