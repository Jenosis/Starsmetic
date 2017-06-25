using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class StarRod : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.RainbowRod);
			item.damage = (int)(item.damage * 1.5);
			item.width = 18;
			item.height = 18;
			item.damage = 160;
			item.magic = true;
			item.mana = 10;
			item.useStyle = 1;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.useTime = 10;
			item.useAnimation = 10;
			item.value = 10000;
			item.rare = 9;
            item.autoReuse = false;          
			item.shoot = mod.ProjectileType("StarProj");
            item.shootSpeed = 10f;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = mod.ProjectileType("StarProj");
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "StarlightOre", 20);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"DecorativeStarRod", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}