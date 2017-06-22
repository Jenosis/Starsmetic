using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
	public class NebulaBottleBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Nebula Mana");
			Description.SetDefault("Replenish Mana faster and magic does more damage");
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.magicDamage += 0.09f;
			player.manaRegen += 10;
		}
	}
}