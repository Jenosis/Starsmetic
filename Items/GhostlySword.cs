using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class GhostlySword : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.damage = 120;
			item.magic = true;
			item.mana = 10;
			item.useStyle = 4;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.useTime = 5;
			item.UseSound = SoundID.Item8;
			item.noUseGraphic = true;
			item.useAnimation = 10;
			item.value = 10000;
			item.rare = 9;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("GhostSword");
            item.shootSpeed = 10f;
		}
		public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
		    position = Main.MouseWorld;
			speedX = 0;
			speedY = 3;
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Chalchum", 25);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}