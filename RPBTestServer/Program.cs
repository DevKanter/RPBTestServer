using RPBPacketBase;
using RPBUtilities;
using SMG1Server.Logging;
using SMG1Server.Network;

namespace SMG1Server;

internal class Program
{
    private static void Main(string[] args)
    {
        _initialize();
        _startServer();
        _startReadCallback();
    }

    private static void _initialize()
    {
        RPBNet.Network.Initialize();
        Log.Initialize();
    }

    private static void _startServer()
    {
        var server = new MainServer(44405);
    }

    private static void _startReadCallback()
    {
        while (true) Console.ReadLine();
    }

}