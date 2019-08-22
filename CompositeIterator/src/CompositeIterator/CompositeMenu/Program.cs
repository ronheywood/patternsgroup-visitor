using System;
using CompositeMenu.Aggregates;

namespace CompositeMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            var waitress = new Waitress(new DinerMenu());
            waitress.PrintMenu();
            Console.ReadKey();
        }
    }
}