using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Projectiles
{
    public class RosethornHead : ModProjectile
    {
        public override void SetDefaults()
        { 
            projectile.width = 28;
            projectile.height = 28;
            projectile.aiStyle = -1;
	        projectile.timeLeft = 600;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.alpha = 255;
            projectile.ignoreWater = true;
            projectile.magic = true;

        }
    }
}
