using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class OrangePhasesaber : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.YellowPhasesaber);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrystalShard,50);
			recipe.AddIngredient(null,"OrangePhaseblade", 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}