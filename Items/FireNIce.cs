using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class FireNIce: ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Rally);
			item.damage = 45;
			item.shoot = mod.ProjectileType("FireIce");
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Amarok,1);
			recipe.AddIngredient(ItemID.HelFire,1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}