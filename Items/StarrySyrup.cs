using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items {
public class StarrySyrup: ModItem
{
    public override void SetDefaults()
	{
        item.width = 24;
        item.height = 25;
        item.maxStack = 30;
        item.value = 500;
        item.rare = 2;
		item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 30;
        item.useTime = 30;
        item.useStyle = 2;
		item.healMana = 25;
		item.UseSound = SoundID.Item3;
        item.consumable = true;
    }
}}