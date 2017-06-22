using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
	public class Spicy : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Spicy");
			Description.SetDefault("You don't think ice will affect you anytime soon..");
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.moveSpeed += 0.25f;
			player.buffImmune[BuffID.Frozen] = true;
		}
	}
}