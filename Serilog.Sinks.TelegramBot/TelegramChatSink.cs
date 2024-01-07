using Serilog.Core;
using Serilog.Events;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Serilog.Sinks.TelegramBot;

public sealed class TelegramChatSink(string botToken, ChatId chatId) : ILogEventSink
{
    private readonly TelegramBotClient _botClient = new(botToken);

    public void Emit(LogEvent logEvent)
    {
        _botClient.SendTextMessageAsync(chatId, logEvent.RenderMessage()).Wait();
    }
}