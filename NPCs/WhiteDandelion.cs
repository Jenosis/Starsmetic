using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.NPCs
{
	public class WhiteDandelion : ModNPC
	{
		public override void SetDefaults()
		{
			npc.CloneDefaults(NPCID.Unicorn);
			npc.width = 18;
			npc.height = 40;
			banner = npc.type;
			bannerItem = mod.ItemType("WhiteDandelionBanner");
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 60f;
			npc.knockBackResist = 0.4f;
			npc.aiStyle = 3;
			Main.npcFrameCount[npc.type] = 4;
			aiType = NPCID.CorruptBunny;
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
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return spawnInfo.player.GetModPlayer<CosmeticPlayer>(mod).ZoneFlower &&  Main.dayTime && Main.hardMode ? 0.4f : 0f;
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
		}
	}
}
