using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace CosmeticVariety.Tiles
{
	public class StarwoodTree : ModTree
	{
		private Mod mod
		{
			get
			{
				return ModLoader.GetMod("CosmeticVariety");
			}
		}

		public override int CreateDust()
		{
			return mod.DustType("Stardust");
		}

		public override int GrowthFXGore()
		{
			return mod.GetGoreSlot("Gores/StarwoodTreeFX");
		}

		public override int DropWood()
		{
			return mod.ItemType("Starwood");
		}

		public override Texture2D GetTexture()
		{
			return mod.GetTexture("Tiles/StarwoodTree");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset)
		{
			return mod.GetTexture("Tiles/StarwoodTree_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame)
		{
			return mod.GetTexture("Tiles/StarwoodTree_Branches");
		}
	}
}