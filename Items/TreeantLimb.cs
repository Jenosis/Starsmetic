using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class TreeantLimb : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Summons a magical leaf to fight for you");
			DisplayName.SetDefault("Veridian Tree Limb");
		}
		public override void SetDefaults()
		{
			item.damage = 90;
			item.summon = true;
			item.mana = 10;
			item.width = 26;
			item.height = 28;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 30, 0, 0);
			item.rare = 9;
			item.UseSound = SoundID.Item81;
			item.shoot = mod.ProjectileType("LeafMinion");
			item.shootSpeed = 10f;
			item.buffType = mod.BuffType("LeafMinion");
			item.buffTime = 300;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Veridanite",24);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}