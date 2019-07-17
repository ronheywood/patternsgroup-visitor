using LunchDinerMenu.Iterator;

namespace LunchDinerMenu.Aggregate
{
    public class DinerMenu : ITraversable<MenuItem>
    {
        private readonly MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[100];
            LoadItems();
        }

        private void LoadItems()
        {
            _menuItems[0] = new MenuItem { Id = "1", Name = "Cottage Pie", Price = 11.5 };
            _menuItems[1] = new MenuItem { Id = "2", Name = "Soup of the Day", Price = 7.0 };
            _menuItems[2] = new MenuItem { Id = "3", Name = "Cheeseburger", Price = 10.2 };
        }

        public IIterator<MenuItem> GetIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }
    }
}