using System;
using Terraria;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
	public class ShootingStar : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Shooting Star");
			Description.SetDefault("Look at the stars; how they fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
		public override void Update(Player player, ref int buffIndex)
		{
			CosmeticPlayer modPlayer = (CosmeticPlayer)player.GetModPlayer(mod, "CosmeticPlayer");
			if (player.ownedProjectileCounts[mod.ProjectileType("ShootingStar")] > 0)
			{
				modPlayer.starMinion = true;
			}
			if (!modPlayer.starMinion)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
			{
				player.buffTime[buffIndex] = 18000;
			}
		}
	}
}