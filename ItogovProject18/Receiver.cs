using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProject18
{
    /// <summary>
    /// Адресат команды
    /// </summary>
    class Receiver
    {
        public void Operation(string text)
        {
            Console.WriteLine(text);
        }
    }
}
