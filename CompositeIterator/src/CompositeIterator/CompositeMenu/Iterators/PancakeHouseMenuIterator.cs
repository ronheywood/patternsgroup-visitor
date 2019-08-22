using System.Collections;
using System.Collections.Generic;
using CompositeMenu.Aggregates;

namespace CompositeMenu.Iterators
{
    public class PancakeHouseMenuIterator : IEnumerator<MenuItem>
    {
        private readonly ArrayList _menuItems;
        private int count = 0;

        public PancakeHouseMenuIterator(ArrayList menuItems)
        {
            throw new System.NotImplementedException();
        }

        public bool HasNext()
        {
            return count < _menuItems.Count && _menuItems[count] != null;
        }

        public MenuItem Next()
        {
            throw new System.NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public MenuItem Current { get; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}