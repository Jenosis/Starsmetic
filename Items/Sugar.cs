using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class Sugar : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("The staple of sweets");
	}
    public override void SetDefaults()
    {
        item.width = 12;
        item.height = 12;
        item.maxStack = 999;
        item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
		item.value = 100;
        item.useTime = 30;
        item.consumable = true;
		
    }

    public override void AddRecipes()
    {
     
    }
}}