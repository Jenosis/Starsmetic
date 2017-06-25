using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
    public class RoseThorn : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.NettleBurst);
            item.damage = (int)(item.damage * 1.5);
            item.width = 18;
            item.height = 18;
            item.damage = 110;
            item.magic = true;
            item.mana = 20;
            Item.staff[item.type] = true;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 5;
            item.useTime = 10;
            item.useAnimation = 10;
            item.value = 10000;
            item.rare = 2;
            item.autoReuse = false;
            item.shootSpeed = 32f;
        }
      

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Veridanite", 20);
            recipe.AddIngredient(null,"Rose",2);
            recipe.AddIngredient(null, "WeirdlyColoredPetal", 30);
            recipe.AddTile(null, "AegisContraption");
            recipe.SetResult(this);
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"DecorativeRoseThorn", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
        }
    }
}