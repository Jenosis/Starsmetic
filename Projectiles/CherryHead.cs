using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Projectiles
{
    public class CherryHead : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 28;
            projectile.height = 12;
            projectile.friendly = true;
            projectile.penetrate = -1; 
            projectile.melee = true; 
            projectile.aiStyle = 15; 
        }


        public override bool PreAI()
        {
            ProjectileExtras.FlailAI(projectile.whoAmI);
            return true;
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            return ProjectileExtras.FlailTileCollide(projectile.whoAmI, oldVelocity);
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            ProjectileExtras.DrawChain(projectile.whoAmI, Main.player[projectile.owner].MountedCenter,"CosmeticVariety/Projectiles/CherryChain");
            ProjectileExtras.DrawAroundOrigin(projectile.whoAmI, lightColor);
            return false;
        }
    }
}