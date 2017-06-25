using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;

namespace CosmeticVariety.Tiles {
public class SolarBathtub : ModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style4x2);
		TileObjectData.newTile.Direction = TileObjectDirection.PlaceLeft;
        TileObjectData.newTile.StyleWrapLimit = 2;
        TileObjectData.newTile.StyleMultiplier = 2;
        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
        TileObjectData.newAlternate.Direction = TileObjectDirection.PlaceRight;
        TileObjectData.addAlternate(1);
        TileObjectData.newSubTile.CopyFrom(TileObjectData.newTile);
        TileObjectData.newSubTile.LinkedAlternates = true;
        TileObjectData.newSubTile.LavaDeath = false;
        TileObjectData.newSubTile.LavaPlacement = LiquidPlacement.Allowed;
        TileObjectData.addSubTile(Type);
		TileObjectData.addTile(Type);
		dustType = mod.DustType("Pixel");
        adjTiles = new int[]{TileID.Bathtubs};
    }

    public override void NumDust(int i, int j, bool fail, ref int num)
    {
        num = fail ? 1 : 3;
    }
    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(i * 16, j * 16, 64, 32, mod.ItemType("SolarBathtub"));
    }
}}