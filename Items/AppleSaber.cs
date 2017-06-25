using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
    public class AppleSaber : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.damage = 10;
            item.melee = true;
			item.useStyle = 1;
			item.UseSound = SoundID.Item1;
            item.knockBack = 8;
            item.useTime = 20;
            item.useAnimation = 20;
            item.value = 10000;
            item.rare = 1;
            item.autoReuse = false;
        }
    }
}