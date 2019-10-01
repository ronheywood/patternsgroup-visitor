using System;

namespace StarbuzzBaristaManual.Logging
{
    public class StarbuzzBaristaConsole : IConsole
    {
        public void WriteLine(string message) => Console.WriteLine(message);

        public string ReadKey() => Console.ReadKey().ToString();
    }
}