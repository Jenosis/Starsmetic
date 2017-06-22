using System;
using Terraria;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
	public class ElementalOrb : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Elemental Orb");
			Description.SetDefault("The orb will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			CosmeticPlayer modPlayer = (CosmeticPlayer)player.GetModPlayer(mod, "CosmeticPlayer");
			if (player.ownedProjectileCounts[mod.ProjectileType("ElementalOrb")] > 0)
			{
				modPlayer.elementMinion = true;
			}
			if (!modPlayer.elementMinion)
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