using System.Collections;
using System.Collections.Generic;

namespace CompositeMenu.Aggregates
{
    public class PancakeHouseMenu : IEnumerable<MenuItem>
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
        
        public IEnumerator<MenuItem> GetEnumerator()
        {
            return new PancakeHouseIterator(_menuItems);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}