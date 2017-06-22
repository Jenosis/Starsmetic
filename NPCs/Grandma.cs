using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.NPCs
{
	public class Grandma : ModNPC
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
			animationType = NPCID.TaxCollector;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			int num = npc.life > 0 ? 1 : 5;
			for (int k = 0; k < num; k++)
			{
				Dust.NewDust(npc.position, npc.width, npc.height, mod.DustType("Vortex"));
			}
		}

		public override bool CanTownNPCSpawn(int numTownNPCs, int money) //thank you Yorai for helping with this <3
        {
            
            return true;
        }

		public override string TownNPCName()
		{
			switch (WorldGen.genRand.Next(5))
			{
				case 0:
					return "Smith";
				case 1:
					return "Esther";
				case 2:
					return "Lucy";
				case 3:
					return "Patricia";
				default:
					return "Donita";
			}
		}
		public override bool CheckConditions(int left, int right, int top, int bottom)
		{
			int score = 0;
			for (int x = left; x <= right; x++)
			{
				for (int y = top; y <= bottom; y++)
				{
					int type = Main.tile[x, y].type;
					if (type == mod.TileType("CookBook"))
					{
						score++;
					}
				}
			}
			return score >= 1;
		}

		public override string GetChat()
		{
			switch (Main.rand.Next(5))
			{
			case 0:
				return "Hello dearie would you like a freshly baked cookie?";
			case 1:
				return "Come now. Sit down wih your dear grandma and tell me about your day.";
			case 2:
				return "Hopefully there'll be a farm here one day; just like your grandpa's";		
			case 3:
				return "I remember the days when me and your grandpa were pioneers.";
			default:
				return "Goodness! "+ Main.player[Main.myPlayer].name + " is that you? You should visit more often!";
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
			shop.item[nextSlot].SetDefaults(mod.ItemType("AppleSaber")); 
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("CherryFlail")); 
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("PotatoSeeds"));      //this defines what item to sell .
            shop.item[nextSlot].shopCustomPrice = new int?(25);  //this is the custom price, so this item will cost 20 custom Currency
            shop.item[nextSlot].shopSpecialCurrency = CosmeticVariety.CustomCurrencyID;  //this make so to use the CustomCurrency            
            nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("PepperSeeds"));      //this defines what item to sell .
            shop.item[nextSlot].shopCustomPrice = new int?(30);  //this is the custom price, so this item will cost 20 custom Currency
            shop.item[nextSlot].shopSpecialCurrency = CosmeticVariety.CustomCurrencyID;  //this make so to use the CustomCurrency            
            nextSlot++;
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