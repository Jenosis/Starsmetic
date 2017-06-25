using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class Bubble : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.damage = 12;
			item.magic = true;
			item.UseSound = SoundID.Item8;
			item.mana = 12;
			item.useStyle = 4;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.useTime = 19;
			item.useAnimation = 18;
			item.value = 100;
			item.rare = 2;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("BubbleProj");
            item.shootSpeed = 10f;
		}

	}
}