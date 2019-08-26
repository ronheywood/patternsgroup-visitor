using System.Collections;
using System.Collections.Generic;
using CompositeMenu.Aggregates;

namespace CompositeMenu.Iterators
{
    public class DinerMenuIterator : IEnumerator<MenuItem>
    {
        private int currentIndex = -1;

        private MenuItem[] DinerMenu { get; }

        public DinerMenuIterator(MenuItem[] dinerMenu)
        {
            DinerMenu = dinerMenu;
        }
        
        public bool MoveNext()
        {
            currentIndex++;
            if (DinerMenu.Length > currentIndex && DinerMenu[currentIndex] != null)
            {
                return true;
            }

            return false;
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public MenuItem Current => DinerMenu[currentIndex];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }
    }
}