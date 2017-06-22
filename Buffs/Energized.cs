using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
    public class Energized : ModBuff
    {
        public override void SetDefaults()
        {
			DisplayName.SetDefault("Energized");
			Description.SetDefault("You feel more more ready to take the world on");
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 0.15f;
            player.statDefense += 1;
            player.lifeRegen += 2;
        }
	}
}