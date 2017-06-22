using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Projectiles
{
	public class GhostSword : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 28;
			projectile.height = 86;
			projectile.aiStyle = -1;
			projectile.friendly = true;
			projectile.penetrate = 5;
			projectile.timeLeft = 600;
			projectile.light = 0.5f;
			projectile.extraUpdates = 1;
			projectile.magic = true;
		}
	}
}