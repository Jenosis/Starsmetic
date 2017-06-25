using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class ElementalCard : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Summons and Elemental Orb to fight for you");
			DisplayName.SetDefault("Summon Card");
		}
		public override void SetDefaults()
		{
			item.damage = 100;
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
			item.shoot = mod.ProjectileType("ElementalOrb");
			item.shootSpeed = 10f;
			item.buffType = mod.BuffType("ElementalOrb");
			item.buffTime = 300;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Mantilum",27);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}