using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class CallToArms : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A broken isignia shield that summons weapon minions");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.damage = 85;
			item.summon = true;
			item.mana = 10;
			item.useStyle = 1;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.useTime = 5;
			item.noUseGraphic = true;
			item.useAnimation = 10;
			item.value = 10000;
			item.UseSound = SoundID.Item81;
			item.rare = 9;
            item.autoReuse = false;
            item.shoot = 1;
            item.shootSpeed = 10f;
			item.buffType = mod.BuffType("WeaponMinion");
		}
		public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int[] randType = new int[2] { mod.ProjectileType("ShurikenMinion"), mod.ProjectileType("KunaiMinion") };
			type = randType[Main.rand.Next(2)];
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