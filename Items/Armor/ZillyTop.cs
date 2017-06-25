using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor {
	[AutoloadEquip(EquipType.Head)]
public class ZillyTop : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("Adds 12% Magic Damage, Crit, and 100 Max Mana");
	}
	
    public override void SetDefaults()
    {
        item.width = 18;
        item.height = 18;
        item.value = 10000;
        item.rare = 5;
        item.defense = 6;
    }
	public override bool IsArmorSet(Item head, Item body, Item legs)
	{
		return body.type == mod.ItemType("ZillyBreastplate") && legs.type == mod.ItemType("ZillyGreaves");
	}
	public override void UpdateEquip(Player player)
	{
		player.magicDamage += 0.12f;
		player.magicCrit += 12;
		player.statManaMax2 += 100;
		player.moveSpeed += 0.05f;
	}
	public override void UpdateArmorSet(Player player)
	{
		player.setBonus = "It's a mystery";
		player.jumpSpeedBoost += 10f;
		player.moveSpeed += 0.15f;
		player.manaCost -= 0.20f;
	}
    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null,"ZilliumBar",12);
        recipe.AddTile(134);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}