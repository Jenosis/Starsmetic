using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Projectiles
{
	public class JProjectile : ModProjectile
	{
        public override bool CloneNewInstances { get { return true; } }
   
        public bool psychic = true;
		public bool psychicDamage = false;
	}
}