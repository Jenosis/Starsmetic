using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.NPCs
{
	public class FlowerZombie : ModNPC
	{
		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 14;
			npc.defense = 6;
			npc.lifeMax = 50;
			bannerItem = ItemID.ZombieBanner;
			banner = Item.NPCtoBanner(NPCID.Zombie);
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.4f;
			npc.aiStyle = 3;
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return spawnInfo.player.GetModPlayer<CosmeticPlayer>(mod).ZoneStar && !Main.dayTime && !spawnInfo.playerSafe&& !spawnInfo.invasion && !spawnInfo.sky && !Main.eclipse  ? 0.15f : 0f;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++) ;
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, 3);
                Gore.NewGore(npc.position, npc.velocity, 4);
                Gore.NewGore(npc.position, npc.velocity, 5);
            }
		}
		public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
			{
				
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,(mod.ItemType("WeirdlyColoredPetal")),Main.rand.Next(1,5));
			}
		}
	}
}
