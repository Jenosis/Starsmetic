using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
	public class SolarBottleBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Solar Mana");
			Description.SetDefault("Replinish Mana faster and Melee attacks hit harder.");
			Main.buffNoTimeDisplay[Type] = true;
			
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.meleeDamage += 0.09f;
			player.manaRegen += 10;
		}
	}
}