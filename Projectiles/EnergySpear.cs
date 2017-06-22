using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Projectiles
{
    public class EnergySpear : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.BoneJavelin);
            aiType = ProjectileID.Daybreak;
            projectile.melee = true;
            projectile.aiStyle = 113;
            projectile.friendly = true;
            projectile.hide = false;
        }       
    }
}
