using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace CosmeticVariety.Items
{

	public abstract class JItem : ModItem
	{
        public override bool CloneNewInstances { get { return true; } }
   
        public bool psychic = true;
	
		public override void ModifyTooltips(List<TooltipLine> list)
        {
			if (psychic)
			{
				int index = -1;
				for (int m = 0; m < list.Count; m++) //find the index of the damage tooltip (probably 0 but good idea to check!)
				{
					if (list[m].Name.Equals("Damage")) { index = m; break; } //index found, break loop
				}
				//time to pull some magic
				string oldTooltip = list[index].text;
				//--> add a print here to see the old tooltip for funsies? <--
				string[] split = oldTooltip.Split(' '); //split the tooltip in two, split[0] is the numerical damage and split[1] should just be 'damage'
				list.RemoveAt(index); //gets rid of the old tooltip...
				list.Insert(index, new TooltipLine(mod, "Damage", split[0] + " psychic damage")); //...and adds yours!
			}
        }
	}
	/*
	public class JInfo : ItemInfo
	{
		public int willNeededMax = 0;
		public int willNeeded = 0;
		public bool psychic = false;
	}
	*/
}
