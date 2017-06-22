using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.NPCs
{
	public class Turnish : ModNPC
	{
		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 7;
			npc.defense = 6;
			npc.lifeMax = 27;
			banner = npc.type;
			bannerItem = mod.ItemType("TurnishBanner");
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 60f;
			npc.knockBackResist = 2f;
			npc.aiStyle = 3;
			Main.npcFrameCount[npc.type] = 4;
			aiType = NPCID.CorruptBunny;
			animationType = NPCID.Zombie;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return spawnInfo.player.GetModPlayer<CosmeticPlayer>(mod).ZoneFlower &&  Main.dayTime  ? 0.8f : 0f;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++) ;
            if (npc.life <= 0)
            {
               // Gore.NewGore(npc.position, npc.velocity, 3);
               // Gore.NewGore(npc.position, npc.velocity, 4);
               // Gore.NewGore(npc.position, npc.velocity, 5);
            }
		}
		public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
			{
				
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,(mod.ItemType("WeirdlyColoredPetal")),Main.rand.Next(1,5));
			}
			if (Main.rand.Next(3) == 0)
			{
				
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,(mod.ItemType("Turnip")),Main.rand.Next(3,8));
			}
		}
	}
}
