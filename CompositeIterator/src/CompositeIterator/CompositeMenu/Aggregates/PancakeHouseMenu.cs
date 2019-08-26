using System.Collections;
using System.Collections.Generic;
using CompositeMenu.Iterators;

namespace CompositeMenu.Aggregates
{
    public class PancakeHouseMenu : IEnumerable<MenuItem>, IMenu
    {
        private readonly ArrayList _menuItems;

        public string Name { get; set; }

        public string Description { get; set; }

        public PancakeHouseMenu(string name, string description)
        {
            Name = name;
            Description = description;
            _menuItems = new ArrayList();
        }

        public void AddMenuItem(string name, string description, double price, bool isVegetarian)
        {
            _menuItems.Add(new MenuItem(name, description, price, isVegetarian));
        }
        
        public IEnumerator<MenuItem> GetEnumerator()
        {
            return new PancakeHouseMenuIterator(_menuItems);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}