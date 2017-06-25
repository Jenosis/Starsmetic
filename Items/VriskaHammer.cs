using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class VriskaHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pop-a-VrillyHoo");
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
			item.useTime = 10;
			item.useAnimation = 10;
			item.value = 10000;
			item.rare = 4;
			item.useTime = 12;
			item.damage = 50;
			item.shoot = 1;
			item.shootSpeed= 9f;
			item.UseSound = SoundID.Item1;
		}
		int[] randType = new int[5] { ProjectileID.Shuriken, ProjectileID.Bone,ProjectileID.HappyBomb, ProjectileID.BoneJavelin, ProjectileID.BouncyGrenade };
		public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			
			type = randType[Main.rand.Next(5)];
			
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"BlueDiceWeapon", 1);
			recipe.AddIngredient(null,"ZillyHammer", 1);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}