using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
	public class VortexBottleBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Vortex Mana");
			Description.SetDefault("Replenish Mana faster and ranged weapons hit harder");
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.rangedDamage += 0.09f;
			player.manaRegen += 10;
		}
	}
}