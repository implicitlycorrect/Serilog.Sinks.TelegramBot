using Serilog.Core;
using Serilog.Events;
using Serilog.Formatting;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Serilog.Sinks.TelegramBot;

public sealed class TelegramChatSink(string botToken, ChatId chatId, ITextFormatter? textFormatter = null) : ILogEventSink
{
    private readonly TelegramBotClient _botClient = new(botToken);

    public void Emit(LogEvent logEvent)
    {
        using var writer = new StringWriter();
        if (textFormatter is not null)
            textFormatter.Format(logEvent, writer);
        else
            writer.WriteLine(logEvent.RenderMessage());

        var logMessage = writer.ToString();
        _botClient.SendTextMessageAsync(chatId, logMessage).Wait();
    }
}