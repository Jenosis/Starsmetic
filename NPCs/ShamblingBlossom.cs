using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.NPCs
{
	public class ShamblingBlossom : ModNPC
	{
		public override void SetDefaults()
		{
			npc.CloneDefaults(NPCID.Wolf);
			npc.width = 46;
			npc.height = 56;
			npc.damage = 28;
			npc.defense = 30;
			npc.lifeMax = 150;
			npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 4000f;
            npc.knockBackResist = .45f;
            npc.aiStyle = 26;
            Main.npcFrameCount[npc.type] = 5;
			banner = npc.type;
			bannerItem = mod.ItemType("ShamblingBlossomBanner");
		}
		
		public override void FindFrame(int frameHeight)
        {
            npc.frameCounter += 0.25f;
            npc.frameCounter %= Main.npcFrameCount[npc.type];
            int frame = (int)npc.frameCounter;
            npc.frame.Y = frame * frameHeight;
        }
        public override void AI()
        {
            npc.spriteDirection = npc.direction;
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
		/*//thank you Grox for saving my sorry ass with this
		public void AICharger(NPC npc, ref float[] ai, float moveInterval = 0.07f, float maxSpeed = 6f, bool allowBoredom = true, int ticksUntilBoredom = 30)
		{
			bool isMoving = false;
			if (npc.velocity.Y == 0f && (npc.velocity.X > 0f && npc.direction < 0 || npc.velocity.X < 0f && npc.direction > 0))
			{
				isMoving = true;
				++ai[3];
			}
			if (npc.position.X == npc.oldPosition.X || ai[3] >= ticksUntilBoredom || isMoving) ++ai[3];
			else if ((ai[3] > 0f)) --ai[3];
			if (ai[3] > (ticksUntilBoredom * 10)) ai[3] = 0f;
			if (npc.justHit) ai[3] = 0f;
			if (ai[3] == ticksUntilBoredom) npc.netUpdate = true;
			Vector2 npcCenter = npc.Center;
			float distX = Main.player[npc.target].Center.X - npcCenter.X;
			float distY = Main.player[npc.target].Center.Y - npcCenter.Y;
			float dist = (float)Math.Sqrt(distX * distX + distY * distY);
			if (dist < 200f) ai[3] = 0f;
			if (!allowBoredom || ai[3] < ticksUntilBoredom)
			{
				npc.TargetClosest(true);
			}else
			{
				if (npc.velocity.X == 0f)
				{
					if (npc.velocity.Y == 0f)
					{
						++ai[0];
						if (ai[0] >= 2.0){ npc.direction *= -1; npc.spriteDirection = npc.direction; ai[0] = 0f; }
					}
				}else ai[0] = 0f;
				npc.directionY = -1;
				if (npc.direction == 0) npc.direction = 1;
			}
			if (npc.velocity.Y == 0f || npc.wet || (npc.velocity.X <= 0f && npc.direction < 0) || (npc.velocity.X >= 0f && npc.direction > 0))
			{
				if (npc.velocity.X < -maxSpeed || npc.velocity.X > maxSpeed)
				{
					if (npc.velocity.Y == 0f) npc.velocity *= 0.8f;
				}else if (npc.velocity.X < maxSpeed && npc.direction == 1)
				{
					npc.velocity.X += moveInterval;
					if (npc.velocity.X > maxSpeed) npc.velocity.X = maxSpeed;
				}else if (npc.velocity.X > -maxSpeed && npc.direction == -1)
				{
					npc.velocity.X -= moveInterval;
					if (npc.velocity.X < -maxSpeed) npc.velocity.X = -maxSpeed;
				}
			}
		}
		public override void AI()
		{	
			this.AICharger(npc, ref npc.ai, 0.07f, 6f, true, 30);
		}
		*/
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return spawnInfo.player.GetModPlayer<CosmeticPlayer>(mod).ZoneFlower && Main.hardMode ? 0.7f : 0f;
		}
		
		public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,mod.ItemType("WeirdlyColoredPetal"), Main.rand.Next(1,6));
			}
		}
	}
}