using System.Collections;
using System.Collections.Generic;
using CompositeMenu.Aggregates;

namespace CompositeMenu.Iterators
{
    public class DinerMenuIterator : IEnumerator<MenuItem>
    {
        private int index = 0;

        private MenuItem[] DinerMenu { get; }

        public DinerMenuIterator(MenuItem[] dinerMenu)
        {
            DinerMenu = dinerMenu;
        }
        
        public bool MoveNext()
        {
            if (DinerMenu.Length > index && DinerMenu[index] != null)
            {
                index++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public MenuItem Current => DinerMenu[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}