using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Auto_Reuse
{
	public class Auto_Reuse : GlobalItem
    {
        public override bool? CanAutoReuseItem(Item item, Player player)
        {
            if (item.damage > 0)
            {
                return true;
            }
            return base.CanAutoReuseItem(item, player);
        }
    }
}