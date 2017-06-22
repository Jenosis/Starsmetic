using System;
using Terraria;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
	public class LeafMinion : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Leafy Greens");
			Description.SetDefault("This leaf will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			CosmeticPlayer modPlayer = (CosmeticPlayer)player.GetModPlayer(mod, "CosmeticPlayer");
			if (player.ownedProjectileCounts[mod.ProjectileType("LeafMinion")] > 0)
			{
				modPlayer.leafMinion = true;
			}
			if (!modPlayer.leafMinion)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
			{
				player.buffTime[buffIndex] = 18000;
			}
		}
	}
}