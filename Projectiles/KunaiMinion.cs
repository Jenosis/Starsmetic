using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Projectiles
{
	public class KunaiMinion : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.netImportant = true;
			projectile.width = 26;
			projectile.height = 26;
			projectile.friendly = true;
			projectile.aiStyle = 66;
			projectile.minion = true;
			projectile.minionSlots = 1;
			projectile.penetrate = -1;
			projectile.timeLeft = 18000;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
			ProjectileID.Sets.Homing[projectile.type] = true;
			aiType = ProjectileID.Spazmamini;
		}
		public override void AI()
		{
			bool flag64 = projectile.type == mod.ProjectileType("KunaiMinion");
			Player player = Main.player[projectile.owner];
			CosmeticPlayer modPlayer = player.GetModPlayer<CosmeticPlayer>(mod);
			if (flag64)
			{
				if(player.dead)
				{
					modPlayer.weaponMinion = false;
				}
				if (modPlayer.weaponMinion)
				{
					projectile.timeLeft =2;
				}
			}
		}
		public override bool MinionContactDamage()
		{
			return true;
		}
	}
}