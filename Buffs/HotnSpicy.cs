using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
	public class HotnSpicy : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Hot'n'Spicy");
			Description.SetDefault("It's an inferno in your mouth! Combined effects of Spicy and Hot");
			Main.buffNoTimeDisplay[Type] = true;

		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.moveSpeed += 0.25f;
			player.buffImmune[BuffID.Frozen] = true;
			player.buffImmune[BuffID.OnFire] = true;
			player.buffImmune[BuffID.Chilled] = true;
			player.lavaImmune = true; 
		}
	}
}