using System;
using System.Collections.Generic;
using System.Text;
using YoutubeExplode;

namespace ItogovProject18
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    class Sender
    {
        Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        // Выполнить
        public void Run(YoutubeClient client, string url)
        {
            _command.Run(client, url);
        }

        // Отменить
        public void Cancel()
        {
            _command.Cancel();
        }
    }
}
