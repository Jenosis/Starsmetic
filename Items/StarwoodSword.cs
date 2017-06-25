using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class StarwoodSword : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 28;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.maxStack = 1;
			item.useTime = 17;
			item.useAnimation = 17;
			item.knockBack = 7f;
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.value = Item.sellPrice(0, 0, 9, 0);
			item.rare = 2;
			item.shootSpeed = 9f;
			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Starwood", 10);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}