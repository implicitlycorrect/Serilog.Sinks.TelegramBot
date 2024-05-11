using Serilog.Configuration;
using Serilog.Formatting;

namespace Serilog.Sinks.TelegramBot;

public static class Extensions
{
    public static LoggerConfiguration TelegramChat(this LoggerSinkConfiguration sinkConfiguration, string botToken,
        long chatId, ITextFormatter? textFormatter = null)
    {
        return sinkConfiguration.Sink(new TelegramChatSink(botToken, chatId, textFormatter));
    }
}