using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class FloristBloom : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Rally);
			item.shoot = mod.ProjectileType("FlowerYoyo");
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"WeirdlyColoredPetal", 15);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}