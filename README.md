# Serilog.Sinks.TelegramBot
Serilog.Sinks.TelegramBot is a .NET (C#) project that offers a simple implementation of a Serilog sink for logging messages to a Telegram channel.
This sink is designed to facilitate the integration of Serilog logging capabilities into applications that rely on Telegram for efficient message logging.

## Example Usage
```csharp
using Serilog;
using Serilog.Sinks.TelegramBot;

Log.Logger = new LoggerConfiguration()
    .WriteTo.TelegramChat(botToken: "token", chatId: 0)
    .CreateLogger();
```
