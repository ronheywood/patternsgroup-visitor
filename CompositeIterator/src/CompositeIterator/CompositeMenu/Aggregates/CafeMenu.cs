using System.Collections;
using System.Collections.Generic;

namespace CompositeMenu.Aggregates
{
    public class CafeMenu : IEnumerable<MenuItem>, IMenu
    {
        private readonly List<MenuItem> _menuItems;

        public string Name { get; set; }

        public string Description { get; set; }

        public CafeMenu(string name, string description)
        {
            Name = name;
            Description = description;
            _menuItems = new List<MenuItem>();
        }

        public void AddMenuItem(string name, string description, double price, bool isVegetarian)
        {
            _menuItems.Add(new MenuItem(name, description, price, isVegetarian));
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