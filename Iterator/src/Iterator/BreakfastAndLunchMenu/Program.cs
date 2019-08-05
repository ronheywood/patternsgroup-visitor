using BreakfastAndLunchMenu.Log;
using System;
using BreakfastAndLunchMenu.Client;
using BreakfastAndLunchMenu.Domain.Menu;

namespace BreakfastAndLunchMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            var waitress = new Waitress(new BreakfastLunchConsole(), new PancakeHouseMenu(), new DinerMenu());
            waitress.PrintMenu();
            Console.ReadKey();
        }
    }
}