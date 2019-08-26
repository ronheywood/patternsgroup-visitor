using System.Collections.Generic;
using CompositeMenu.Aggregates;
using CompositeMenu.Logging;

namespace CompositeMenu.Client
{
    public class Waitress
    {
        private readonly ICompositeMenuConsole _compositeMenuConsole;
        private readonly IEnumerable<IEnumerable<MenuItem>> _menus;

        public Waitress(ICompositeMenuConsole breakfastLunchConsole, IEnumerable<IEnumerable<MenuItem>> menus)
        {
            _compositeMenuConsole = breakfastLunchConsole;
            _menus = menus;
        }

        public void PrintMenu(IEnumerable<MenuItem> printableMenu)
        {
            var menu = (IMenu)printableMenu;

            _compositeMenuConsole.WriteLine($"----------------{menu.Name} Menu-----------------");
            _compositeMenuConsole.WriteLine($"- {menu.Description}");

            var menuIterator = printableMenu.GetEnumerator();
            while (menuIterator.MoveNext())
            {
                var menuItem = menuIterator.Current;
                _compositeMenuConsole.WriteLine($"{menuItem.Name} -- {menuItem.Price}");
            }
        }

        public void PrintAll()
        {
            _compositeMenuConsole.WriteLine("**************************Menu***************************");
            _compositeMenuConsole.WriteLine("");

            var _menusIterator = _menus.GetEnumerator();
            while (_menusIterator.MoveNext())
            {
                PrintMenu(_menusIterator.Current);
            }
        }
    }
}