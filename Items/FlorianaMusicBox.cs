using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
	public class FlorianaMusicBox : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (Floriana)");
		}
		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("FlorianaMusicBox");
			item.width = 24;
			item.height = 24;
			item.rare = 4;
			item.value = 1000;
			item.accessory = true;
		}
	}
}
