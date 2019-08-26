using System.Collections;
using System.Collections.Generic;

namespace CompositeMenu.Aggregates
{
    public class DessertMenu : IEnumerable<MenuItem>, IMenu
    {
        private readonly Queue<MenuItem> _menuItems;

        public string Name { get; set; }

        public string Description { get; set; }

        public DessertMenu(string name, string description)
        {
            Name = name;
            Description = description;
            _menuItems = new Queue<MenuItem>();
        }

        public void AddMenuItem(string name, string description, double price, bool isVegetarian)
        {
            _menuItems.Enqueue(new MenuItem(name, description, price, isVegetarian));
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return _menuItems.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}