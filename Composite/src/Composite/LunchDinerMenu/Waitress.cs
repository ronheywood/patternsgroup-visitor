using System;
using LunchDinerMenu.Aggregate;

namespace LunchDinerMenu
{
    public class Waitress
    {
        private readonly ITraversable<MenuItem> _menu;

        public Waitress(ITraversable<MenuItem> menu)
        {
            _menu = menu;
        }

        public void PrintMenu()
        {
            var menuIterator = _menu.GetIterator();
            while (menuIterator.HasNext())
            {
                var item = menuIterator.Next();
                Console.WriteLine($"{item.Name} -- {item.Price}");
            }

            Console.Read();
        }
    }
}