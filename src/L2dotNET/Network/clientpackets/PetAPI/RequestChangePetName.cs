﻿using L2dotNET.model.player;

namespace L2dotNET.Network.clientpackets.PetAPI
{
    class RequestChangePetName : PacketBase
    {
        private readonly GameClient _client;
        private readonly string _name;

        public RequestChangePetName(Packet packet, GameClient client)
        {
            _client = client;
            _name = packet.ReadString();
        }

        public override void RunImpl()
        {
            L2Player player = _client.CurrentPlayer;
        }
    }
}