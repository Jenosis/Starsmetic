using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class StarwoodMallet : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.melee = true;
			item.hammer = 75;
			item.useStyle = 1;
			item.knockBack = 5;
			item.autoReuse = true;
			item.useTime = 10;
			item.useAnimation = 15;
			item.value = 100;
			item.UseSound = SoundID.Item1;
			item.rare = 4;
			item.useTime = 12;
			item.damage = 22;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Starwood", 15);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}