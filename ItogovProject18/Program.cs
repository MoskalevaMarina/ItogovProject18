using System;
using System.Net.Http;
using YoutubeExplode;


namespace ItogovProject18
{
    /// <summary>
    /// Клиентский код
    /// </summary>
    class Program
    {
             static void Main(string[] args)
        {
            Console.WriteLine("Введите ссылку на Youtube-видео");
            string url = Console.ReadLine(); // "https://www.youtube.com/watch?v=1La4QzGeaaQ";

      
            var client = new YoutubeClient();
            // создадим отправителя
            var sender = new Sender();

            // создадим получателя
            var receiver = new Receiver();

            // создадим команду 1
            var commandOne = new CommandOne(receiver);

            // инициализация команды
            sender.SetCommand(commandOne);

            //  выполнение
            sender.Run(client, url);

            // создадим команду 2
            var commandTwo = new CommandTwo(receiver);

            // инициализация команды
            sender.SetCommand(commandTwo);

            //  выполнение
            sender.Run(client, url);


        }
    }
}
