using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{

	public class BoringKatana : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("It's just a regular old boring katana; kinda disappointing actually");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Excalibur);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"ZilliumBar", 18);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}