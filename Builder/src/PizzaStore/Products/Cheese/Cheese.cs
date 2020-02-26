using PizzaStore.Interfaces;

namespace PizzaStore.Products.Cheese
{
    public abstract class Cheese : PizzaTopping
    {
    }

    public class RaggianoCheese : Cheese
    {
        public override string GetName()
        {
            return "Raggiano Cheese";
        }
    }
    public class MozarellaCheese : Cheese
    {
        public override string GetName()
        {
            return "Mozarella Cheese";
        }
    }
}