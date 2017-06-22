using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
	public class SightBottleBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Power of Sight");
			Description.SetDefault("See all* around you.*Doesn't stop blindness.");
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.findTreasure = true;
			player.detectCreature = true;
			player.dangerSense = true;
		}
	}
}