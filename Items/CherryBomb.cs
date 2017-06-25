using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
    public class CherryBomb : ModItem
    {
        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.shootSpeed = 5f;
            item.shoot = 28;
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.consumable = true;
            item.UseSound = SoundID.Item1;
            item.useAnimation = 25;
            item.useTime = 25;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.value = Item.buyPrice(0, 0, 3, 0);
            item.damage = 0;
            item.shoot = mod.ProjectileType("CherryBomb");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Cherry", 5);
			recipe.AddIngredient(ItemID.Torch, 3);
            recipe.SetResult(this, 3);
            recipe.AddRecipe();
        }
    }
}