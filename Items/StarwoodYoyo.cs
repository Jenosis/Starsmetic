using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class StarwoodYoyo : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Cascade);
			item.damage = 28;
			item.shoot = mod.ProjectileType("Staryoyo");
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