using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.NPCs
{
	public class LunarMoth : ModNPC
	{
		public override void SetDefaults()
		{
			npc.CloneDefaults(NPCID.Moth);
			npc.width = 30;
			npc.height = 20;
			npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 60f;
			npc.noGravity = true;
            npc.noTileCollide = true;
            npc.knockBackResist = .45f;
            npc.aiStyle = 22;
            Main.npcFrameCount[npc.type] = 4;
            aiType = NPCID.Moth;
			banner = npc.type;
			bannerItem = mod.ItemType("LunarMothBanner");
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
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return spawnInfo.player.GetModPlayer<CosmeticPlayer>(mod).ZoneFlower && Main.hardMode && !Main.dayTime && NPC.downedPlantBoss || (spawnInfo.player.GetModPlayer<CosmeticPlayer>(mod).ZoneStar && Main.hardMode && !Main.dayTime && NPC.downedPlantBoss) ? 0.6f : 0f;
		}		
		public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,(ItemID.Silk), Main.rand.Next(1,2));
			}
			if (Main.rand.Next(2) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,mod.ItemType("Gossamer"));
			}
			if (Main.rand.Next(6) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,(ItemID.ButterflyDust));
			}
		}
	}
}