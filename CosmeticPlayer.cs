using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace CosmeticVariety
{

    public class CosmeticPlayer : ModPlayer
    {
		private const int saveVersion = 0;
		public int score = 0;
		public bool starMinion = false;
		public bool elementMinion = false;
		public bool leafMinion = false;
		public bool starryPlinith = false;
		public bool weaponMinion = false;
        private bool ThrowBonus = false;  		//bool that stores true or false, if the set bonus is active
		public bool ZoneStar = false;
		public bool ZoneFlower = false;
		public float psychicDamage = 0f;
		public int psychicCrit = 0;
		public int willPower = 300; //say 300 is the default, change it to whatever you want
		public int willPowerMax = 300; //max amount, change it to whatever you want

		
		public override void ResetEffects()
		{
			starMinion = false;
			elementMinion = false;
			leafMinion = false;
			weaponMinion = false;
		}
		public override void UpdateBiomes()
		{
			ZoneStar = (CosmeticWorld.starTiles > 50);
			ZoneFlower = (CosmeticWorld.flowerTiles > 50);
		}
		public override bool CustomBiomesMatch(Player other)
        {
            CosmeticPlayer modOther = other.GetModPlayer<CosmeticPlayer>(mod);
            return ZoneStar == modOther.ZoneStar && ZoneFlower == modOther.ZoneFlower;       
        }

		public override void CopyCustomBiomesTo(Player other)
		{
			CosmeticPlayer modOther = other.GetModPlayer<CosmeticPlayer>(mod);
			modOther.ZoneStar = ZoneStar;
			modOther.ZoneFlower = ZoneFlower;
		}

		public override void SendCustomBiomes(BinaryWriter writer)
		{
			byte flags = 0;
			if (ZoneStar)
			{
				flags |= 1;
			}
			if (ZoneFlower)
			{
				flags |= 2;
			}
			writer.Write(flags);
		}

		public override void ReceiveCustomBiomes(BinaryReader reader)
		{
			byte flags = reader.ReadByte();
			ZoneStar = ((flags & 1) == 1);
			ZoneFlower = ((flags & 1) == 1);
		}

		public override void UpdateBiomeVisuals()
		{
			bool inStarryBiome = (ZoneStar || starryPlinith) && !NPC.AnyNPCs(NPCID.MoonLordCore);
			player.ManageSpecialBiomeVisuals("CosmeticVariety:StarrySky", inStarryBiome, player.Center);
		}
        public override void PostUpdateEquips()
        {
			player.accWeatherRadio |= CosmeticWorld.accWeatherRadioHelper;
			player.accCalendar |= CosmeticWorld.accCalendarHelper;
			player.accDepthMeter |= CosmeticWorld.accDepthMeterHelper;
			player.accCompass |= CosmeticWorld.accCompassHelper;
			player.accCritterGuide |= CosmeticWorld.accCritterGuideHelper;
			player.accOreFinder |= CosmeticWorld.accOreFinderHelper;
			player.accStopwatch |= CosmeticWorld.accStopwatchHelper;
			player.accFishFinder |= CosmeticWorld.accFishFinderHelper;
			player.accDreamCatcher |= CosmeticWorld.accDreamCatcherHelper;
			player.accThirdEye |= CosmeticWorld.accThirdEyeHelper;
			player.accJarOfSouls |= CosmeticWorld.accJarOfSoulsHelper;
			//player.accWatch |= CosmeticWorld.accWatchHelper;
            if (player.armor[0].type == mod.ItemType("OrionHelm") && player.armor[1].type == mod.ItemType("OrionBreastplate") && player.armor[2].type == mod.ItemType("OrionGreaves"))
            {   //^^ Replace "ItemID.WoodHelmet"  with "mod.ItemType("[class-name of the armor piece]")
                ThrowBonus = true;
            }
            else
            {
                ThrowBonus = false;
            }
        }
        public override void LoadLegacy(BinaryReader reader)
		{
			int loadVersion = reader.ReadInt32();
		}
        public override bool Shoot(Item item, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (item.thrown && ThrowBonus  )
            {
                damage += (int) Math.Ceiling((float)(damage * ((50d) / 100d)));   // damage* ((percentual damage increase)/100d)    if percentual damage increase is 50 then the resulting damage is 1.5*damage
				speedX *= 2f;       //Changing the speed of throwables
				speedY *= 2f;
            }
			return true;
        }
		//public override bool ConsumeuseAmmo(Item weapon, Item useAmmo)
		//{
		//	return true;
		//}
        public override void  OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)  // for NPCs
        {
            if (proj.thrown&&ThrowBonus)
            {
                if (Main.rand.NextDouble() < ((50d) / 100d))            //percentage is in the curved Brackets: (x)/100   x is the percentage from 0 to 100
                {
                    Main.player[proj.owner].HealEffect((int)(damage * (20f / 100f))); //Heal (x/100) heals x percent of the damage done
					Main.player[proj.owner].statLife+=(int)(damage * (20f / 100f));
                }
            }

        }
    }
}
