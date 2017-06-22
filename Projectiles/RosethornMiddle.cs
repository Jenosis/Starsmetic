using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Projectiles
{
    public class RosethornMiddle : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 28;
            projectile.height = 28;
            projectile.aiStyle = 4;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.alpha = 255;
            projectile.ignoreWater = true;
            projectile.magic = true;

        }
        public static void AIVilethorn(Projectile p, int alphaInterval = 50, int alphaReduction = 4, int length = 8)
        {
            if (p.ai[0] == 0f)
            {
                p.rotation = (float)System.Math.Atan2((double)p.velocity.Y, (double)p.velocity.X) + 1.57f;
                p.alpha -= alphaInterval;
                if (p.alpha <= 0)
                {
                    p.alpha = 0;
                    p.ai[0] = 1f;
                    if (p.ai[1] == 0f) { p.ai[1] += 1f; p.position += p.velocity; }
                    if (p.ai[1] < length && Main.myPlayer == p.owner)
                    {
                        Vector2 rotVec = p.velocity;
                        int id = Projectile.NewProjectile(p.Center.X + p.velocity.X, p.Center.Y + p.velocity.Y, rotVec.X, rotVec.Y, p.type, p.damage, p.knockBack, p.owner);
                        Main.projectile[id].damage = p.damage;
                        Main.projectile[id].ai[1] = p.ai[1] + 1f;
                        p.position -= p.velocity;
                        return;
                    }
                }
            }
            else
            {
                p.alpha += alphaReduction;
                if (p.alpha >= 255) { p.Kill(); return; }
            }
            p.position -= p.velocity;
        }
    }
}
