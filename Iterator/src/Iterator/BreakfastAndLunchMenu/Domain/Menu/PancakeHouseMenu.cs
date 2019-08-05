using System.Collections;

namespace BreakfastAndLunchMenu.Domain.Menu
{
    public class PancakeHouseMenu
    {
        private readonly ArrayList _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new ArrayList();
            LoadMenu();
        }

        private void LoadMenu()
        {
            AddMenuItem(
                id: "1",
                name: "Regular Pancake Breakfast",
                description: "Pancakes with fried eggs and sausage",
                price: 5.5,
                isVegetarian: false);
            AddMenuItem(
                id: "2",
                name: "Blueberry Pancakes",
                description: "Pancakes made with fresh blueberries and blueberry syrup",
                price: 6.5,
                isVegetarian: true);
            AddMenuItem(
                id: "3",
                name: "Waffles",
                description: "Waffles with choice of blueberries or strawberries",
                price: 5.0,
                isVegetarian: true);
        }

        public void AddMenuItem(string id, string name, string description, double price, bool isVegetarian)
        {
            _menuItems.Add(new MenuItem(id, name, description, price, isVegetarian));
        }

        public ArrayList GetMenuItems()
        {
            return _menuItems;
        }
    }
}