using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class StarliteFragments : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("Illustrious star fragments that are carried from Monstars: Ghoul and Zar");
	}
    public override void SetDefaults()
    {
        item.width = 12;
        item.height = 12;
        item.maxStack = 999;
        item.useTurn = true;
		item.value = 2500;
    }
	
}}