using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Projectiles
{
	public class Turnip : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 90;
			projectile.height = 34;
			projectile.friendly = true;
			projectile.aiStyle = 2;
			projectile.tileCollide = true;
			projectile.ignoreWater = true;
			projectile.ranged = true;
			aiType = ProjectileID.SpikyBall;
		}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/Bonk"));
		}
	}
}