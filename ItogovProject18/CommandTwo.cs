using System;
using System.Collections.Generic;
using System.Text;
using YoutubeExplode;
using System.Net.Http;
using YoutubeExplode.Videos.Streams;
using YoutubeExplode.Converter;

namespace ItogovProject18
{
    /// <summary>
    /// Команда загрузки видео.
    /// </summary>
    class CommandTwo : Command
    {
        Receiver receiver;

        public CommandTwo(Receiver receiver)
        {
            this.receiver = receiver;
        }

        // Выполнить
        public override void Run(YoutubeClient client, string url)
        {
            Console.WriteLine("Команда отправлена");
            receiver.Operation("Скачивание видео");

            var streamManifest = client.Videos.Streams.GetManifestAsync(url);
            var streamInfo = streamManifest.Result.GetMuxedStreams().GetWithHighestVideoQuality();
          

           client.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
            receiver.Operation("Скачивание видео завершено");

          //  client.Videos.DownloadAsync(url, "video1.mp4");

        }

        // Отменить
        public override void Cancel()
        { }
    }
}
