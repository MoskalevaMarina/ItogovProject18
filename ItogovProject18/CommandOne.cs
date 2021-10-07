using System;
using System.Collections.Generic;
using System.Text;
using YoutubeExplode;
using System.Net.Http;

namespace ItogovProject18
{
    /// <summary>
    /// Команда получения описания видео
    /// </summary>
    class CommandOne : Command
    {
        Receiver receiver;

        public CommandOne(Receiver receiver)
        {
            this.receiver = receiver;
        }

        // Выполнить
        public override void Run(YoutubeClient client, string url)
        {
            Console.WriteLine("Команда отправлена");
            receiver.Operation("Получение описания видео");
           
            var video = client.Videos.GetAsync(url);

            Console.WriteLine($"Название: {video.Result.Title}");
            Console.WriteLine($"Продолжительность: {video.Result.Duration}");
            Console.WriteLine($"Автор: {video.Result.Author}");

        }

        // Отменить
        public override void Cancel()
        { }
    }
}
