using System;
using System.Collections.Generic;
using DuckSimulator.Ducks;

namespace DuckSimulator
{
    internal class Program
    {
        private static readonly DuckSimulator DuckSimulator = new DuckSimulator(new List<Duck>() { new MallardDuck(), new RedheadDuck(), new RubberDuck() });

        private static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Console.WriteLine("Welcome to DuckSimulator!");

            DuckSimulator.SimulateDucks();
            AwaitUserAction();
        }

        private static void AwaitUserAction()
        {
            Console.WriteLine("\r\nPress the [s] key to make them swim about!");
            Console.WriteLine("Press the [q] key to hear them quack!");
            Console.WriteLine("(Press escape to exit)");

            var key = new ConsoleKeyInfo();
            while (key.Key != ConsoleKey.Escape)
            {
                key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case 's':
                        DuckSimulator.MakeDucksSwim();
                        break;
                    case 'q':
                        DuckSimulator.MakeDucksQuack();
                        break;
                    default: continue;
                }
            }
        }
    }
}
