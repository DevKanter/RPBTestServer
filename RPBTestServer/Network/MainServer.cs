using RPBNet.NetworkBase.Connections;
using RPBNet.NetworkBase.General;
using SMG1Common.Packets.Connection;
using SMG1Server.Logging;
using static SMG1Server.Logging.LogType;
using static RPBUtilities.Logging.LogLevel;

namespace SMG1Server.Network;

internal class MainServer : ServerBase<NetUser>
{
    public MainServer(int port) : base(port)
    {
        Log.Write(CONSOLE, "Server started!", SUCCESS);
    }

    protected override void OnEstablish(Connection<NetUser> connection)
    {
        var packet = new S2CHello
        {
            ServerMessage = "Hallo ich bin ein Server!"
        };
        connection.Send(packet);
    }
}