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

        public void PrintMenu()
        {
            _compositeMenuConsole.WriteLine("**************************Menu***************************");
            _compositeMenuConsole.WriteLine("");
            _compositeMenuConsole.WriteLine("----------------Breakfast Menu-----------------");

            var breakfastMenuIterator = _breakfastMenu.GetIterator();
            if (breakfastMenuIterator.HasNext())
            {

            }

            for (var i = 0; i < breakfastMenuItems.Count; i++)
            {
                var breakfastItem = (MenuItem)breakfastMenuItems[i];
                _compositeMenuConsole.WriteLine($"{breakfastItem.Name} -- {breakfastItem.Price}");
            }

            _compositeMenuConsole.WriteLine("");
            _compositeMenuConsole.WriteLine("---------------Diner Menu------------------");

            var lunchMenuItems = _lunchMenu.GetMenuItems();
            for (var i = 0; i < lunchMenuItems.Length; i++)
            {
                var lunchItem = lunchMenuItems[i];

                if (lunchItem != null)
                {
                    _compositeMenuConsole.WriteLine($"{lunchItem.Name} -- {lunchItem.Price}");
                }
            }
        }
    }
}