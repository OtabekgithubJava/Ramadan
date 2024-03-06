using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using File = System.IO.File;

public class BotHandler
{
    private const int NumberOfInlineButtons = 30;
    private int buttonCounter = 1;

    public string Token { get; set; }
    public object currentTime = DateTime.Now.ToString("HH:mm");

    public BotHandler(string token)
    { 
        Token = token;
    }

    public async Task BotHandle()
    {
        var botClient = new TelegramBotClient(Token);

        using CancellationTokenSource cts = new CancellationTokenSource();

        ReceiverOptions receiverOptions = new ReceiverOptions
        {
            AllowedUpdates = Array.Empty<UpdateType>()
        };

        botClient.StartReceiving(
            updateHandler: HandleUpdateAsync,
            pollingErrorHandler: HandlePollingErrorAsync,
            receiverOptions: receiverOptions,
            cancellationToken: cts.Token
        );

        var me = await botClient.GetMeAsync();

        Console.WriteLine($"Start listening for @{me.Username}");
        Console.ReadLine();

        cts.Cancel();
    }

    async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        var messageText = "";
        if (update.Message?.Text is not null)
            messageText = update.Message.Text;

        var chatId = update.Message?.Chat.Id ?? update.CallbackQuery?.Message?.Chat.Id ?? 0;

        if (update.CallbackQuery != null)
        {
            var callbackData = update.CallbackQuery.Data;

            if (int.TryParse(callbackData?.Split('_').Last(), out int buttonNumber))
            {
                switch (buttonNumber)
                {
                    case 1:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 1chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi 😊",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 2:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 2chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 3:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 3chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi 😊",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 4:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 4chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 5:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 5chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 6:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 6chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 7:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 7chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 8:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 8chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 9:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 9chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 10:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 10chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 11:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 11chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 12:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 12chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 13:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 13chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 14:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 14chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 15:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 15chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 16:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 16chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 17:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 17chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 18:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 18chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 19:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 19chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 20:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 20chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 21:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 21chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 22:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 22chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 23:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 23chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 24:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 24chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 25:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 25chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 26:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 26chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 27:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 27chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 28:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 28chi kuni uchun og'iz ochish va yopish vaqtlari* 👇👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 29:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 29chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    case 30:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "👇*Ramazon oyining 30chi kuni uchun og'iz ochish va yopish vaqtlari* 👇\n\n\n😄 Hali aniq emas, 4 yoki 5 kunda aniq bo'ladi va bot sizga aniq vaqtlarni ko'rsatadi",
                            parseMode: ParseMode.MarkdownV2,
                            cancellationToken: cancellationToken
                        );
                        break;
                    default:
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "Noto'g'ri tugma!",
                            cancellationToken: cancellationToken
                        );
                        break;
                }
            }
        }
        else
        {
            if (update.Message?.Type == MessageType.Text)
            {
                var user = update.Message?.Chat.FirstName;
                var chatBio = update.Message?.Chat?.Username;

                string user_message = $"Message: '{messageText}' | chat: {chatId} Bio: {chatBio} from {user} at {currentTime}\n";
                string filepath = "/Users/otabek_coding/Desktop/Najot Ta'lim/C# codes/Rider/Ramadan/users.txt";
                File.AppendAllText(filepath, user_message);

                if (messageText == "/start" || messageText.ToLower().Equals("start"))
                {
                    await SendStartMessageAsync(chatId, botClient, cancellationToken);
                }
                else if (messageText.ToLower().Equals("bugungi taqvimni ko'rish") || messageText.ToLower().Equals("/taqvim") || messageText.ToLower().Equals("taqvim"))
                {
                    await SendInlineButtonsAsync(chatId, botClient, cancellationToken);
                }
                else if (messageText.ToLower().Equals("o'qiladigan duo") || messageText.ToLower().Equals("/duo") || messageText.ToLower().Equals("taqvim"))
                {
                    await SendPrayingTimeTable(chatId, botClient, cancellationToken);
                }
                else
                {
                    await SendStartMessageAsync(chatId, botClient, cancellationToken);
                }
            }
            else
            {
                Console.WriteLine($"Ignoring non-text message in chat {chatId}");
            }
        }
    }

    private async Task SendStartMessageAsync(long chatId, ITelegramBotClient botClient, CancellationToken cancellationToken)
    {
        ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
        {
            new KeyboardButton[] { new KeyboardButton("Bugungi Taqvimni Ko'rish"), new KeyboardButton("O'qiladigan Duo") }
        })
        {
            ResizeKeyboard = true
        };

        await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "👋 *Assalomu Aleykum*\n\n  🕌 Botimiz orqali Muborak Ramazon oyining taqvimini kunlik jadvalini va o'qiladigan duosini topishingiz mumkin\n\n❗*Pastdagi tugmachalardan foydalaning* 👇",
            parseMode: ParseMode.MarkdownV2,
            replyMarkup: replyKeyboardMarkup,
            cancellationToken: cancellationToken);
    }
    
    private async Task SendPrayingTimeTable(long chatId, ITelegramBotClient botClient, CancellationToken cancellationToken)
    {
        await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "🤲 *O'qiladigan Duo* 👇\n\n *Allohumma laka sumtu va bika aamantu va a'layka tavakkaltu va a'laa rizqika aftartu, fag'firliy ma qoddamtu va maa axxortu birohmatika yaa arhamar roohimiyn*\n\nMa'nosi: Ey Alloh, ushbu Ro'zamni Sen uchun tutdim va Senga iymon keltirdim va Senga tavakkal qildim va bergan rizqing bilan iftor qildim\nEy mehribonlarning eng mehriboni, mening avvalgi va keyingi gunohlarimni mag'firat qilgil\n\n\n*Bizni ham duo qilish esdan chiqmasin* 🙂",
            parseMode: ParseMode.MarkdownV2,
            cancellationToken: cancellationToken
        );
    }

    private async Task SendInlineButtonsAsync(long chatId, ITelegramBotClient botClient, CancellationToken cancellationToken)
    {
        InlineKeyboardMarkup inlineKeyboard = GenerateInlineButtons();
        
        await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "Sanani tanlang",
            replyMarkup: inlineKeyboard,
            cancellationToken: cancellationToken
        );
    }

    private InlineKeyboardMarkup GenerateInlineButtons()
    {
        var rows = new List<List<InlineKeyboardButton>>();

        int buttonsPerRow = 6;
        int buttonsPerColumn = 5;

        for (int i = 0; i < buttonsPerColumn; i++)
        {
            var row = new List<InlineKeyboardButton>();

            for (int j = 1; j <= buttonsPerRow; j++)
            {
                int buttonNumber = j + i * buttonsPerRow;
                if (buttonNumber <= NumberOfInlineButtons)
                {
                    var buttonText = $"{buttonNumber}-kun";
                    var button = InlineKeyboardButton.WithCallbackData(buttonText, $"button_{buttonNumber}");
                    row.Add(button);
                }
            }

            rows.Add(row);
        }

        return new InlineKeyboardMarkup(rows);
    }
    
    public Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
     {
         var errorMessage = exception switch
         {
             ApiRequestException apiRequestException
                 => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
             _ => exception.ToString()
         };

         Console.WriteLine(errorMessage);
         return Task.CompletedTask;
     }
}
