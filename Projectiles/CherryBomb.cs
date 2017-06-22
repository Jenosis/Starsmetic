using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Projectiles
{
    public class CherryBomb : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Bomb);
            aiType = ProjectileID.Bomb;
            projectile.timeLeft = 200;
        }

        public override bool PreKill(int timeLeft)
        {
            projectile.type = ProjectileID.Bomb;
            return true;
        }
    } 
}
