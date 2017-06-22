using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
	public class Frosty : ModBuff
	{
		public override void SetDefaults()
		{
			Main.buffNoTimeDisplay[Type] = false;
			DisplayName.SetDefault("Frosty");
			Description.SetDefault("Feeling nice and chilly after that. Fire attacks don't seem to affect you much.");
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffImmune[BuffID.OnFire] = true;
		}
	}
}