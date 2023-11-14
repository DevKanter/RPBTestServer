using RPBUtilities.Logging;
using RPBUtilities.Logging.Loggers;

namespace SMG1Server.Logging;

internal static class Log
{
    public static void Initialize()
    {
        Logger<LogType>.Initialize(new()
        {
            {LogType.CONSOLE, new ConsoleLogger(LogLevel.FULL)}
        });
    }

    public static void Write(LogType type, string message, LogLevel level)
    {
        Logger<LogType>.Log(message, level, type);
    }
}