using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
	public class FrightBottleBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Power of Fright");
			Description.SetDefault("Enemies fear your might");
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.moveSpeed += 0.30f;
			player.archery = true;
			player.thorns += 2f;
		}
	}
}