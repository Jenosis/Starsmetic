using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
	public class MightBottleBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Power of Might");
			Description.SetDefault("You feel stronger in all aspects");
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.meleeDamage += 0.07f;
			player.meleeCrit = 7;
			player.magicDamage += 0.07f;
			player.magicCrit = 7;
			player.rangedDamage += 0.07f;
			player.rangedCrit = 7;
			player.minionDamage += 0.07f;
			player.minionKB = 7;
			player.thrownDamage += 0.07f;
			player.thrownCrit = 7;			
		}
	}
}