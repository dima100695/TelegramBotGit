using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot
{
    internal class Program
    {
       // private static string tokin = "sdsfsd51651d5fv1"; // здесь будет токин для подключния к боту
       

        

        static void Main(string[] args)
        {
            var client = new TelegramBotClient("5873080141:AAFa6_qSdOQup01liMUtvkdM70t1QvJ1XSM"); // тут пишем телеграм токин
            client.StartReceiving(Update,Error);  // тут два метода update - принимет и отправляети сообщение error - сообщает о ошибках
            Console.ReadKey();
           


            //telegramClient.StopReceiving();


        }

  
        async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
           var massage = update.Message;
            if (massage.Text == "info") // есл входящее соббщение равно info 
            { 

                await botClient.SendTextMessageAsync(massage.Chat.Id,"server good");
                return;

            }



        }

        private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }

    }
}
