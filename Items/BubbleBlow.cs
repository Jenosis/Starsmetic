using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class BubbleBlow : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.WoodYoyo);
			item.shoot = mod.ProjectileType("BubbleYoyo");
		}
	}
}