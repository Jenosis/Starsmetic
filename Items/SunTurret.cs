using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class SunTurret : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Summons a stationary Sun to fight for you");
			DisplayName.SetDefault("Sun's Flare Staff");
		}
		public override void SetDefaults()
		{
			item.damage = 100;
			item.summon = true;
			item.mana = 10;
			item.width = 26;
			item.height = 28;
			item.useTime = 36;
			item.useAnimation = 36;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 30, 0, 0);
			item.rare = 9;
			item.UseSound = SoundID.Item81;
			item.shoot = mod.ProjectileType("SunTurret");
			item.shootSpeed = 10f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Pallasite",23);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}