using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Tiles {
public class Starsoil : ModTile
{
    public override void SetDefaults()
    {
        Main.tileSolid[Type] = true;
		Main.tileMerge[Type][mod.TileType("ManaStarBlock")] = true;
		Main.tileMerge[Type][mod.TileType("StarshineBlock")] = true;
		Main.tileMerge[Type][mod.TileType("StarshineBrick")] = true;
		Main.tileMerge[Type][mod.TileType("Starstone")] = true;
		Main.tileMerge[Type][mod.TileType("StarstoneBrick")] = true;
		Main.tileMerge[Type][mod.TileType("Starwood")] = true;
        drop = mod.ItemType("Starsoil");
		dustType = mod.DustType("Stardust");
		SetModTree(new StarwoodTree());
    }
	public override void RandomUpdate(int i, int j)
	{
		if(Framing.GetTileSafely(i,j-1).type==0&&Framing.GetTileSafely(i,j-2).type==0)
		{
			if(Main.rand.Next(2)==0)
			{
				if(Framing.GetTileSafely(i-1,j-1).type==0&&Framing.GetTileSafely(i-1,j-2).type==0&&Framing.GetTileSafely(i+1,j-1).type==0&&Framing.GetTileSafely(i+1,j-2).type==0)
				{
					if(Main.rand.Next(5)==0)
					{
						WorldGen.PlaceObject(i-1,j-1,mod.TileType("StarPlants"));
						NetMessage.SendObjectPlacment(-1,i-1,j-1,mod.TileType("StarPlants"),0,0,-1,-1);
					}
					else
					{
						WorldGen.PlaceObject(i,j-1,mod.TileType("StarPlantsSapling"));
						NetMessage.SendObjectPlacment(-1,i,j-1,mod.TileType("StarPlants"),0,0,-1,-1);
					}
				}
				else if(Main.rand.Next(9)==0)
				{
					WorldGen.PlaceObject(i,j-1,mod.TileType("StarPlantsSapling"));
					NetMessage.SendObjectPlacment(-1,i,j-1,mod.TileType("StarPlants"),0,0,-1,-1);
				}
			}
		}
	}
	public override int SaplingGrowthType(ref int style)
	{
		style = 0;
		return mod.TileType("StarwoodSapling");
	}
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}