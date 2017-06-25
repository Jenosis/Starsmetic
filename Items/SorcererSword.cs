using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class SorcererSword : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 180;
			item.melee = true;
			item.width = 26;
			item.height = 28;
			item.useTime = 15;
			item.UseSound = SoundID.Item71;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 30, 0, 0);
			item.rare = 9;
			item.shoot = mod.ProjectileType("MagicWave");
			item.shootSpeed = 10f;

		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Mantilum",24);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}