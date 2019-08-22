using System;

namespace CompositeMenu.Logging
{
    public class CompositeMenuConsole : ICompositeMenuConsole
    {
        public void WriteLine(string message) => Console.WriteLine(message);

        public string ReadKey() => Console.ReadKey().ToString();
    }
}