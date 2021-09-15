using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telegram.Bot;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        

        static void Main(string[] args)
        {
            TelegramBotClient bot = new TelegramBotClient("1977873255:AAHphlQgsNW1SMWOH4WTOT_smNY8cARtSi8");
            bot.OnMessage += BotOnOnMessage;
            bot.StartReceiving();
            Console.ReadLine();

        }
        private static void BotOnOnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            
        }
    }
}
