using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class Fertilizer : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Great for growing plants. Among other things.");
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 22;
			item.maxStack = 99;
			item.rare = 1;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.UseSound = SoundID.Item81;
			item.consumable = true;
		}

		public override bool CanUseItem(Player player)
		{
			return TileLoader.IsSapling(Main.tile[Player.tileTargetX, Player.tileTargetY].type);
		}

		public override bool UseItem(Player player)
		{
			if (WorldGen.GrowTree(Player.tileTargetX, Player.tileTargetY))
			{
				WorldGen.TreeGrowFXCheck(Player.tileTargetX, Player.tileTargetY);
			}
			else
			{
				item.stack++;
			}
			return true;
		}
	}
}