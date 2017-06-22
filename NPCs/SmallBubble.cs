using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.NPCs
{
	public class SmallBubble : ModNPC
	{
		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 8;
			npc.defense = 5;
			npc.lifeMax = 25;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.Item54;
			npc.value = 50f;
			npc.knockBackResist = 0.1f;
			npc.aiStyle = -1;
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.SpikeBall];
			aiType = -1;
			animationType = NPCID.SpikeBall;
			banner = npc.type;
			bannerItem = mod.ItemType("BubbleBanner");
		}
		public override void AI()
		{
			npc.noGravity = true;
			if (!npc.noTileCollide)
			{
				if (npc.collideX)
				{
					npc.velocity.X = npc.oldVelocity.X * -0.5f;
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
					npc.velocity.Y = npc.oldVelocity.Y * -0.5f;
					if (npc.velocity.Y > 0f && npc.velocity.Y < 1f)
					{
						npc.velocity.Y = 1f;
					}
					if (npc.velocity.Y < 0f && npc.velocity.Y > -1f)
					{
						npc.velocity.Y = -1f;
					}
				}
				npc.TargetClosest(true);
				
				if (npc.ai[0] >= 300f)
				{
					npc.ai[1] = 1f;
					npc.ai[0] = 0f;
					npc.netUpdate = true;
				}
				if (npc.ai[1] == 0f)
				{
					npc.alpha = 0;
					npc.noTileCollide = false;
				}
				else
				{
					npc.wet = false;
					npc.alpha = 200;
					npc.noTileCollide = true;
				}
				npc.rotation = npc.velocity.Y * 0.1f * (float)npc.direction;
				npc.TargetClosest(true);
				if (npc.direction == -1 && npc.velocity.X > -1f && npc.position.X > Main.player[npc.target].position.X + (float)Main.player[npc.target].width)
				{
					npc.velocity.X = npc.velocity.X - 0.08f;
					if (npc.velocity.X > 1f)
					{
						npc.velocity.X = npc.velocity.X - 0.04f;
					}
					else if (npc.velocity.X > 0f)
					{
						npc.velocity.X = npc.velocity.X - 0.2f;
					}
					if (npc.velocity.X < -1f)
					{
						npc.velocity.X = -1f;
					}
				}
				else if (npc.direction == 1 && npc.velocity.X < 1f && npc.position.X + (float)npc.width < Main.player[npc.target].position.X)
				{
					npc.velocity.X = npc.velocity.X + 0.08f;
					if (npc.velocity.X < -1f)
					{
						npc.velocity.X = npc.velocity.X + 0.04f;
					}
					else if (npc.velocity.X < 0f)
					{
						npc.velocity.X = npc.velocity.X + 0.2f;
					}
					if (npc.velocity.X > 1f)
					{
						npc.velocity.X = 1f;
					}
				}
				if (npc.directionY == -1 && (double)npc.velocity.Y > -1 && npc.position.Y > Main.player[npc.target].position.Y + (float)Main.player[npc.target].height)
				{
					npc.velocity.Y = npc.velocity.Y - 0.1f;
					if ((double)npc.velocity.Y > 1)
					{
						npc.velocity.Y = npc.velocity.Y - 0.05f;
					}
					else if (npc.velocity.Y > 0f)
					{
						npc.velocity.Y = npc.velocity.Y - 0.15f;
					}
					if ((double)npc.velocity.Y < -1)
					{
						npc.velocity.Y = -1f;
					}
				}
				else if (npc.directionY == 1 && (double)npc.velocity.Y < 1 && npc.position.Y + (float)npc.height < Main.player[npc.target].position.Y)
				{
					npc.velocity.Y = npc.velocity.Y + 0.1f;
					if ((double)npc.velocity.Y < -1)
					{
						npc.velocity.Y = npc.velocity.Y + 0.05f;
					}
					else if (npc.velocity.Y < 0f)
					{
						npc.velocity.Y = npc.velocity.Y + 0.15f;
					}
					if ((double)npc.velocity.Y > 1)
					{
						npc.velocity.Y = 1f;
					}
				}
			}
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return CosmeticVariety.NoBiome(spawnInfo)&& spawnInfo.spawnTileY  < Main.rockLayer && Main.dayTime && !spawnInfo.playerSafe && !spawnInfo.invasion && !spawnInfo.sky && !Main.eclipse ? 0.3f : 0f;
		}
		public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
			{
				
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,(ItemID.Bubble));
			}
			if (Main.rand.Next(8) == 0)
			{
				
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,mod.ItemType("Bubbleyoyo"));
			}
			if (Main.rand.Next(12) == 0)
			{
				
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,mod.ItemType("BubbleTome1"));
			}
		}
		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++)
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, 412);
                Gore.NewGore(npc.position, npc.velocity, 417);
                Gore.NewGore(npc.position, npc.velocity, 422);
				Gore.NewGore(npc.position, npc.velocity, 426);
            }
		}
	}
}
