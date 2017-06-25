using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor
{
	[AutoloadEquip(EquipType.Wings)]
	public class JenosisWings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Great for impersonating mod devs!");
		}

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.rare = 9;
			item.expert = true;
            item.value = 10000000;
            item.accessory = true;
            //BaseMod.BaseUtility.AddTooltips(item, new string[] { "Allows extreme flight and feather fall", "'Great for impersonating awesome friends!'"});			
        }

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 3000;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 9f;
			acceleration *= 2.5f;
		}

        public override void UpdateEquip(Player p)
        {
			p.slowFall = true;
		}
	}
}