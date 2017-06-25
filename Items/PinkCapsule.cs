using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class PinkCapsule: ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("There's something inside; open it!");
	}
    public override void SetDefaults()
    {
        item.width = 24;
        item.height = 25;
        item.maxStack = 999;
        item.value = 3000;
        item.rare = 1;
		item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 30;
        item.useStyle = 1;
    }
	public override bool CanRightClick()
	{
		return true;
	}

	public override void RightClick(Player player)
	{
		if (Main.rand.Next(3) == 0)
            player.QuickSpawnItem(mod.ItemType("WhiteChocolateBlock"),Main.rand.Next(5,15));
		else if (Main.rand.Next(3) == 1)
            player.QuickSpawnItem(mod.ItemType("MilkChocolateBlock"),Main.rand.Next(5,15));
		else if (Main.rand.Next(3) == 2)
			player.QuickSpawnItem(mod.ItemType("ChocolateBlock"),Main.rand.Next(5,15));
		else
			player.QuickSpawnItem(mod.ItemType("CottonCandyBlock"),Main.rand.Next(5,15));
	}
}}