using System;
using System.Collections;
using System.Collections.Generic;
using CompositeMenu.Iterators;

namespace CompositeMenu.Aggregates
{
    public class DinerMenu : IEnumerable<MenuItem>
    {
        private readonly MenuItem[] _menuItems;
        private int _numberOfItems = 0;
        private const int MaxNumberOfItems = 20;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MaxNumberOfItems];
            LoadMenu();
        }

        private void LoadMenu()
        {
            AddMenuItem(
                id: "1",
                name: "Cottage Pie",
                description: "Cottage pie with greens and mashed potatoes",
                price: 11.0,
                isVegetarian: false);
            AddMenuItem(
                id: "2",
                name: "Soup of the Day",
                description: "A bowl of soup of the day with a side of potatoes salad",
                price: 6.5,
                isVegetarian: true);
            AddMenuItem(
                id: "3",
                name: "Fish and Chips",
                description: "Beer battered cod with mushy peas and tartar sauce",
                price: 12.5,
                isVegetarian: false);
        }

        public void AddMenuItem(string id, string name, string description, double price, bool isVegetarian)
        {
            if (_numberOfItems >= MaxNumberOfItems)
            {
                throw new Exception("Menu is full!No more items can be added");
            }

            _menuItems[_numberOfItems] = new MenuItem(id, name, description, price, isVegetarian);
            _numberOfItems++;
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return new DinerMenuIterator(_menuItems);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
