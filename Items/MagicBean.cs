using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class MagicBean : ModItem
	{
		public override void SetStaticDefaults()
		{
			// See here for help on using Tags: http://terraria.gamepedia.com/Chat#Tags
			Tooltip.SetDefault("A strange bean. The Grocer and Grandma might be interested in these");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = 100;
			item.rare = 1;
		}

		public override Color? GetAlpha(Color lightColor)
		{
			return Color.ForestGreen;
		}

	}
}