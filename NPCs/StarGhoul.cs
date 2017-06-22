using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.NPCs
{
	public class StarGhoul : ModNPC
	{
		public override void SetDefaults()
		{
			npc.width = 46;
			npc.height = 50;
			npc.damage = 63;
			npc.defense = 42;
			npc.lifeMax = 300;
			npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath3;
            npc.value = 60f;
            npc.knockBackResist = .45f;
			npc.aiStyle = 22;
			npc.noGravity = true;
			npc.noTileCollide = true;
            Main.npcFrameCount[npc.type] = 4;
            aiType = NPCID.Wraith;
            animationType = NPCID.Wraith;
			banner = npc.type;
			bannerItem = mod.ItemType("StarGhoulBanner");
		}
		
		public override void FindFrame(int frameHeight)
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
			return spawnInfo.player.GetModPlayer<CosmeticPlayer>(mod).ZoneStar && Main.hardMode ? 1f : 0f;
		}
		public override void NPCLoot()
		{
			if (Main.rand.Next(2) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,mod.ItemType("StarliteFragments"), Main.rand.Next(1,2));
			}
		}
	}
}