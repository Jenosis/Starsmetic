using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
	public class Hot : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Hot");
			Description.SetDefault("Comfort food makes you immune to heat. Who knew!");
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.lavaImmune = true; 
		}
	}
}