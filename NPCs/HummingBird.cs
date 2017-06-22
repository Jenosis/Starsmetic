using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.NPCs
{
	public class HummingBird : ModNPC
	{
		public override void SetDefaults()
		{
			npc.width = 66;
			npc.height = 40;
			npc.damage = 6;
			npc.defense = 9;
			npc.lifeMax = 34;
			npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 144f;
            npc.knockBackResist = 1f;
            npc.aiStyle = 14;
            Main.npcFrameCount[npc.type] = 2;
            aiType = NPCID.JungleBat;
			banner = npc.type;
			bannerItem = mod.ItemType("HummingBirdBanner");
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
			return spawnInfo.player.GetModPlayer<CosmeticPlayer>(mod).ZoneFlower && Main.dayTime ? 0.3f : 0f;
		}
		
		public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,(ItemID.Feather), Main.rand.Next(1,3));
			}
		}
	}
}