using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety
{
	public class MNetSync
	{	
        public static ModPacket WriteToPacket(ModPacket packet, byte msg, params object[] param)
        {
            packet.Write((byte)msg);
            for (int m = 0; m < param.Length; m++)
            {
                object obj = param[m];

                if (obj is bool) packet.Write((bool)obj); else
                if (obj is byte) packet.Write((byte)obj); else
                if (obj is short) packet.Write((short)obj); else
                if (obj is int) packet.Write((int)obj); else
                if (obj is float) packet.Write((float)obj);
            }
            return packet;
        }			
		
		public static void SendNetMessage(Mod mod, int msg, params object[] param)
		{
			if (Main.netMode == 0) { return; }
            WriteToPacket(mod.GetPacket(), (byte)msg, param).Send();
		}

        public static void HandlePacket(BinaryReader bb, int whoAmI, Mod mod)
        {
			byte msg = bb.ReadByte();						
			try
			{
            if (msg == SpawnOreZillium) //spawn zillium ore
			{
				if(Main.netMode == 2)
				{
					Items.JokerCard.SpawnOre(mod);
				}
			}else
            if (msg == SpawnOreCelestial) //spawn celestial stuff
			{
				if(Main.netMode == 2)
				{
					Items.CelestialBlossom.SpawnOre(mod);
				}				
			}
			}catch(Exception e){ ErrorLogger.Log((Main.netMode == 2 ? "--SERVER-- " : "--CLIENT-- " ) + "ERROR HANDLING MSG: " + msg.ToString() + ": " + e.Message); ErrorLogger.Log(e.StackTrace); ErrorLogger.Log("-------"); }
		}

		public const byte SpawnOreZillium = 0;
		public const byte SpawnOreCelestial = 1;
	}
}