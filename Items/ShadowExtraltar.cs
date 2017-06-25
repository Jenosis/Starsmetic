using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
    public class ShadowExtraltar : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A corrupt malfunctioning Demon Altar that allow for Shadow harvesting");
		}
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 25;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("ShadowExtraltar");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CursedFlame, 12);
			recipe.AddIngredient(ItemID.DemoniteBar, 10);
            recipe.AddTile(16);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}