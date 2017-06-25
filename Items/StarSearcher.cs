using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class StarSearcher : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 80;
			item.melee = true;
			item.width = 26;
			item.height = 28;
			item.useTime = 15;
			item.UseSound = SoundID.Item1;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 30, 0, 0);
			item.rare = 8;


		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"StarliteCore",4);
			recipe.AddIngredient(ItemID.Keybrand);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}