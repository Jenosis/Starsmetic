using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
    public class FlowerreficWand : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A culmination of all flower wands!");
		}
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.damage = 24;
            item.magic = true;
			item.useStyle = 5;
			item.UseSound = SoundID.Item8;
            item.mana = 10;
            Item.staff[item.type] = true;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 5;
            item.useTime = 10;
            item.useAnimation = 10;
            item.value = 5000;
            item.rare = 3;
			item.shoot = 1;
            item.autoReuse = false;
            item.shootSpeed = 10f;
        }
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			int[] randType = new int[5] { mod.ProjectileType("RosePetal"), mod.ProjectileType("TulipPetal"),mod.ProjectileType("TigerlilyPetal"),mod.ProjectileType("LotusPetal"),mod.ProjectileType("IrisPetal")};
			type = randType[Main.rand.Next(5)];
            int num = 3;
            float rotation = MathHelper.ToRadians(35);
            for (int i = 0; i < num; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (num - 1)));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, 12, player.whoAmI, 0f, 0f);
            }
            return true;
        }
      

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null,"IrisWand",1);
            recipe.AddIngredient(null,"RoseWand",1);
            recipe.AddIngredient(null,"TulipWand",1);
			recipe.AddIngredient(null,"LotusWand",1);
			recipe.AddIngredient(null,"TigerlilyWand",1);
            recipe.AddTile(18);
            recipe.SetResult(this);
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
            recipe.AddIngredient(null,"DecorativeFlowerrificWand",1);
			recipe.AddTile(null,"SculptingStand");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}