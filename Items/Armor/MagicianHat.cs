using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class MagicianHat : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Adds 15% Magic Damage nd 5% Crit");
		}


		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.damage = 120;
			item.magic = true;
			item.UseSound = SoundID.Item84;
			item.mana = 12;
			item.useStyle = 4;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.useTime = 5;
			item.useAnimation = 10;
			item.value = 10000;
			item.rare = 9;
            item.autoReuse = true;
            item.shoot = 1;
            item.shootSpeed = 15f;
            item.defense = 18;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("MagicianCoat") && legs.type == mod.ItemType("MagicianPants");
		}
		public override void UpdateEquip(Player player)
		{
			player.magicDamage += 0.15f;
			player.magicCrit = 5;
		}

		public override void UpdateArmorSet(Player player)
		{
			if (player.nebulaCD > 0)
			{
				player.nebulaCD--;
			}
			player.setNebula = true;
			player.setBonus = "Nebulas still appear. Double tap the DOWN KEY for a vanishing act!";
			if ((player.controlDown && player.releaseDown))
            {
                if (player.doubleTapCardinalTimer[0] > 0 && player.doubleTapCardinalTimer[0] != 15) // down
                {
                   player.Center = Main.MouseWorld;
                   Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/Teleport"));
                }
            }
            player.statManaMax2 += 100;
        }
		public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
		{
			drawHair = true;
			drawAltHair = true;
		}
		public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int[] randType = new int[4] { mod.ProjectileType("Heartcard"), mod.ProjectileType("Diamondcard"),mod.ProjectileType("Spadecard"), mod.ProjectileType("Clubcard") };
			type = randType[Main.rand.Next(4)];
			float spread = 45f * 0.0174f;//45 degrees converted to radians
			float baseSpeed = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double baseAngle = Math.Atan2(speedX, speedY);
			double randomAngle = baseAngle+(Main.rand.NextFloat()-0.5f)*spread;
			speedX = baseSpeed*(float)Math.Sin(randomAngle);
			speedY = baseSpeed*(float)Math.Cos(randomAngle);
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Mantilum", 30);
			recipe.AddIngredient(ItemID.NebulaHelmet,1);
			recipe.AddTile(null,"AegisContraption");
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"DecorativeMagicHat", 1);
			recipe.AddTile(null,"SculptingStand");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}