using System.Collections;
using System.Collections.Generic;
using CompositeMenu.Aggregates;

namespace CompositeMenu.Iterators
{
    public class PancakeHouseMenuIterator : IEnumerator<MenuItem>
    {
        private readonly ArrayList _menuItems;
        private int currentIndex = -1;

        public PancakeHouseMenuIterator(ArrayList menuItems)
        {
            _menuItems = menuItems;
        }
        
        public bool MoveNext()
        {
            currentIndex++;
            if (currentIndex < _menuItems.Count && _menuItems[currentIndex] != null)
            {
                return true;
            }

            return false;
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public MenuItem Current => (MenuItem)_menuItems[currentIndex];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }
    }
}