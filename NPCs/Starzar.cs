using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.NPCs
{
	public class Starzar : ModNPC
	{
		public override void SetDefaults()
		{
			npc.width = 90;
			npc.height = 88;
			npc.aiStyle = -1;
			npc.damage = 80;
			npc.defense = 18;
			npc.lifeMax = 200;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.buffImmune[20] = true;
			npc.buffImmune[24] = true;
			npc.buffImmune[39] = true;
			npc.knockBackResist = 0.4f;
			npc.noGravity = true;
			npc.noTileCollide = true;
			Main.npcFrameCount[npc.type] = 1;
			banner = npc.type;
			bannerItem = mod.ItemType("StarzarBanner");
		}
	
		public static float starDist = 300f; //change this to change how far from the 'center' Starzar rotates.
		public static Vector2[] starPos = new Vector2[]{ new Vector2(-starDist, 0f), new Vector2(starDist, 0f), new Vector2(-starDist * 0.5f, starDist), new Vector2(0f, -starDist), new Vector2(starDist * 0.5f, starDist) };
		public Vector2[] starPath = null;
		public bool lastState = true;

		public override void AI()
		{
				npc.TargetClosest(true);
				Player target = Main.player[npc.target];
				if(Vector2.Distance(target.Center, npc.Center) <= starDist + 60f) //try for a star attack!
				{
					npc.damage = 40;
					npc.defense = 0;
					npc.knockBackResist = 0f;
					if(starPath == null)
					{
						starPath = new Vector2[starPos.Length];
						for(int m = 0; m < starPath.Length; m++)
						{
							starPath[m] = target.Center + starPos[m];					
						}					
						npc.netUpdate2 = true;
					}
					if(!lastState)
					{
						npc.ai = new float[4]; if(Main.netMode != 1) npc.netUpdate2 = true; 
					}
					lastState = true;					
					AIPath(npc, ref npc.ai, starPath, 10f, 10f, true);	
					npc.rotation += 0.15f;
					if(npc.ai[2] == starPath.Length){ npc.ai[2] = 0f; starPath = null; npc.netUpdate2 = true; }
				}else
				{
					npc.damage = 80;
					npc.defense = 18;
					npc.knockBackResist = 0.4f;					
					starPath = null;				
					if(lastState){ int cooldown = (int)npc.ai[3]; npc.ai = new float[4]; npc.ai[3] = cooldown; if(Main.netMode != 1) npc.netUpdate2 = true; }				
					lastState = false;
					AIWeapon(npc, ref npc.ai, ref npc.rotation, target.Center, npc.justHit, 120, 100, 8f, 1f, 1f);
				}
		}
		
		public override void FindFrame(int frameHeight)
		{
			npc.spriteDirection = npc.direction;
		}

		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, 13);
                Gore.NewGore(npc.position, npc.velocity, 12);
                Gore.NewGore(npc.position, npc.velocity, 11);
            }
        }
		
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return spawnInfo.player.GetModPlayer<CosmeticPlayer>(mod).ZoneStar && Main.hardMode ? 0.8f : 0f;
		}
		
		public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,mod.ItemType("Starstone"), Main.rand.Next(1,6));
			}
			if (Main.rand.Next(20) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,(ItemID.Nazar));
			}
			if (Main.rand.Next(2) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,mod.ItemType("StarliteFragments"), Main.rand.Next(1,2));
			}
		}

		public override bool PreDraw(SpriteBatch spriteBatch, Color drawColor)
        {
            // Sets the positions for the trailing.
            for (int index = 5; index > 0; --index)
            {
                npc.oldPos[index] = npc.oldPos[index - 1];
                npc.oldRot[index] = npc.oldRot[index - 1];
            }
            npc.oldPos[0] = npc.position;
            npc.oldRot[0] = npc.rotation;

            Texture2D texture = Main.npcTexture[npc.type];
            Vector2 origin = new Vector2(texture.Width * 0.5f, texture.Height * 0.5f);

            for (int i = 1; i < npc.oldPos.Length; ++i)
            {
                Vector2 vector2_2 = npc.oldPos[i];
                Microsoft.Xna.Framework.Color color2 = Color.White * npc.Opacity;
                color2.R = (byte)(0.5 * (double)color2.R * (double)(10 - i) / 20.0);
                color2.G = (byte)(0.5 * (double)color2.G * (double)(10 - i) / 20.0);
                color2.B = (byte)(0.5 * (double)color2.B * (double)(10 - i) / 20.0);
                color2.A = (byte)(0.5 * (double)color2.A * (double)(10 - i) / 20.0);
                Main.spriteBatch.Draw(Main.npcTexture[npc.type], new Vector2(npc.oldPos[i].X - Main.screenPosition.X + (npc.width / 2),
                    npc.oldPos[i].Y - Main.screenPosition.Y + npc.height / 2), new Rectangle?(npc.frame), color2, npc.oldRot[i], origin, npc.scale, SpriteEffects.None, 0.0f);
            }

            spriteBatch.Draw(texture, npc.Center - Main.screenPosition, new Rectangle?(npc.frame), Color.White * npc.Opacity, npc.rotation, origin, npc.scale, SpriteEffects.None, 0);
            return false;
        }
		
		#region basemod snippets
        public static float RotationTo(Vector2 startPos, Vector2 endPos)
        {
            return (float)Math.Atan2(endPos.Y - startPos.Y, endPos.X - startPos.X);
        }
		
        public static Vector2 RotateVector(Vector2 origin, Vector2 vecToRot, float rot)
        {
            float newPosX = (float)(Math.Cos(rot) * (vecToRot.X - origin.X) - Math.Sin(rot) * (vecToRot.Y - origin.Y) + origin.X);
            float newPosY = (float)(Math.Sin(rot) * (vecToRot.X - origin.X) + Math.Cos(rot) * (vecToRot.Y - origin.Y) + origin.Y);
            return new Vector2(newPosX, newPosY);
        }		
		
		public static Vector2 AIVelocityLinear(Entity codable, Vector2 destVec, float moveInterval, float maxSpeed, bool direct = false)
        {
            Vector2 returnVelocity = codable.velocity;
            bool tileCollide = (codable is NPC ? !(((NPC)codable).noTileCollide) : codable is Projectile ? ((Projectile)codable).tileCollide : false);
            if (direct)
            {
                Vector2 rotVec = RotateVector(codable.Center, codable.Center + new Vector2(maxSpeed, 0f), RotationTo(codable.Center, destVec));
                returnVelocity = rotVec - codable.Center;
            }else
            {
                if (codable.Center.X > destVec.X) { returnVelocity.X = Math.Max(-maxSpeed, returnVelocity.X - moveInterval); } else if (codable.Center.X < destVec.X) { returnVelocity.X = Math.Min(maxSpeed, returnVelocity.X + moveInterval); }
                if (codable.Center.Y > destVec.Y) { returnVelocity.Y = Math.Max(-maxSpeed, returnVelocity.Y - moveInterval); } else if (codable.Center.Y < destVec.Y) { returnVelocity.Y = Math.Min(maxSpeed, returnVelocity.Y + moveInterval); }
            }
            if (tileCollide)
            {
                returnVelocity = Collision.TileCollision(codable.position, returnVelocity, codable.width, codable.height);
            }
            return returnVelocity;
        }	
		
        public static void AIPath(NPC npc, ref float[] ai, Vector2[] points, float moveInterval = 0.11f, float maxSpeed = 3f, bool direct = false)
        {
            Vector2 destVec = new Vector2(ai[0], ai[1]);
            if (Main.netMode != 1 && destVec != default(Vector2) && Vector2.Distance(npc.Center, destVec) <= Math.Max(5f, ((npc.width + npc.height) / 2f) * 0.45f))
            {
                ai[0] = 0f; ai[1] = 0f; destVec = default(Vector2);
            }
            if (npc.ai[2] < points.Length)
            {
                //if the destination vec is default (0, 0), get the current point.
                if (destVec == default(Vector2))
                {
                    npc.velocity *= 0.95f;
                    if(Main.netMode != 1)
                    {
                        destVec = points[(int)npc.ai[2]];
                        ai[0] = destVec.X; ai[1] = destVec.Y;
                        ai[2]++;
                        npc.netUpdate = true;
                    }
                }else //otherwise move to the point.
                {
                    npc.velocity = AIVelocityLinear(npc, destVec, moveInterval, maxSpeed, direct);
                }
            }
        }		
		
		public static void AIWeapon(Entity codable, ref float[] ai, ref float rotation, Vector2 targetPos, bool justHit = false, int rotTime = 120, int moveTime = 100, float maxSpeed = 6f, float movementScalar = 1f, float rotScalar = 1f)
		{
			if (ai[0] == 0f)
			{
				Vector2 vector2 = codable.Center;
				float distX = targetPos.X - vector2.X;
				float distY = targetPos.Y - vector2.Y;
				float dist = (float)Math.Sqrt(distX * distX + distY * distY);
				float distMult = 9f / dist;
				codable.velocity.X = distX * distMult * movementScalar;
				codable.velocity.Y = distY * distMult * movementScalar;
				if (codable.velocity.X > maxSpeed) { codable.velocity.X = maxSpeed; } if (codable.velocity.X < -maxSpeed) { codable.velocity.X = -maxSpeed; }
				if (codable.velocity.Y > maxSpeed) { codable.velocity.Y = maxSpeed; } if (codable.velocity.Y < -maxSpeed) { codable.velocity.Y = -maxSpeed; }
				rotation = (float)Math.Atan2(codable.velocity.Y, codable.velocity.X);
				ai[0] = 1f;
				ai[1] = 0.0f;
			}else if (ai[0] == 1f)
			{
				if (justHit)
				{
					ai[0] = 2f;
					ai[1] = 0.0f;
				}
				codable.velocity *= 0.99f;
				++ai[1];
				if (ai[1] < moveTime) return;
				ai[0] = 2f;
				ai[1] = 0.0f;
				codable.velocity.X = 0.0f;
				codable.velocity.Y = 0.0f;
			}else
			{
				if (justHit)
				{
					ai[0] = 2f;
					ai[1] = 0.0f;
				}
				codable.velocity *= 0.96f;
				++ai[1];
				rotation += ((float)(0.1 + (double)(ai[1] / (float)rotTime) * 0.4f) * (float)codable.direction) * rotScalar;
				if (ai[1] < rotTime) return;
				if (codable is NPC) { ((NPC)codable).netUpdate = true; } else if (codable is Projectile) { ((Projectile)codable).netUpdate = true; }
				ai[0] = 0.0f;
				ai[1] = 0.0f;
			}
		}
		#endregion
	}
}