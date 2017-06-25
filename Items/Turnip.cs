using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class Turnip : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Beat 'em the Super Mario Bros. 2 way!");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.damage = 6;
			item.maxStack = 999;
			item.thrown = true;
			item.useStyle = 4;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 2;
			item.useTime = 10;
			item.consumable = true;
			item.noUseGraphic = true;
			item.useAnimation = 10;
			item.UseSound = SoundID.Item1;
			item.rare = 1;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("Turnip");
            item.shootSpeed = 9f;
		}
	}
}