using LunchDinerMenu.Aggregate;

namespace LunchDinerMenu.Iterator
{
    public class DinerMenuIterator : IIterator<MenuItem>
    {
        private int index = 0;
        
        private MenuItem[] DinerMenu { get; }

        public DinerMenuIterator(MenuItem[] dinerMenu)
        {
            DinerMenu = dinerMenu;
        }
        
        public bool HasNext()
        {
            return DinerMenu.Length > index && DinerMenu[index] != null;
        }

        public MenuItem Next()
        {
            var dinerMenu = DinerMenu[index];
            index++;
            return dinerMenu;
        }
    }
}
