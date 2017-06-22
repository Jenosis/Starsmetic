using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Projectiles
{
    public class BubbleYoyo : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.WoodYoyo);
            projectile.extraUpdates = 1;
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 4;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
            aiType = ProjectileID.WoodYoyo;
        }

        public override void AI()
        {
            projectile.frameCounter++;
            if (projectile.frameCounter >= 20)
            {
                projectile.frameCounter = 0;
                float rotation = (float)(Main.rand.Next(0, 361) * (Math.PI / 180));
                Vector2 velocity = new Vector2((float)Math.Cos(rotation), (float)Math.Sin(rotation));
                int proj = Terraria.Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, velocity.X, velocity.Y, mod.ProjectileType("BubbleProj"), projectile.damage, projectile.owner, 0, 0f);
                Main.projectile[proj].friendly = true;
                Main.projectile[proj].hostile = false;
                Main.projectile[proj].velocity *= 7f;
            }
        }
    }
}