using System;
using PizzaStore.Interfaces;

namespace PizzaStore.Logging
{
    public class PizzaLogger : IConsole
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