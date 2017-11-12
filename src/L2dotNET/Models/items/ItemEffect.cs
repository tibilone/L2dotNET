﻿using log4net;
using L2dotNET.model.player;
using L2dotNET.Network.serverpackets;
using L2dotNET.world;

namespace L2dotNET.model.items
{
    public class ItemEffect
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(ItemEffect));
        public int[] Ids;

        public void Use(L2Character character, L2Item item)
        {
            if (character is L2Player)
                UsePlayer((L2Player)character, item);
            else
            {
               
                    Log.Warn($"Unk object {character.Name} tried to use {item.Template.ItemId}");
            }
        }

        public virtual void UsePlayer(L2Player player, L2Item item)
        {
            player.SendMessage("You cannot use this item.");
        }
        
    }
}