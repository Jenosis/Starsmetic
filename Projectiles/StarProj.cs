using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Projectiles
{
    public class StarProj : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.FallingStar);
            projectile.friendly = true;
            aiType = ProjectileID.FallingStar;
            projectile.aiStyle = 9;
            projectile.light = 1.5f;
            projectile.magic = true;
        }
    }
}
