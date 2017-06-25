using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class Galaxicannon : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.StarCannon);
			item.shootSpeed *= 0.75f;
			item.rare = 9;
			item.damage = (int)(item.damage * 3.5);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StarCannon);
			recipe.AddIngredient(null,"StarlightOre", 18);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}