using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class Bubblio : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.damage = 30;
			item.magic = true;
			item.UseSound = SoundID.Item8;
			item.mana = 14;
			item.useStyle = 4;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.useTime = 19;
			item.useAnimation = 18;
			item.value = 1000;
			item.rare = 5;
            item.autoReuse = true;
            item.shoot = ProjectileID.Bubble;
            item.shootSpeed = 12f;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			for (int i = 0; i < 5; ++i)
			{
			    if(Main.myPlayer == player.whoAmI)
                {
				    Vector2 mouse = Main.MouseWorld;
				    Projectile.NewProjectile(mouse.X + Main.rand.Next(-80, 80), player.Center.Y - 470 + Main.rand.Next(-50, 50), 0, Main.rand.Next(15,25), ProjectileID.Bubble, damage, knockBack, player.whoAmI);
			    }
			}
			return false;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bubble, 10);
			recipe.AddIngredient(null,"StarliteCore", 1);
			recipe.AddIngredient(null,"Bubble",1);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

	}
}