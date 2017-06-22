using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using System;

namespace CosmeticVariety
{
	public class CosmeticWorld : ModWorld
	{
		public static bool accWeatherRadioHelper = false; //Weather Radio obviously
		public static bool accOreFinderHelper = false; //Metal Detector
		public static int accDepthMeterHelper = 0; //Depth obviously
		public static bool accCalendarHelper = false; // Moon Phases
		public static int accCompassHelper = 0; //Compass Obviously
		//public static int accWatchHelper = 0; //Time
		public static bool accCritterGuideHelper = false; //Rare Creatures
		public static bool accStopwatchHelper = false; // Stopwatch bviously
		public static bool accFishFinderHelper = false; //Fishing Power
		public static bool accDreamCatcherHelper = false; //DPS
		public static bool accThirdEyeHelper = false; //Radar
		public static bool accJarOfSoulsHelper = false; // Kill Count
		public static int starTiles = 0;
		public static int flowerTiles = 0;
		
		public override void ResetNearbyTileEffects()
		{
			accCalendarHelper = false;
			accCompassHelper = 0;
			accCritterGuideHelper = false;
			accDepthMeterHelper = 0;
			//accWatchHelper = 0;
			accOreFinderHelper = false;
			accStopwatchHelper = false;
			accWeatherRadioHelper = false;
			accFishFinderHelper = false;
			accDreamCatcherHelper = false;
			accThirdEyeHelper = false;
			accJarOfSoulsHelper = false;
			CosmeticPlayer modPlayer = Main.player[Main.myPlayer].GetModPlayer<CosmeticPlayer>(mod);
			modPlayer.starryPlinith = false;
			starTiles = 0;
			flowerTiles = 0;
			
		}
		public override void TileCountsAvailable(int[] tileCounts)
		{
			starTiles = tileCounts[mod.TileType("Starsoil")]+ tileCounts[mod.TileType("Starstone")];
			flowerTiles = tileCounts[mod.TileType("FertileSoil")]+ tileCounts[mod.TileType("Vinestone")];
		}
		public int RaycastDown(int x, int y)
        {
            while (!Main.tile[x, y].active())
            {
                y++;
                if (y > Main.maxTilesY - 20)
                {
                    break;
                }
            }
            return y;
        }
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int genIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (genIndex == -1)
            {
                return;
            }
            tasks.Insert(genIndex - 1, new PassLegacy("Garden", delegate (GenerationProgress progress)
            {
                progress.Message = "Assessing overgrowth";
                for (int i = 0; i < Main.maxTilesX / 1000; i++)       //900 is how many biomes. the bigger is the number = less biomes
                {
					int X = WorldGen.genRand.Next(600, Main.maxTilesX - 500);
                    int Y = RaycastDown(X, 0);
                   // int X = WorldGen.genRand.Next(1, Main.maxTilesX - 10);
                   // int Y = WorldGen.genRand.Next((int)Main.worldSurface - 10, Main.maxTilesY - 10);
                    int TileType = mod.TileType("FertileSoil");     //this is the tile u want to use for the biome , if u want to use a vanilla tile then its int TileType = 56; 56 is obsidian block

                    WorldGen.TileRunner(X, Y, 200, WorldGen.genRand.Next(30, 50), TileType, false, 0f, 0f, true, true);  //350 is how big is the biome     100, 200 this changes how random it looks.
					for(int k = 0; k < Main.maxTilesX / 25; k++)   
					{
						WorldGen.TileRunner(X + Main.rand.Next(-100, 101), Y + Main.rand.Next(-100, 101), 6, 6, mod.TileType("Vinestone"));
					}
                }

            }));
        }
		public void OreRunner(int i, int j, double strength, int steps, ushort type)
		{
			double num = strength;
			float num2 = (float)steps;
			Vector2 vector;
			vector.X = (float)i;
			vector.Y = (float)j;
			Vector2 vector2;
			vector2.X = (float)WorldGen.genRand.Next(-10, 11) * 0.1f;
			vector2.Y = (float)WorldGen.genRand.Next(-10, 11) * 0.1f;
			while (num > 0.0 && num2 > 0f)
			{
				if (vector.Y < 0f && num2 > 0f && type == 59)
				{
					num2 = 0f;
				}
				num = strength * (double)(num2 / (float)steps);
				num2 -= 1f;
				int num3 = (int)((double)vector.X - num * 0.5);
				int num4 = (int)((double)vector.X + num * 0.5);
				int num5 = (int)((double)vector.Y - num * 0.5);
				int num6 = (int)((double)vector.Y + num * 0.5);
				if (num3 < 0)
				{
					num3 = 0;
				}
				if (num4 > Main.maxTilesX)
				{
					num4 = Main.maxTilesX;
				}
				if (num5 < 0)
				{
					num5 = 0;
				}
				if (num6 > Main.maxTilesY)
				{
					num6 = Main.maxTilesY;
				}
				for (int k = num3; k < num4; k++)
				{
					for (int l = num5; l < num6; l++)
					{
						if ((double)(Math.Abs((float)k - vector.X) + Math.Abs((float)l - vector.Y)) < strength * 0.5 * (1.0 + (double)WorldGen.genRand.Next(-10, 11) * 0.015) && Main.tile[k, l].active() && (Main.tile[k, l].type == 1 || Main.tile[k, l].type == 6 ||Main.tile[k, l].type == 7 || Main.tile[k, l].type == 8 || Main.tile[k, l].type == 9 || Main.tile[k, l].type == 23 || Main.tile[k, l].type == 25 || Main.tile[k, l].type == 40 || Main.tile[k, l].type == 53 || Main.tile[k, l].type == 57 || Main.tile[k, l].type == 59 || Main.tile[k, l].type == 60 || Main.tile[k, l].type == 70 || Main.tile[k, l].type == 109 || Main.tile[k, l].type == 112 || Main.tile[k, l].type == 116 || Main.tile[k, l].type == 117 || Main.tile[k, l].type == 147 || Main.tile[k, l].type == 161 || Main.tile[k, l].type == 163 || Main.tile[k, l].type == 164 || Main.tile[k, l].type == 166 || Main.tile[k, l].type == 167 || Main.tile[k, l].type == 168 || Main.tile[k, l].type == 169 || Main.tileMoss[(int)Main.tile[k, l].type] || Main.tile[k, l].type == 199 || Main.tile[k, l].type == 200 || Main.tile[k, l].type == 203 || Main.tile[k, l].type == 234))
						{
							Main.tile[k, l].type = type;
							WorldGen.SquareTileFrame(k, l, true);
							if (Main.netMode == 2)
							{
								NetMessage.SendTileSquare(-1, k, l, 1, TileChangeType.None);
							}
						}
					}
				}
				vector += vector2;
				vector2.X += (float)WorldGen.genRand.Next(-10, 11) * 0.05f;
				if (vector2.X > 1f)
				{
					vector2.X = 1f;
				}
				if (vector2.X < -1f)
				{
					vector2.X = -1f;
				}
			}
		}
	/* //	public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
	//	{
	//		int genIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Micro Biomes"));
	//		tasks.Insert(genIndex + 1, new PassLegacy("Garden", delegate (GenerationProgress progress)
    //        {	
	//			progress.Message = "Assessing overgrowth";
	//			MakeGarden();
	//		}));
	//	}
	//	public int BlockLining(double x, double y, int repeats, int tileType, bool random, int max, int min = 3)
    //   {
   //         for (double i = x; i < x + repeats; i++)
    //        {
                if (random)
                {
                    for (double k = y; k < y + Main.rand.Next(min, max); k++)
                    {
						WorldGen.KillTile((int)i, (int)k);
                        WorldGen.PlaceTile((int)i, (int)k, tileType);
                    }
                }
                else
                {
                    for (double k = y; k < y + max; k++)
                    {
						WorldGen.KillTile((int)i, (int)k);
						WorldGen.PlaceTile((int)i, (int)k, tileType);
                    }
                }
            }
            return repeats;
        }
        public void MakeGarden()
        {
			int X = WorldGen.genRand.Next(1, Main.maxTilesX - 10);
			int Y = WorldGen.genRand.Next((int)Main.worldSurface - 10, Main.maxTilesY - 10);
			int TileType = mod.TileType("FertileSoil");     //this is the tile u want to use for the biome , if u want to use a vanilla tile then its int TileType = 56; 56 is obsidian block

			WorldGen.TileRunner(X, Y, 200, WorldGen.genRand.Next(30, 50), TileType, false, 0f, 0f, true, true);  //350 is how big is the biome     100, 200 this changes how random it looks.
   
            double X = WorldGen.genRand.Next(0, Main.maxTilesX);
            double Y = (double)Main.worldSurface - Main.rand.Next(90, 90);
            for (int i = 0; i < 13; i++)
            {
                if (i == 0)
                {
                    BlockLining(X, Y - 4, 4, mod.TileType("FertileSoil"), true, 6);
                }
                else if (i == 1)
                {
                    BlockLining(X + 4, Y - 3, 4, mod.TileType("FertileSoil"), true, 6);
                }
                else if (i == 2)
                {
                    BlockLining(X + 8, Y - 2, 4, mod.TileType("FertileSoil"), true, 6);
                }
                else if (i == 3)
                {
                    BlockLining(X + 12, Y - 1, 5, mod.TileType("FertileSoil"), true, 6);
                }
                else if (i == 4)
                {
                    BlockLining(X + 17, Y, 5, mod.TileType("FertileSoil"), true, 6);
                }
                else if (i == 5)
                {
                    BlockLining(X + 21, Y + 1, 6, mod.TileType("FertileSoil"), true, 6);
                }
                else if (i == 6)
                {
                    BlockLining(X + 27, Y + 2, 6, mod.TileType("FertileSoil"), true, 6);
                }
                else if (i == 7)
                {
                    BlockLining(X + 33, Y + 1, 7, mod.TileType("FertileSoil"), true, 6);
                }
                else if (i == 8)
                {
                    BlockLining(X + 40, Y, 5, mod.TileType("FertileSoil"), true, 6);
                }
                else if (i == 9)
                {
                    BlockLining(X + 45, Y - 1, 5, mod.TileType("FertileSoil"), true, 6);
                }
                else if (i == 10)
                {
                    BlockLining(X + 49, Y - 2, 4, mod.TileType("FertileSoil"), true, 6);
                }
                else if (i == 11)
                {
                    BlockLining(X + 53, Y - 3, 4,mod.TileType("FertileSoil"), true, 6);
                }
                else if (i == 12)
                {
                    BlockLining(X + 57, Y - 4, 4, mod.TileType("FertileSoil"), true, 6);
                }
                else if (i == 13)
                {
                    BlockLining(X + 61, Y - 5, 4, mod.TileType("FertileSoil"), true, 6);
                }
            }
            
            for (double i = X + 4; i < X + 57; i++)
			{
				WorldGen.KillTile((int)i, (int)Y - 4);
					WorldGen.PlaceTile((int)i, (int)Y - 4, mod.TileType("FertileSoil"));
			}
			for (double i = X + 8; i < X + 53; i++)
			{
			WorldGen.KillTile((int)i, (int)Y - 3);
							WorldGen.PlaceTile((int)i, (int)Y - 3, mod.TileType("FertileSoil"));
			}
			for (double i = X + 12; i < X + 49; i++)
			{
				WorldGen.KillTile((int)i, (int)Y - 2);
					WorldGen.PlaceTile((int)i, (int)Y - 2, mod.TileType("FertileSoil"));
			}
			for (double i = X + 16; i < X + 45; i++)
			{
				WorldGen.KillTile((int)i, (int)Y - 1);
					WorldGen.PlaceTile((int)i, (int)Y - 1, mod.TileType("FertileSoil"));
			}
			for (double i = X + 21; i < X + 40; i++)
			{
				WorldGen.KillTile((int)i, (int)Y);
					WorldGen.PlaceTile((int)i, (int)Y, mod.TileType("FertileSoil"));
			}
			for (double i = X + 26; i < X + 33; i++)
			{
				WorldGen.KillTile((int)i, (int)Y + 1);
					WorldGen.PlaceTile((int)i, (int)Y + 1, mod.TileType("FertileSoil"));
			}
        } */
    }
}
