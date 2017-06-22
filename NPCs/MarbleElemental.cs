using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.NPCs
{
	public class MarbleElemental : ModNPC
	{
		public override void SetDefaults()
		{
			npc.width = 20;
			npc.height = 40;
			npc.damage = 14;
			npc.defense = 16;
			npc.lifeMax = 60;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = 50f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 91;
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.GraniteFlyer];
			aiType = NPCID.GraniteFlyer;
			animationType = NPCID.GraniteFlyer;
			banner = npc.type;
			bannerItem = mod.ItemType("MarbleElementalBanner");
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if(Main.rand.Next(3) != 0) return 0f;
			return spawnInfo.marble ? 0.05f : 0f;
		}
		public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
			{
				
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,(ItemID.Marble),Main.rand.Next(1,5));
			}
		}
	}
}