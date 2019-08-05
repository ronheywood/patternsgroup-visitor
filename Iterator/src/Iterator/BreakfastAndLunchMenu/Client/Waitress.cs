using BreakfastAndLunchMenu.Domain;
using BreakfastAndLunchMenu.Domain.Menu;
using BreakfastAndLunchMenu.Log;

namespace BreakfastAndLunchMenu.Client
{
    public class Waitress
    {
        private readonly IBreakfastLunchConsole _breakfastLunchConsole;
        private readonly PancakeHouseMenu _breakfastMenu;
        private readonly DinerMenu _lunchMenu;

        public Waitress(IBreakfastLunchConsole breakfastLunchConsole, PancakeHouseMenu breakfastMenu, DinerMenu lunchMenu)
        {
            _breakfastLunchConsole = breakfastLunchConsole;
            _breakfastMenu = breakfastMenu;
            _lunchMenu = lunchMenu;
        }

        public void PrintMenu()
        {
            _breakfastLunchConsole.WriteLine("**************************Menu***************************");
            _breakfastLunchConsole.WriteLine("");
            _breakfastLunchConsole.WriteLine("----------------Breakfast Menu-----------------");

            var breakfastMenuItems = _breakfastMenu.GetMenuItems();
            for (var i = 0; i < breakfastMenuItems.Count; i++)
            {
                var breakfastItem = (MenuItem)breakfastMenuItems[i];
                _breakfastLunchConsole.WriteLine($"{breakfastItem.Name} -- {breakfastItem.Price}");
            }

            _breakfastLunchConsole.WriteLine("");
            _breakfastLunchConsole.WriteLine("---------------Diner Menu------------------");

            var lunchMenuItems = _lunchMenu.GetMenuItems();
            for (var i = 0; i < lunchMenuItems.Length; i++)
            {
                var lunchItem = lunchMenuItems[i];

                if (lunchItem != null)
                {
                    _breakfastLunchConsole.WriteLine($"{lunchItem.Name} -- {lunchItem.Price}");
                }
            }
        }
    }
}