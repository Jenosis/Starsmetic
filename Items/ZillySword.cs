using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class ZillySword: ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("There we go! It's nice and whimsical now.");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.TrueExcalibur);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"BoringKatana", 1);
			recipe.AddIngredient(ItemID.BrokenHeroSword);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}