using System;
using System.Collections.Generic;
using System.Text;
using YoutubeExplode;


namespace ItogovProject18
{
    /// <summary>
    /// Базовый класс команды
    /// </summary>
    abstract class Command
    {
        public abstract void Run(YoutubeClient client, string url);
        public abstract void Cancel();
    }
}
