using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
    public class LotusWand : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Shoots a petal to inflict Frostburn on foes");
		}
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.damage = 10;
            item.magic = true;
			item.useStyle = 5;
			item.UseSound = SoundID.Item8;
            item.mana = 4;
            Item.staff[item.type] = true;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 5;
            item.useTime = 10;
            item.useAnimation = 10;
            item.value = 10000;
            item.rare = 2;
			item.shoot = mod.ProjectileType("LotusPetal");
            item.autoReuse = false;
            item.shootSpeed = 10f;
        }
      

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WandofSparking);
            recipe.AddIngredient(null,"Lotus",1);
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddTile(18);
            recipe.SetResult(this);
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
            recipe.AddIngredient(null,"DecorativeLotusWand",1);
			recipe.AddTile(null,"SculptingStand");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}