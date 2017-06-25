using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
    public class Trowel: ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Useful for finding flowers!");
		}
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 25;
            item.maxStack = 1;
            item.value = 100;
            item.rare = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = false;  
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.AddTile(18);
            recipe.SetResult(this);
            recipe.AddRecipe();
			
			recipe= new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LeadBar, 1);
            recipe.AddTile(18);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}