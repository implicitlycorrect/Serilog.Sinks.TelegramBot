using Serilog.Configuration;

namespace Serilog.Sinks.TelegramBot;

public static class Extensions
{
    public static LoggerConfiguration TelegramChat(this LoggerSinkConfiguration sinkConfiguration, string botToken,
        long chatId)
    {
        return sinkConfiguration.Sink(new TelegramChatSink(botToken, chatId));
    }
}