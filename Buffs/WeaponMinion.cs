using System;
using Terraria;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
	public class WeaponMinion : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Armed and Dangerous");
			Description.SetDefault("Possessed weapons will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			CosmeticPlayer modPlayer = (CosmeticPlayer)player.GetModPlayer(mod, "CosmeticPlayer");
			if (player.ownedProjectileCounts[mod.ProjectileType("ShurkienMinion")] > 0)
			{
				modPlayer.weaponMinion = true;
			}
			if (player.ownedProjectileCounts[mod.ProjectileType("KunaiMinion")] > 0)
			{
				modPlayer.weaponMinion = true;
			}
			if (!modPlayer.weaponMinion)
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