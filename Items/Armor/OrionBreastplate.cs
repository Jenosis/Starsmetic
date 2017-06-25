using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor {
	[AutoloadEquip(EquipType.Body)]
public class OrionBreastplate : ModItem
{

    public override void SetDefaults()
    {
        item.width = 18;
        item.height = 18;
        item.value = 10000;
        item.rare = 9;
        item.defense = 8;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "Chalchum", 50);
        recipe.AddTile(null,"AegisContraption");
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}