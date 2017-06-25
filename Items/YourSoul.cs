using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class YourSoul : JItem
	{
		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.damage = 14;
			psychic = true;
			//item.GetModInfo<JInfo>(mod).willNeeded = 3;
			item.useStyle = 1;
			item.knockBack = 10;
			item.useTime = 6;
			item.useAnimation = 10;
			item.value = 10000;
			item.rare = 12;
            item.autoReuse = true;
            item.shoot = ProjectileID.StarWrath;
            item.shootSpeed = 15f;
		}
	}
}