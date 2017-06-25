using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
    public class CherryFlail : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.rare = 1;
            item.noMelee = true;
            item.useStyle = 5; 
            item.useAnimation = 34; 
            item.useTime = 34;
            item.knockBack = 7;
			item.value = 10000;
            item.damage = 11;
            item.noUseGraphic = true; 
            item.shoot = mod.ProjectileType("CherryHead");
            item.shootSpeed = 15f;
            item.UseSound = SoundID.Item1;
            item.melee = true; 
            item.channel = true; 
        }
    }
}