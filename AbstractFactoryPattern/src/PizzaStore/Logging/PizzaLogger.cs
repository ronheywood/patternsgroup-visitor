using System;

namespace PizzaStore
{
    internal class PizzaLogger : IConsole
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadKey()
        {
            return Console.ReadKey().ToString();
        }
    }
}