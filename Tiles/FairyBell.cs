using System;

using Microsoft.Xna.Framework;

using Terraria;
using Terraria.ID;
using Terraria.Enums;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace CosmeticVariety.Tiles
{
    public class FairyBell : ModTile
    {
        private int timeUntillNextChime;

        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.AnchorBottom = default(AnchorData);
            TileObjectData.addTile(Type);
			drop = mod.ItemType("DecorativeFairyBell");
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTorch);
		}

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (closer)
            {
                if (Math.Abs(Main.windSpeed * 100f) >= 6 && timeUntillNextChime == 0)
                {
                    Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/Chime"));

                    timeUntillNextChime = 30; // Apparantly your current sound lasts half a second. You'll want to change this accordingly to your audio file length.
                }
            }

            if (timeUntillNextChime > 0) timeUntillNextChime--; // Create a timer for the sound to replay.
        }
    }
}