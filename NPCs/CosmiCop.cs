using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.NPCs
{
	public class CosmiCop : ModNPC
	{
		public override void SetDefaults()
		{
			npc.CloneDefaults(NPCID.Probe);
			npc.width = 66;
			npc.height = 40;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath14;
            npc.value = 1440f;
            npc.aiStyle = 5;
            Main.npcFrameCount[npc.type] = 1;
            aiType = NPCID.Probe;
			banner = npc.type;
			bannerItem = mod.ItemType("CosmiCopBanner");
		}
		public override void FindFrame(int frameHeight)
        {
            npc.frameCounter += 0.25f;
            npc.frameCounter %= Main.npcFrameCount[npc.type];
            int frame = (int)npc.frameCounter;
            npc.frame.Y = frame * frameHeight;
        }
        public override void AI()//thank you absol/mountaindrew for this; you and grox have saved me tons of times
        {
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead)
			{
				npc.TargetClosest(true);
			}
			float num = 6f; //y velocity
			float num2 = 0.25f; //x velocity
			Vector2 vector = new Vector2(npc.position.X + (float)npc.width * 0.5f, npc.position.Y + (float)npc.height * 0.5f);
			float num4 = Main.player[npc.target].position.X + (float)(Main.player[npc.target].width / 2);
			float num5 = Main.player[npc.target].position.Y + (float)(Main.player[npc.target].height / 2);
			num4 = (float)((int)(num4 / 8f) * 8);
			num5 = (float)((int)(num5 / 8f) * 8);
			vector.X = (float)((int)(vector.X / 8f) * 8);
			vector.Y = (float)((int)(vector.Y / 8f) * 8);
			num4 -= vector.X;
			num5 -= vector.Y;
			float num6 = (float)Math.Sqrt((double)(num4 * num4 + num5 * num5));
			float num7 = num6;
			bool flag = false;
			if (num6 > 600f)
			{
				flag = true;
			}
			if (num6 == 0f)
			{
				num4 = npc.velocity.X;
				num5 = npc.velocity.Y;
			}
			else
			{
				num6 = num / num6;
				num4 *= num6;
				num5 *= num6;
			}
			if (num7 > 100f)
			{
				npc.ai[0] += 1f;
				if (npc.ai[0] > 0f)
				{
					npc.velocity.Y = npc.velocity.Y + 0.023f;
				}
				else
				{
					npc.velocity.Y = npc.velocity.Y - 0.023f;
				}
				if (npc.ai[0] < -100f || npc.ai[0] > 100f)
				{
					npc.velocity.X = npc.velocity.X + 0.023f;
				}
				else
				{
					npc.velocity.X = npc.velocity.X - 0.023f;
				}
				if (npc.ai[0] > 200f)
				{
					npc.ai[0] = -200f;
				}
			}
			if (Main.player[npc.target].dead)
			{
				num4 = (float)npc.direction * num / 2f;
				num5 = -num / 2f;
			}
			if (npc.velocity.X < num4)
			{
				npc.velocity.X = npc.velocity.X + num2;
			}
			else if (npc.velocity.X > num4)
			{
				npc.velocity.X = npc.velocity.X - num2;
			}
			if (npc.velocity.Y < num5)
			{
				npc.velocity.Y = npc.velocity.Y + num2;
			}
			else if (npc.velocity.Y > num5)
			{
				npc.velocity.Y = npc.velocity.Y - num2;
			}
			npc.localAI[0] += 1f;
			if (npc.justHit)
			{
				npc.localAI[0] = 0f;
			}
			if (Main.netMode != 1 && npc.localAI[0] >= 150f)
			{
				npc.localAI[0] = 0f;
				if (Collision.CanHit(npc.position, npc.width, npc.height, Main.player[npc.target].position, Main.player[npc.target].width, Main.player[npc.target].height))
				{
					int num8 = 70;
					if (Main.expertMode)
					{
						num8 = 46;
					}
					int num9 = 84;
					Projectile.NewProjectile(vector.X, vector.Y, num4, num5, num9, num8, 0f, Main.myPlayer, 0f, 0f);
				}
			}
			int num10 = (int)npc.position.X + npc.width / 2;
			int num11 = (int)npc.position.Y + npc.height / 2;
			num10 /= 16;
			num11 /= 16;
			if (!WorldGen.SolidTile(num10, num11))
			{
				Lighting.AddLight((int)((npc.position.X + (float)(npc.width / 2)) / 16f), (int)((npc.position.Y + (float)(npc.height / 2)) / 16f), 0.3f, 0f, 0.25f);
			}
			if (num4 > 0f)
			{
				npc.spriteDirection = 1;
				npc.rotation = (float)Math.Atan2((double)num5, (double)num4);
			}
			if (num4 < 0f)
			{
				npc.spriteDirection = -1;
				npc.rotation = (float)Math.Atan2((double)num5, (double)num4) + 3.14f;
			}
			float num12 = 0.7f;
			if (npc.collideX)
			{
				npc.netUpdate = true;
				npc.velocity.X = npc.oldVelocity.X * -num12;
				if (npc.direction == -1 && npc.velocity.X > 0f && npc.velocity.X < 1f)
				{
					npc.velocity.X = 1f;
				}
				if (npc.direction == 1 && npc.velocity.X < 0f && npc.velocity.X > -1f)
				{
					npc.velocity.X = -1f;
				}
			}
			if (npc.collideY)
			{
				npc.netUpdate = true;
				npc.velocity.Y = npc.oldVelocity.Y * -num12;
				if (npc.velocity.Y > 0f && (double)npc.velocity.Y < 1.5)
				{
					npc.velocity.Y = 1f;
				}
				if (npc.velocity.Y < 0f && (double)npc.velocity.Y > -1.5)
				{
					npc.velocity.Y = -1f;
				}
			}
			if (flag)
			{
				if ((npc.velocity.X > 0f && num4 > 0f) || (npc.velocity.X < 0f && num4 < 0f))
				{
					if (Math.Abs(npc.velocity.X) < 12f)
					{
						npc.velocity.X = npc.velocity.X * 1.05f;
					}
				}
				else
				{
					npc.velocity.X = npc.velocity.X * 0.9f;
				}
			}
			if (((npc.velocity.X > 0f && npc.oldVelocity.X < 0f) || (npc.velocity.X < 0f && npc.oldVelocity.X > 0f) || (npc.velocity.Y > 0f && npc.oldVelocity.Y < 0f) || (npc.velocity.Y < 0f && npc.oldVelocity.Y > 0f)) && !npc.justHit)
			{
				npc.netUpdate = true;
			}
        }
		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, 13);
                Gore.NewGore(npc.position, npc.velocity, 12);
                Gore.NewGore(npc.position, npc.velocity, 11);
            }
        }

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return spawnInfo.player.GetModPlayer<CosmeticPlayer>(mod).ZoneStar && Main.hardMode && NPC.downedMechBossAny ? 0.4f : 0f;
		}
		/*
		public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,(ItemID.Feather), Main.rand.Next(1,3));
			}
		}
		*/
	}
}