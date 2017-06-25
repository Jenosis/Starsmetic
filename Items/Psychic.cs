/*using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmeticVariety.Items
{
    public class Psychic: GlobalItem
    {
		public override void ModifyTooltips(Item item, List<TooltipLine> list)
		{
			if(item.GetModInfo<JInfo>(mod).psychic)
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
		public override bool CanUseItem(Item item, Player player)
		{
		  if(item.GetModInfo<JInfo>(mod).psychic)
		  {
			 if(item.GetModInfo<JInfo>(mod).willNeeded >= player.GetModPlayer<CosmeticPlayer>(mod).willPower && item.GetModInfo<JInfo>(mod).willNeededMax >= player.GetModPlayer<CosmeticPlayer>(mod).willPowerMax)
			 {
				return true;
				Main.NewText("hi am working", 50, 90, 230);
			 }
			 else return false;
		  }
		  return base.CanUseItem(item, player);
		}
		public override bool UseItem(Item item, Player player)
        {
            if(item.GetModInfo<JInfo>(mod).psychic)
            {
                player.GetModPlayer<CosmeticPlayer>(mod).willPower -= item.GetModInfo<JInfo>(mod).willNeeded;
            }
            return base.UseItem(item, player);
        }
	}
}
*/