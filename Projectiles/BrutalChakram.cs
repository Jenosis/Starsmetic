using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Projectiles
{
	public class BrutalChakram : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 30;
			projectile.height = 54;
			projectile.friendly = true;
			projectile.aiStyle = 3;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			projectile.melee = true;
			aiType = ProjectileID.LightDisc;
		}
	}
}