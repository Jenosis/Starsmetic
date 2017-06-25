using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class OrangePhaseblade : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.YellowPhaseblade);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Amber, 10);
			recipe.AddIngredient(ItemID.MeteoriteBar, 15);
			recipe.AddTile(17);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}