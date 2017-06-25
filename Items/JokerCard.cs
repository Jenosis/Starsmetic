using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class JokerCard : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("A whimsical looking card. Maye cause side-effects underground.");
	}
    public override void SetDefaults()
    {
        item.width = 24;
        item.height = 25;
        item.maxStack = 999;
        item.value = 1000;
        item.rare = 1;
		item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 20;
        item.useTime = 20;
        item.useStyle = 1;
        item.consumable = true;
    }
	public override bool UseItem(Player player)
	{
		if(Main.myPlayer == player.whoAmI)
		{
			if(Main.netMode == 1)
			{
				MNetSync.SendNetMessage(mod, MNetSync.SpawnOreZillium, 0);
			}else
			{
				SpawnOre(mod);
			}
		}
		Main.NewText("Haha hehe hoohoo....", 100, 220, 100);		
		return true;
	}
	public static void SpawnOre(Mod mod)
	{
		if(Main.netMode == 1) return;
		for(double k = 0; k < (Main.maxTilesX - 200) * (Main.maxTilesY - 150 - (int)Main.rockLayer) / 5000.0; k += 1.0)
		{
			WorldGen.OreRunner(WorldGen.genRand.Next(100, Main.maxTilesX - 100), WorldGen.genRand.Next((int)Main.rockLayer, Main.maxTilesY - 150), (double)WorldGen.genRand.Next(4, 8), WorldGen.genRand.Next(4, 8), (ushort)mod.TileType("ZilliumOre"));
		}
	}

}}