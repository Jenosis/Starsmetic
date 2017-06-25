using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class ZillyWand : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.scale = 1.1f;
			item.magic = true;
			item.mana = 13;
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
			item.damage = 48;
			item.UseSound = SoundID.Item84;
		}
		int[] randType = new int[5] { ProjectileID.Flamelash, ProjectileID.WaterBolt,ProjectileID.CrystalStorm, ProjectileID.CursedFlameFriendly, ProjectileID.Leaf };
		public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			
			type = randType[Main.rand.Next(5)];
			
			return true;
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