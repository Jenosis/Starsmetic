using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.NPCs
{
	public class MeteorMasher: ModNPC
	{
		public override void SetDefaults()
		{
            npc.width = 24;
            npc.height = 30;
            npc.damage = 50;
            npc.defense = 20;
            npc.lifeMax = 400;
            npc.HitSound = SoundID.NPCHit3;
			npc.DeathSound = SoundID.NPCDeath6;
            npc.value = 5060f;
            npc.knockBackResist = 0f;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.aiStyle = -1;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.ChaosBall];
            aiType = NPCID.DungeonSpirit;
            animationType = NPCID.ChaosBall;
			banner = npc.type;
			bannerItem = mod.ItemType("MeteorMasherBanner");
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
			npc.TargetClosest(true);
			Vector2 vector102 = new Vector2(npc.Center.X, npc.Center.Y);
			float num791 = Main.player[npc.target].Center.X - vector102.X;
			float num792 = Main.player[npc.target].Center.Y - vector102.Y;
			float num793 = (float)Math.Sqrt((double)(num791 * num791 + num792 * num792));
			float num794 = 12f;
			num793 = num794 / num793;
			num791 *= num793;
			num792 *= num793;
			npc.velocity.X = (npc.velocity.X * 100f + num791) / 101f;
			npc.velocity.Y = (npc.velocity.Y * 100f + num792) / 101f;
			npc.rotation = (float)Math.Atan2((double)num792, (double)num791) - 1.57f;
			int num795 = Dust.NewDust(npc.position, npc.width, npc.height, 180, 0f, 0f, 0, default(Color), 1f);
			Dust dust3 = Main.dust[num795];
			dust3.velocity *= 0.1f;
			Main.dust[num795].scale = 1.3f;
			Main.dust[num795].noGravity = true;
			bool hasTarget = false;
			Vector2 target = Vector2.Zero;
			float targetRange = 640f;//1600 was too much
			if (hasTarget)
			{
				Vector2 delta = target - npc.Center;
				delta.Normalize();
				delta *= 6f;
				int slot = Terraria.Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta.X, delta.Y, ProjectileID.StardustSoldierLaser, 32, 1f, Main.myPlayer, 0f, 0f);
				Main.projectile[slot].tileCollide = false;
				Main.projectile[slot].netUpdate = true;
			}
			npc.ai[0] = 0f;
			npc.netUpdate = true;
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
			return spawnInfo.player.GetModPlayer<CosmeticPlayer>(mod).ZoneStar && Main.hardMode ? 0.7f : 0f;
		}
		
		public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,(ItemID.Meteorite), Main.rand.Next(1,10));
			}
		}
	}
}