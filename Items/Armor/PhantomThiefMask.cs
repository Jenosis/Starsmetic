using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor {
	[AutoloadEquip(EquipType.Head)]
public class PhantomThiefMask : ModItem
{
	
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("Mask of the leader of the heart thieves");
	}

    public override void SetDefaults()
    {
        item.width = 18;
        item.height = 18;
        item.value = 10000;
        item.rare = 2;
        item.vanity = true;
    }
	public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
	{
		drawHair = true;
	}

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.BlackThread, 5);
		recipe.AddIngredient(ItemID.Silk, 10);
        recipe.AddTile(86);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}