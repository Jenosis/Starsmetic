using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace CosmeticVariety.Tiles
{
	public class FloralTree : ModTree
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
			return mod.DustType("Vortex");
		}

		public override int GrowthFXGore()
		{
			return mod.GetGoreSlot("Gores/FloralTreeFX");
		}

		public override int DropWood()
		{
			return mod.ItemType("Floralwood");
		}

		public override Texture2D GetTexture()
		{
			return mod.GetTexture("Tiles/FloralTree");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset)
		{
			return mod.GetTexture("Tiles/FloralTree_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame)
		{
			return mod.GetTexture("Tiles/FloralTree_Branches");
		}
	}
}