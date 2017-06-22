using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Buffs
{
    public class Jitters: ModBuff
    {
        public override void SetDefaults()
        {
			DisplayName.SetDefault("Jitters");
			Description.SetDefault("Sometimes too much caffiene is bad");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 0.80f;
            if (player.buffTime[buffIndex] <= 0)
            {
                player.AddBuff(BuffID.Slow, 7200); //300 = 5 seconds
            }
        }
	} 
}