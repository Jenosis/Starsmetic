using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class EquinoxLantern : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 180;
			item.magic = true;
			item.UseSound = SoundID.Item34;
			item.mana = 15;
			item.width = 26;
			item.height = 28;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 30, 0, 0);
			item.rare = 9;
			item.shoot = (ProjectileID.Flames);
			item.shootSpeed = 10f;

		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Pallasite",24);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"DecorativeEquinoxLantern", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}