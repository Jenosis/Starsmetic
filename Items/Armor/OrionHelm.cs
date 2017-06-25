using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor {
	[AutoloadEquip(EquipType.Head)]
public class OrionHelm : ModItem
{
	
    public override void SetDefaults()
    {
        item.width = 18;
        item.height = 18;
        item.value = 10000;
        item.rare = 9;
        item.defense = 6;
    }
	public override bool IsArmorSet(Item head, Item body, Item legs)
	{
		return body.type == mod.ItemType("OrionBreastplate") && legs.type == mod.ItemType("OrionGreaves");
	}
	public override void UpdateArmorSet(Player player)
	{
		player.setBonus = "Thrown weapons heal on enemy damage and have a 50% chance to not be consumed on use";
		player.thrownCost50 = true; 
	}
    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "Chalchum", 30);
        recipe.AddTile(null,"AegisContraption");
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}