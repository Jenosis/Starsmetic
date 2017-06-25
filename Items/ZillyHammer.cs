using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class ZillyHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Warhammer of Zillyhoo");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Pwnhammer);
			item.width = 18;
			item.height = 18;
			item.scale = 1.1f;
			item.melee = true;
			item.useStyle = 1;
			item.knockBack = 5;
			item.useTime = 5;
			item.useAnimation = 10;
			item.value = 10000;
			item.rare = 4;
			item.useTime = 12;
			item.damage = 42;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"ZilliumBar", 13);
			recipe.AddIngredient(ItemID.Pwnhammer, 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}