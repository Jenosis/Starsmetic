using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class HellfireMagnum : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.VenusMagnum);
			item.shootSpeed *= 0.75f;
			item.damage = (int)(item.damage * 3.5);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Pallasite", 25);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}