using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
    public class BubblePopperMKI : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.damage = 8;
            item.melee = true;
			item.useStyle = 1;
			item.UseSound = SoundID.Item1;
            item.knockBack = 8;
            item.useTime = 20;
            item.useAnimation = 20;
            item.value = 1000;
            item.rare = 1;
            item.autoReuse = false;
        }
		public override void ModifyHitNPC(Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
		{
			if (target.type == mod.NPCType("SmallBubble")) damage += 15; 
		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood,3);
            recipe.AddTile(18);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}