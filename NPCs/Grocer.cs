using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.NPCs
{
	public class Grocer : ModNPC
	{

		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			Main.npcFrameCount[npc.type] = 25;
			NPCID.Sets.ExtraFramesCount[npc.type] = 9;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 90;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
			animationType = NPCID.Guide;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			int num = npc.life > 0 ? 1 : 5;
			for (int k = 0; k < num; k++)
			{
				Dust.NewDust(npc.position, npc.width, npc.height, mod.DustType("Pixel"));
			}
		}

		public override bool CanTownNPCSpawn(int numTownNPCs, int money) //thank you Yorai for helping with this <3
        {
            int appleID = mod.ItemType("Apple");
            for (int i = 0; i < Main.maxPlayers; i++)
                if (Main.player[i].active && Main.player[i].HasItem(appleID))
                    return true;
            return false;
        }

		public override string TownNPCName()
		{
			switch (WorldGen.genRand.Next(4))
			{
				case 0:
					return "Bruce";
				case 1:
					return "George";
				case 2:
					return "Randle";
				default:
					return "Tyler";
			}
		}

		public override string GetChat()
		{
			switch (Main.rand.Next(5))
			{
			case 0:
				return "Man interdimensional travelling by produce isn't what I thought it would be.";
			case 1:
				return "Fruit and veggies help make a mean stew... and healthy lifestyle!";
			case 2:
				return "You can get flowers by carrying a Trowel with you. You need an Iron/Lead Bar for one.";		
			case 3:
				return "After you beat this worlds' evil; I hear you can get some neat stuff from a toy vending machine!";
			default:
				return "Greenhouses are the best. They can grow produce any time of the year!";
			}
		}

		public override void SetChatButtons(ref string button, ref string button2)
		{
			button = Lang.inter[28].Value;
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool shop)
		{
			if (firstButton)
			{
				shop = true;
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot)
		{
			shop.item[nextSlot].SetDefaults(mod.ItemType("Sugar"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Fertilizer"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("SweetBlock"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Milk"));      //this defines what item to sell .
            shop.item[nextSlot].shopCustomPrice = new int?(20);  //this is the custom price, so this item will cost 20 custom Currency
            shop.item[nextSlot].shopSpecialCurrency = CosmeticVariety.CustomCurrencyID;  //this make so to use the CustomCurrency            
            nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Egg"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Orange"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Watermelon"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Cherry"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Lemon"));
			nextSlot++;
			if (NPC.downedBoss2)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("ToyVendingMachine"));
				nextSlot++;
			}
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 20;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 30;
			randExtraCooldown = 30;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = mod.ProjectileType("Fruit");
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 12f;
			randomOffset = 2f;
		}
	}
}