using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
	public class Dreamstate : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Dreamstate");
			Description.SetDefault("A calming aura has enveloped the area averting aggression and promotes healing");
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.lifeRegen += 5;
			player.manaRegen += 5;
			player.ZonePeaceCandle = true;
		}
	}
}