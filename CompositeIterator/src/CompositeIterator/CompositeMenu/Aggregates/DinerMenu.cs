using System;
using System.Collections;
using System.Collections.Generic;
using CompositeMenu.Iterators;

namespace CompositeMenu.Aggregates
{
    public class DinerMenu : IEnumerable<MenuItem>, IMenu
    {
        private readonly MenuItem[] _menuItems;
        private int _numberOfItems = 0;
        private const int MaxNumberOfItems = 20;

        public string Name { get; set; }

        public string Description { get; set; }

        public DinerMenu(string name, string description)
        {
            Name = name;
            Description = description;
            _menuItems = new MenuItem[MaxNumberOfItems];
        }

        public void AddMenuItem(string name, string description, double price, bool isVegetarian)
        {
            if (_numberOfItems >= MaxNumberOfItems)
            {
                throw new Exception("Menu is full!No more items can be added");
            }

            _menuItems[_numberOfItems] = new MenuItem(name, description, price, isVegetarian);
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
