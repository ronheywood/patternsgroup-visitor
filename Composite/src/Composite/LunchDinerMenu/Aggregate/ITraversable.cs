using LunchDinerMenu.Iterator;

namespace LunchDinerMenu.Aggregate
{
    public interface ITraversable<T>
    {
        IIterator<T> GetIterator();
    }
}