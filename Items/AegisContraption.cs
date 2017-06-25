using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace CosmeticVariety.Items {
public class AegisContraption : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("Used for processing Chalcum, Pallasite, Mantilum, Veridanite, and Starlight ore");
	}
    public override void SetDefaults()
    {
        item.width = 12;
        item.height = 12;
        item.maxStack = 999;
        item.useTurn = true;
        item.autoReuse = true;
        item.useAnimation = 15;
        item.useTime = 7;
        item.useStyle = 1;
        item.consumable = true;
		item.createTile = mod.TileType("AegisContraption");
    }
	/*public override bool CanUseItem(Player player)
    {
        int x = Player.tileTargetX, y = Player.tileTargetY;
        Tile targetTile = Main.tile[x, y];
        if (targetTile.type == TileID.LunarCraftingStation)
        {
            // Not sure if the following will work correctly. Should get the upper left corner of the tile.
            int left = x - (int)(Main.tile[x, y].frameX / 18);
            int top = y - (int)(Main.tile[x, y].frameY / 18) - 1;

            // Substract one more from the top, since the new tile is one chunk higher than the Ancient Manipulator.

            // First we set the tiles to the new type.
            for (int currentX = left; currentX < left + 3; ++currentX)
            {
                for (int currentY = top; currentY < top + 4; ++currentY)
                {
                    Main.tile[currentX, currentY].active(true);

                    Main.tile[currentX, currentY].type = (ushort)mod.TileType("AncientContraption");
                    Main.tile[currentX, currentY].frameX = (short)((currentX - left) * 18);
                    Main.tile[currentX, currentY].frameY = (short)((currentY - top) * 18);
                }
            }
            return true;
        }

        return true;
    }
	public override bool UseItem(Player player)
	{
		Point point = Main.MouseWorld.ToTileCoordinates();
		
		if(Main.tile[point.X,point.Y].type == 412)
		{
			item.createTile = mod.TileType("AncientContraption");
		}
		return true;
	}*/
    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.LunarBar, 15);
		recipe.AddIngredient(ItemID.FallenStar, 10);
		recipe.AddTile(412);
        recipe.SetResult(this, 1);
        recipe.AddRecipe();
    }
}}