using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.NPCs {
public class VanillaMobDrops : GlobalNPC
{
	public class Vanilla : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if(npc.type == 42)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HiveLamp"));
				}
			}
			if(npc.type == 42)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HiveLamp"));
				}
			}
			if(npc.type == 176)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HiveLamp"));
				}
			}
			if(npc.type == 231)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HiveLamp"));
				}
			}
			if(npc.type == 232)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HiveLamp"));
				}
			}
			if(npc.type == 233)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HiveLamp"));
				}
			}
			if(npc.type == 234)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HiveLamp"));
				}
			}
			if(npc.type == 235)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HiveLamp"));
				}
			}
			if(npc.type == 109)
			{
				if(Main.rand.Next(8) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("JokerCard"));
				}
			}
			if(npc.type == 475)
			{
				if(Main.rand.Next(5) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HallowedChest"));
				}
			}
			if(npc.type == 10)
			{
				if(Main.rand.Next(8) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GiantWormHead"));
				}
			}
			if(npc.type == 10)
			{
				if(Main.rand.Next(8) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GiantWormSegment"));
				}
			}
			if(npc.type == 10)
			{
				if(Main.rand.Next(8) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GiantWormTail"));
				}
			}
			if(npc.type == 121)
			{
				if(Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SlimerChandelier"));
				}
			}
			if(npc.type == 4)
			{
				if(Main.rand.Next(8) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("EyeofChandelier"));
				}
			}
			if(npc.type == 125)
			{
				if(Main.rand.Next(8) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TwinsChandelier"));
				}
			}
			if(npc.type == 126)
			{
				if(Main.rand.Next(8) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TwinsChandelier"));
				}
			}
			if(npc.type == 474)
			{
				if(Main.rand.Next(5) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CrimsonChest"));
				}
			}
			if(npc.type == 473)
			{
				if(Main.rand.Next(5) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CorruptionChest"));
				}
			}
			if(npc.type == 133)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WanderingEyeLamp"));
				}
			}
			if(npc.type == 10)
			{
				if(Main.rand.Next(8) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WormLamp"));
				}
			}
			if(npc.type == 95)
			{
				if(Main.rand.Next(8) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WormLamp"));
				}
			}
			if(npc.type == 49)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BatLantern"));
				}
			}
			if(npc.type == 51)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("JungleBatLantern"));
				}
			}
			if(npc.type == 60)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HellBatLantern"));
				}
			}
			if(npc.type == 93)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GiantBatChandelier"));
				}
			}
			if(npc.type == 137)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("IlluminantBatChandelier"));
				}
			}
			if(npc.type == 150)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("IceBatLantern"));
				}
			}
			if(npc.type == 151)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LavaBatLantern"));
				}
			}
			if(npc.type == 152)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GiantFlyingFoxChandelier"));
				}
			}
			if(npc.type == 158)
			{
				if(Main.rand.Next(10) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("VampireBatLantern"));
				}
			}
			if(npc.type == 39)
			{
				if(Main.rand.Next(8) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GiantWormHead"));
				}
			}
			if(npc.type == 39)
			{
				if(Main.rand.Next(8) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GiantWormSegment"));
				}
			}
			if(npc.type == 39)
			{
				if(Main.rand.Next(8) == 1)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GiantWormTail"));
				}
			}
			if(npc.type == 398)
			{
				if(Main.rand.Next(1) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CelestialBlossom"));
				}
			}
		}
	}
}}