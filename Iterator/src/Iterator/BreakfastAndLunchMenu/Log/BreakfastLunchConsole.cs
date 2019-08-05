using System;

namespace BreakfastAndLunchMenu.Log
{
    public class BreakfastLunchConsole : IBreakfastLunchConsole
    {
        public void WriteLine(string message) => Console.WriteLine(message);

        public string ReadKey() => Console.ReadKey().ToString();
    }
}
