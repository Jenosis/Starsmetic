using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace CosmeticVariety.Tiles {
public class FertileSoil : ModTile
{
    public override void SetDefaults()
    {
        Main.tileSolid[Type] = true;
		Main.tileMerge[Type][mod.TileType("FlowerStemBlock")] = true;
		Main.tileMerge[Type][mod.TileType("PetalBlock")] = true;
		Main.tileMerge[Type][mod.TileType("Floralwood")] = true;
		Main.tileMergeDirt[this.Type] = false;
		Main.tileBlendAll[this.Type] = true;
        drop = mod.ItemType("FertileSoil");
        AddMapEntry(new Color(100, 200, 200));
		dustType = mod.DustType("Stardust");
    	SetModTree(new FloralTree());
    }
	public override void RandomUpdate(int i, int j)
	{
		if(Framing.GetTileSafely(i,j-1).type==0&&Framing.GetTileSafely(i,j-2).type==0)
		{
			if(Main.rand.Next(2)==0)
			{
				if(Framing.GetTileSafely(i-1,j-1).type==0&&Framing.GetTileSafely(i-1,j-2).type==0&&Framing.GetTileSafely(i+1,j-1).type==0&&Framing.GetTileSafely(i+1,j-2).type==0)
				{
					if(Main.rand.Next(25)==0)
					{
						WorldGen.PlaceObject(i-1,j-1,mod.TileType("FloralSapling"));
						NetMessage.SendObjectPlacment(-1,i-1,j-1,mod.TileType("FloralSapling"),0,0,-1,-1);
					}
					else
					{
						WorldGen.PlaceObject(i,j-1,mod.TileType("FloraGrass"), false, Main.rand.Next(18));
						NetMessage.SendObjectPlacment(-1,i,j-1,mod.TileType("FloraGrass"),Main.rand.Next(18),0,-1,-1);
					}
				}
				else if(Main.rand.Next(6)==0)
				{
					WorldGen.PlaceObject(i,j-1,mod.TileType("FloraGrass"), false, Main.rand.Next(18));
					NetMessage.SendObjectPlacment(-1,i,j-1,mod.TileType("FloraGrass"),Main.rand.Next(18),0,-1,-1);
				}
			}
		}
	}
	public override int SaplingGrowthType(ref int style)
	{
		style = 0;
		return mod.TileType("FloralSapling");
	}
    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
}}