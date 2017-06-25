using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class SuperScythe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Thanatos");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.DeathSickle);
			item.scale = 1.3f;
			item.shootSpeed = 15f;
			item.rare = 9;
			item.damage = (int)(item.damage * 3.0);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Pallasite", 40);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}