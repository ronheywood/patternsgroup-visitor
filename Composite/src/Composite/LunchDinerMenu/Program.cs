using System;
using LunchDinerMenu.Aggregate;

namespace LunchDinerMenu
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