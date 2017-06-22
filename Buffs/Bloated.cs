using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
    public class Bloated : ModBuff
    {
        public override void SetDefaults()
        {
			DisplayName.SetDefault("Bloated");
			Description.SetDefault("Chances are you drank a whole carton of milk in a gulp");
            Main.buffNoTimeDisplay[Type] = false;
			Main.debuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed -= 0.10f;
            player.statDefense += 10;
        }
	}
}