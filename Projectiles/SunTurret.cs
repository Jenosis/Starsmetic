using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Projectiles
{
	public class SunTurret : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 50;
			projectile.height = 50;
			Main.projFrames[projectile.type] = 4;
			projectile.aiStyle = -1;
			projectile.timeLeft = 7200;
			projectile.ignoreWater = true;
			projectile.tileCollide = false;
			projectile.hide = false;
		}
        public override void AI()
        {
            float distanceThresholdToFire = 1000f;
			projectile.velocity = Vector2.Zero;

			//Just setting some visuals
			projectile.rotation -= (float)projectile.direction * 6.28318548f / 120f;
			projectile.scale = projectile.Opacity;
			Lighting.AddLight(projectile.Center, new Vector3(0.3f, 0.9f, 0.7f) * projectile.Opacity);
			if (Main.rand.Next(2) == 0)
			{
				Vector2 vector135 = Vector2.UnitY.RotatedByRandom(6.2831854820251465);
				Dust dust128 = Main.dust[Dust.NewDust(projectile.Center - vector135 * 30f, 0, 0, 229, 0f, 0f, 0, default(Color), 1f)];
				dust128.noGravity = true;
				dust128.position = projectile.Center - vector135 * (float)Main.rand.Next(10, 21);
				dust128.velocity = vector135.RotatedBy(1.5707963705062866, default(Vector2)) * 6f;
				dust128.scale = 0.5f + Main.rand.NextFloat();
				dust128.fadeIn = 0.5f;
				dust128.customData = projectile.Center;
			}
			if (Main.rand.Next(2) == 0)
			{
				Vector2 vector136 = Vector2.UnitY.RotatedByRandom(6.2831854820251465);
				Dust dust129 = Main.dust[Dust.NewDust(projectile.Center - vector136 * 30f, 0, 0, 240, 0f, 0f, 0, default(Color), 1f)];
				dust129.noGravity = true;
				dust129.position = projectile.Center - vector136 * 30f;
				dust129.velocity = vector136.RotatedBy(-1.5707963705062866, default(Vector2)) * 3f;
				dust129.scale = 0.5f + Main.rand.NextFloat();
				dust129.fadeIn = 0.5f;
				dust129.customData = projectile.Center;
			}
			if (projectile.ai[0] < 0f)
			{
				Vector2 center15 = projectile.Center;
				int num1078 = Dust.NewDust(center15 - Vector2.One * 8f, 16, 16, 229, projectile.velocity.X / 2f, projectile.velocity.Y / 2f, 0, default(Color), 1f);
				Main.dust[num1078].velocity *= 2f;
				Main.dust[num1078].noGravity = true;
				Main.dust[num1078].scale = Utils.SelectRandom<float>(Main.rand, new float[]
				{
				0.8f,
				1.65f
				});
				Main.dust[num1078].customData = projectile;
			}

			//Adjusting Alpha
			projectile.alpha -= 5;
			if (projectile.alpha < 0)
			{
			projectile.alpha = 0;
			}
			if (projectile.direction == 0)
			{
			projectile.direction = Main.player[projectile.owner].direction;
			}

			//Animation
			if (++projectile.frameCounter >= 3)
			{
				projectile.frameCounter = 0;
				if (++projectile.frame >= Main.projFrames[projectile.type])
				{
					projectile.frame = 0;
				}
			}

			//More visuals
			if (projectile.alpha == 0 && Main.rand.Next(15) == 0)
			{
				Dust dust130 = Main.dust[Dust.NewDust(projectile.Top, 0, 0, 261, 0f, 0f, 100, default(Color), 1f)];
				dust130.velocity.X = 0f;
				dust130.noGravity = true;
				dust130.fadeIn = 1f;
				dust130.position = projectile.Center + Vector2.UnitY.RotatedByRandom(6.2831854820251465) * (4f * Main.rand.NextFloat() + 26f);
				dust130.scale = 0.5f;
			}

			//AI counters, yay!
			projectile.localAI[0] += 1f;
			if (projectile.localAI[0] >= 60f)
			{
				projectile.localAI[0] = 0f;
			}
			if (projectile.ai[0] < 0f)
			{
				projectile.ai[0] += 1f;
			}
			if (projectile.ai[0] == 0f)
			{
				//-1 is an invalid target
				int shootProjectileAt = -1;
				float distance = distanceThresholdToFire;
			   
				//Searching for an npc target
				for (int npcSlot = 0; npcSlot < 200; npcSlot++)
				{
					NPC target = Main.npc[npcSlot];
					if (target.CanBeChasedBy(projectile, false))
					{
						float targetDistance = projectile.Distance(target.Center);
						if (targetDistance < distance && Collision.CanHitLine(projectile.Center, 0, 0, target.Center, 0, 0))
						{
							distance = targetDistance;
							shootProjectileAt = npcSlot;
						}
					}
				}
			   
				//If there's a valid target, shoot it!
				if (shootProjectileAt != -1)
				{
					projectile.ai[0] = 1f;
					projectile.ai[1] = (float)shootProjectileAt;
					projectile.netUpdate = true;
					return;
				}
			}
			if (projectile.ai[0] > 0f)
			{
				int target = (int)projectile.ai[1];
				
				//If the target does not exist or can't be attacked then reset everything
				if (!Main.npc[target].CanBeChasedBy(projectile, false))
				{
					projectile.ai[0] = 0f;
					projectile.ai[1] = 0f;
					projectile.netUpdate = true;
					return;
				}
				projectile.ai[0] += 1f;
				float num1084 = 30f;
				if (projectile.ai[0] >= num1084)
				{
					Vector2 vector137 = projectile.DirectionTo(Main.npc[target].Center);
					if (vector137.HasNaNs())
					{
						vector137 = Vector2.UnitY;
					}
					float num1085 = vector137.ToRotation();
					int num1086 = (vector137.X > 0f) ? 1 : -1;
					projectile.direction = num1086;
					projectile.ai[0] = -20f;
					projectile.netUpdate = true;
					if (projectile.owner == Main.myPlayer)
					{
						//Getting shoot vector
						Vector2 targetVector = Main.npc[target].position + Main.npc[target].Size * Utils.RandomVector2(Main.rand, 0f, 1f) - projectile.Center;
						for (int numProjectiles = 0; numProjectiles < 3; numProjectiles++)
						{
							Vector2 shootVector = projectile.Center + targetVector;
							if (numProjectiles > 0)
							{
								shootVector = projectile.Center + targetVector.RotatedByRandom(0.78539818525314331) * (Main.rand.NextFloat() * 0.5f + 0.75f);
							}
							//Spawn projectile to shoot
							Projectile.NewProjectile(shootVector.X, shootVector.Y, 0f, 0f, 644, projectile.damage, projectile.knockBack, projectile.owner, (float)projectile.whoAmI);
						}
						return;
					}
				}
			}
		}
    }
}