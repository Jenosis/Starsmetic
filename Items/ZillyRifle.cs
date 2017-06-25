using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class ZillyRifle : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Shotgun);
			item.width = 18;
			item.height = 18;
			item.scale = 1.1f;
			item.ranged = true;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.useTime = 5;
			item.useAnimation = 10;
			item.value = 10000;
			item.rare = 4;
			item.useTime = 12;
			item.shoot = 1;
			item.shootSpeed = 15f;
			item.damage = 45;
			item.UseSound = SoundID.Item41;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"ZilliumBar", 11);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}