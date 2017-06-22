using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
    public class LifeAura : ModBuff
    {
        public override void SetDefaults()
        {
			DisplayName.SetDefault("Life Aura");
			Description.SetDefault("You feel the life extending effects of Life Fruit");
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statLifeMax2 += 25;
        }
	}
}