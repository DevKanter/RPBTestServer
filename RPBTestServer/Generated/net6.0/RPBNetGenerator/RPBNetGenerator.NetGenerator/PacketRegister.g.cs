  
using RPBNet.NetworkBase.Server;
using RPBCommon.Packet.Packets.Character;
using RPBCommon.Packet.Packets.Connection;
using S2CHello = SMG1Common.Packets.Connection.S2CHello;

namespace RPBTestServer.Packets
{
internal static class PacketRegister
        {
            internal static void Initialize()
            {
                PacketParser.AddPacketFactory<C2SCharacterCreate>();
PacketParser.AddPacketFactory<S2CHello>();

            }
        }
}