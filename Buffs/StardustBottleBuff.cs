using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
	public class StardustBottleBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Stardust Mana");
			Description.SetDefault("Replenish Mana faster and Summons get an extra punch");
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.minionDamage += 0.09f;
			player.manaRegen += 10;

		}
	}
}