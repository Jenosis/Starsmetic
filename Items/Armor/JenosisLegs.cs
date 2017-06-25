using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class JenosisLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Great for impersonating mod devs!");
		}
	
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.expert = true;
		}
	}
}